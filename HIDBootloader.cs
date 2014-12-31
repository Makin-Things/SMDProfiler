using Microsoft.Win32.SafeHandles;
using System;
using System.IO;
using System.Runtime.InteropServices;

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace SMDProfiler
{

	public class HIDBootloader
	{
		private SMDReflowProfiler mainForm;
		private Hid MyHid = new Hid();
		private FileStream fileStreamDeviceData;
		private SafeFileHandle hidHandle;
		private String hidUsage;
		private Boolean bBootloaderOpen;
		private String myDevicePathName = "";
		private Boolean transferInProgress = false;
		private static System.Timers.Timer tmrReadTimeout;
		private static System.Timers.Timer tmrContinuousDataCollect;

//------------------------------------------------------------------------------------------------------------------------------

		public HIDBootloader(SMDReflowProfiler myForm)
		{
			mainForm = myForm;

			tmrContinuousDataCollect = new System.Timers.Timer(100);
			tmrContinuousDataCollect.Elapsed += new ElapsedEventHandler(OnDataCollect);
			tmrContinuousDataCollect.Enabled = true;
			tmrContinuousDataCollect.Start();
			tmrContinuousDataCollect.SynchronizingObject = myForm;

			tmrReadTimeout = new System.Timers.Timer(5000);
			tmrReadTimeout.Elapsed += new ElapsedEventHandler(OnReadTimeout);
			tmrReadTimeout.Stop();
		}

//------------------------------------------------------------------------------------------------------------------------------

		public Boolean IsBootloaderOpen
		{
			get { return bBootloaderOpen; }
		}

//------------------------------------------------------------------------------------------------------------------------------

		public Boolean DeviceNameIsEmpty
		{
			get { return (myDevicePathName == ""); }
		}

//------------------------------------------------------------------------------------------------------------------------------

		public String DevicePathName
		{
			get { return myDevicePathName; }
		}

//------------------------------------------------------------------------------------------------------------------------------

		public void OpenTheHid()
		{
			try
			{
				bBootloaderOpen = true;
				hidHandle = FileIO.CreateFile(myDevicePathName, FileIO.GENERIC_READ | FileIO.GENERIC_WRITE, FileIO.FILE_SHARE_READ | FileIO.FILE_SHARE_WRITE, IntPtr.Zero, FileIO.OPEN_EXISTING, 0, 0);

				if (hidHandle.IsInvalid)
				{
					//					exclusiveAccess = true;
					/*					txtDataReceived.AppendText("The device is a system " + hidUsage + ".\n");
										txtDataReceived.AppendText("Windows 2000 and Windows XP obtain exclusive access to Input and Output reports for this devices.\n");
										txtDataReceived.AppendText("Applications can access Feature reports only.\n"); */
					//					txtDataReceived.ScrollToCaret();
				}
				else
				{
					if (MyHid.Capabilities.InputReportByteLength > 0)
					{
						//  Set the size of the Input report buffer. 

						Byte[] inputReportBuffer = null;

						inputReportBuffer = new Byte[MyHid.Capabilities.InputReportByteLength];

						fileStreamDeviceData = new FileStream(hidHandle, FileAccess.Read | FileAccess.Write, inputReportBuffer.Length, false);
					}

					if (MyHid.Capabilities.OutputReportByteLength > 0)
					{
						Byte[] outputReportBuffer = null;
						outputReportBuffer = new Byte[MyHid.Capabilities.OutputReportByteLength];
					}

					//  Flush any waiting reports in the input buffer. (optional)

					MyHid.FlushQueue(hidHandle);
				}
			}
			catch (Exception ex)
			{
				bBootloaderOpen = false;
//qqq				DisplayException(this.Name, ex);
				throw;
			}
		}

//------------------------------------------------------------------------------------------------------------------------------

		public Boolean FindTheHid()
		{
			int deviceFound;
			String[] devicePathName = new String[128];
			Guid hidGuid = Guid.Empty;
			Int32 myProductID = 0x7000;
			Int32 myVendorID = 0x1D50;
			Boolean success = false;
			DeviceManagement dm = new DeviceManagement();

			try
			{
				bBootloaderOpen = false;

				closeBootloader();

				//  ***
				//  API function: 'HidD_GetHidGuid

				//  Purpose: Retrieves the interface class GUID for the HID class.

				//  Accepts: 'A System.Guid object for storing the GUID.
				Hid.HidD_GetHidGuid(ref hidGuid);

				//  Fill an array with the device path names of all attached HIDs.

				deviceFound = dm.FindDeviceFromGuid(hidGuid, ref devicePathName);

				//  If there is at least one HID, attempt to read the Vendor ID and Product ID
				//  of each device until there is a match or all devices have been examined.

				for (int i = 0; i < deviceFound; i++)
				{
					//  ***
					//  API function:
					//  CreateFile

					//  Purpose:
					//  Retrieves a handle to a device.

					//  Accepts:
					//  A device path name returned by SetupDiGetDeviceInterfaceDetail
					//  The type of access requested (read/write).
					//  FILE_SHARE attributes to allow other processes to access the device while this handle is open.
					//  A Security structure or IntPtr.Zero. 
					//  A creation disposition value. Use OPEN_EXISTING for devices.
					//  Flags and attributes for files. Not used for devices.
					//  Handle to a template file. Not used.

					//  Returns: a handle without read or write access.
					//  This enables obtaining information about all HIDs, even system
					//  keyboards and mice. 
					//  Separate handles are used for reading and writing.
					//  ***

					// Open the handle without read/write access to enable getting information about any HID, even system keyboards and mice.

					hidHandle = FileIO.CreateFile(devicePathName[i], 0, FileIO.FILE_SHARE_READ | FileIO.FILE_SHARE_WRITE, IntPtr.Zero, FileIO.OPEN_EXISTING, 0, 0);

					//srr						Debug.WriteLine("  Returned handle: " + hidHandle.ToString());

					if (!hidHandle.IsInvalid)
					{
						//  The returned handle is valid, 
						//  so find out if this is the device we're looking for.

						//  Set the Size property of DeviceAttributes to the number of bytes in the structure.

						MyHid.DeviceAttributes.Size = Marshal.SizeOf(MyHid.DeviceAttributes);

						//  ***
						//  API function:
						//  HidD_GetAttributes

						//  Purpose:
						//  Retrieves a HIDD_ATTRIBUTES structure containing the Vendor ID, 
						//  Product ID, and Product Version Number for a device.

						//  Accepts:
						//  A handle returned by CreateFile.
						//  A pointer to receive a HIDD_ATTRIBUTES structure.

						//  Returns:
						//  True on success, False on failure.
						//  ***                            

						success = Hid.HidD_GetAttributes(hidHandle, ref MyHid.DeviceAttributes);

						if (success)
						{
							/*								Debug.WriteLine("  HIDD_ATTRIBUTES structure filled without error.");
														Debug.WriteLine("  Structure size: " + MyHid.DeviceAttributes.Size);
														Debug.WriteLine("  Vendor ID: " + Convert.ToString(MyHid.DeviceAttributes.VendorID, 16));
														Debug.WriteLine("  Product ID: " + Convert.ToString(MyHid.DeviceAttributes.ProductID, 16));
														Debug.WriteLine("  Version Number: " + Convert.ToString(MyHid.DeviceAttributes.VersionNumber, 16));
							*/
							//  Find out if the device matches the one we're looking for.

							if ((MyHid.DeviceAttributes.VendorID == myVendorID) && (MyHid.DeviceAttributes.ProductID == myProductID))
							{
								Debug.WriteLine("  Bootloader detected");

								//  Display the information in form's list box.

								mainForm.OutputText("Bootloader detected:");
								mainForm.OutputText("  Vendor ID= " + Convert.ToString(MyHid.DeviceAttributes.VendorID, 16));
								mainForm.OutputText("  Product ID = " + Convert.ToString(MyHid.DeviceAttributes.ProductID, 16));

								bBootloaderOpen = true;

								//  Save the DevicePathName for OnDeviceChange().

								myDevicePathName = devicePathName[i];
								break;
							}
							else
							{
								//  It's not a match, so close the handle.
								hidHandle.Close();
							}
						}
						else
						{
							//  There was a problem in retrieving the information.
							Debug.WriteLine("  Error in filling HIDD_ATTRIBUTES structure.");
							hidHandle.Close();
						}
					}
				}

				if (bBootloaderOpen)
				{
					//  The device was detected.

					//  Learn the capabilities of the device.
					MyHid.Capabilities = MyHid.GetDeviceCapabilities(hidHandle);

					if (success)
					{
						//  Find out if the device is a system mouse or keyboard.

						hidUsage = MyHid.GetHidUsage(MyHid.Capabilities);

						//  Get the Input report buffer size.

						GetInputReportBufferSize();
						//srr						cmdInputReportBufferSize.Enabled = true;

						//Close the handle and reopen it with read/write access.

						hidHandle.Close();

						OpenTheHid();
					}
				}
				else
				{
					//  The device wasn't detected.

//qqq					OutputText("Bootloader not found.");
					//srr					cmdInputReportBufferSize.Enabled = false;
					//srr					cmdOnce.Enabled = true;

					Debug.WriteLine(" Bootloader not found.");

				}
				return bBootloaderOpen;
			}
			catch (Exception ex)
			{
//qqq				DisplayException(this.Name, ex);
				throw;
			}
		}

//------------------------------------------------------------------------------------------------------------------------------

		private void GetInputReportBufferSize()
		{
			Int32 numberOfInputBuffers = 0;
			Boolean success;

			try
			{
				//  Get the number of input buffers.

				success = MyHid.GetNumberOfInputBuffers(hidHandle, ref numberOfInputBuffers);

				//  Display the result in the text box.

//qqq				OutputText("Buffer Size: " + Convert.ToString(numberOfInputBuffers));
			}
			catch (Exception ex)
			{
//qqq				DisplayException(this.Name, ex);
				throw;
			}
		}

//------------------------------------------------------------------------------------------------------------------------------

		public void closeBootloader()
		{
			if (fileStreamDeviceData != null)
			{
				fileStreamDeviceData.Close();
			}

			if ((hidHandle != null) && (!(hidHandle.IsInvalid)))
			{
				hidHandle.Close();
			}

			// The next attempt to communicate will get new handles and FileStreams.

			bBootloaderOpen = false;
			transferInProgress = false;
		}

//------------------------------------------------------------------------------------------------------------------------------

		public Boolean ProgramFlash(String filename)
		{
			FileStream inFile;
			bool success;
            int version;

			try
			{
				inFile = new FileStream(filename, FileMode.Open);
				if (!inFile.CanRead)
				{
					mainForm.OutputText("Error: File '" + filename + "' not found.");
					return false;
				}

				long bufferSize = inFile.Length / 2;
				byte[] buffer = new byte[bufferSize];
				byte[] buf = new byte[2];
				int frameSize;
				byte[] outputReportBuffer = new Byte[MyHid.Capabilities.OutputReportByteLength];

				// Read the whole file into the buffer
				for (int index = 0; index < bufferSize; index++)
				{
					inFile.Read(buf, 0, 2);
					buffer[index] = byte.Parse(System.Text.Encoding.ASCII.GetString(buf), System.Globalization.NumberStyles.AllowHexSpecifier);
				}

				inFile.Close();

                version = (buffer[0] << 8) | (buffer[1]);

				for (int index = 2; index < bufferSize; index += frameSize)
				{
					frameSize = ((buffer[index] << 8) | buffer[index + 1]) + 2;
					Debug.WriteLine("Framesize = " + frameSize);
					outputReportBuffer[0] = 0;
					for (int i = 0; i < frameSize; i++)
					{
						outputReportBuffer[i + 1] = buffer[index + i];
					}
					success = MyHid.SendOutputReportViaControlTransfer(hidHandle, outputReportBuffer);

					if (!success)
					{
						mainForm.OutputText("Error programming flash");
						return false;
					}
				}

				return true;
			}
			catch (Exception ex)
			{
//qqq				mainForm.DisplayException(this.myDevicePathName, ex);
				return false;
			}
		}

//------------------------------------------------------------------------------------------------------------------------------

		private void OnDataCollect(object source, ElapsedEventArgs e)
		{
			try
			{
				if (transferInProgress == false)
				{
					ReadFromDevice();
				}
			}
			catch (Exception ex)
			{
//qqq				DisplayException(this.Name, ex);
				throw;
			}
		}

//------------------------------------------------------------------------------------------------------------------------------

		private void OnReadTimeout(object source, ElapsedEventArgs e)
		{
//qqq			MyMarshalToForm("AddItemToListBox", "The attempt to read a report timed out.");

			closeBootloader();

			tmrReadTimeout.Stop();

			//  Enable requesting another transfer.

//qqq			MyMarshalToForm("EnableCmdOnce", "");
//qqq			MyMarshalToForm("ScrollToBottomOfListBox", "");
		}

//------------------------------------------------------------------------------------------------------------------------------

		private void ReadFromDevice()
		{
			// Report header for the debug display:

//srr			Debug.WriteLine("");
//srr			Debug.WriteLine("***** HID Test Report *****");
//srr			Debug.WriteLine(DateAndTime.Today + ": " + DateAndTime.TimeOfDay);

			try
			{
				//  If the device hasn't been detected, was removed, or timed out on a previous attempt
				//  to access it, look for the device.

//srr				if ((myDeviceDetected == false))
//srr				{
//srr					myDeviceDetected = FindTheHid();
//srr				}

				if ((bBootloaderOpen == true))
				{
					//  Get the bytes to send in a report from the combo boxes.
					//  Increment the values if the autoincrement check box is selected.

					//  An option button selects whether to exchange Input and Output reports
					//  or Feature reports.

					ExchangeInputReport();
				}
			}
			catch (Exception ex)
			{
//qqq				DisplayException(this.Name, ex);
				throw;
			}
		}

//------------------------------------------------------------------------------------------------------------------------------

		private void ExchangeInputReport()
		{
			String byteValue = null;
			Int32 count = 0;
			Byte[] inputReportBuffer = null;
			Byte[] outputReportBuffer = null;
			Boolean success = false;

			try
			{
				success = false;

				//  Don't attempt to exchange reports if valid handles aren't available
				//  (as for a mouse or keyboard under Windows 2000/XP.)

				if (!hidHandle.IsInvalid)
				{
					//  Read an Input report.

					success = false;

					//  Don't attempt to send an Input report if the HID has no Input report.
					//  (The HID spec requires all HIDs to have an interrupt IN endpoint,
					//  which suggests that all HIDs must support Input reports.)

					if (MyHid.Capabilities.InputReportByteLength > 0)
					{
						//  Set the size of the Input report buffer. 

						inputReportBuffer = new Byte[MyHid.Capabilities.InputReportByteLength];

						//  Read a report using interrupt transfers.                
						//  To enable reading a report without blocking the main thread, this
						//  application uses an asynchronous delegate.

						IAsyncResult ar = null;
						transferInProgress = true;

						// Timeout if no report is available.

						tmrReadTimeout.Start();

						if (fileStreamDeviceData.CanRead)
						{
							fileStreamDeviceData.BeginRead(inputReportBuffer, 0, inputReportBuffer.Length, new AsyncCallback(GetInputReportData), inputReportBuffer);
						}
						else
						{
							closeBootloader();
//qqq							OutputText("The attempt to read an Input report has failed.");
						}
					}
					else
					{
//srr						txtDataReceived.AppendText("No attempt to read an Input report was made.\n");
//srr						txtDataReceived.AppendText("The HID doesn't have an Input report.\n");
					}
				}
				else
				{
//qqq					OutputText("Invalid handle. The device is probably a system mouse or keyboard.");
//qqq					OutputText("No attempt to write an Output report or read an Input report was made.");
				}
			}
			catch (Exception ex)
			{
//qqq				DisplayException(this.Name, ex);
				throw;
			}
		}

//------------------------------------------------------------------------------------------------------------------------------

		private void GetInputReportData(IAsyncResult ar)
		{
			String byteValue = null;
			Int32 count = 0;
			Byte[] inputReportBuffer = null;
			Boolean success = false;

			try
			{
				inputReportBuffer = (byte[])ar.AsyncState;

				fileStreamDeviceData.EndRead(ar);

				tmrReadTimeout.Stop();

				if ((ar.IsCompleted))
				{
//qqq					MyMarshalToForm("AddItemToListBox", "An Input report has been read.");
//qqq					MyMarshalToForm("AddItemToListBox", " Input Report ID: " + String.Format("{0:X2} ", inputReportBuffer[0]));
//qqq					MyMarshalToForm("AddItemToListBox", " Input Report Data:");

					for (count = 0; count <= inputReportBuffer.Length - 1; count++)
					{
						//  Display bytes as 2-character Hex strings.

						byteValue = String.Format("{0:X2} ", inputReportBuffer[count]);

//qqq						MyMarshalToForm("AddItemToListBox", " " + byteValue);
						//srr						MyMarshalToForm("TextBoxSelectionStart", txtBytesReceived.Text);
						//srr						MyMarshalToForm("AddItemToTextBox", byteValue);
					}
				}
				else
				{
//qqq					MyMarshalToForm("AddItemToListBox", "The attempt to read an Input report has failed.");
					Debug.Write("The attempt to read an Input report has failed");
				}

//qqq				MyMarshalToForm("ScrollToBottomOfListBox", "");

				//  Enable requesting another transfer.

				//srr				MyMarshalToForm("EnableCmdOnce", "");
				transferInProgress = false;
			}
			catch (IOException)
			{
			}
			catch (Exception ex)
			{
//qqq				DisplayException(this.Name, ex);
//srr				throw;
			}
		}
	}
}
