using System.IO;
using System.Runtime.InteropServices;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SMDProfiler
{

	public partial class SMDReflowProfiler : Form
	{
		internal SMDReflowProfiler FrmMy;
		
		static VirtualSerialPort _virtualSerialPort;
		static VirtualSerialPorts virtualSerialPortList;

		static HIDBootloader _hidBootloader;

		Dictionary<string, __processSeries> series;

		private string process;
		private int lastSeries;
		private decimal tempStart;
		private int timeStart;

		private IntPtr deviceNotificationHandle1;
		private IntPtr deviceNotificationHandle2;

		private DeviceManagement MyDeviceManagement = new DeviceManagement();

		private delegate void MarshalToForm(String action, String textToAdd);

//------------------------------------------------------------------------------------------------------------------------------

		public SMDReflowProfiler()
		{
			InitializeComponent();

			series = new Dictionary<string,__processSeries>(4);
			series.Add("=RUN", new __processSeries("RUN", new string[] { "Preheat", "Preheat cutoff", "Soak", "Reflow", "Reflow cutoff", "Open door", "Cooldown" }, 
													new System.Drawing.Color[] { Color.LightSkyBlue, Color.Gold, Color.LawnGreen, Color.Red, Color.DarkOrange, Color.MediumOrchid, Color.MediumSlateBlue }, 360, 250, setup_Process_RUN, Process_RUN));
			series.Add("=OCAL", new __processSeries("OCAL", new string[] { "5%", "10%", "15%", "20%", "25%", "30%", "35%", "40%", "45%", "50%"},
                                                    new System.Drawing.Color[] { Color.LightSkyBlue, Color.Gold, Color.LawnGreen, Color.Red, Color.DarkOrange, Color.MediumOrchid, Color.MediumSlateBlue, Color.LightSalmon, Color.Moccasin, Color.Peru}, 900, 300, setup_Process_OCAL, Process_OCAL));
			series.Add("=END", new __processSeries(end_Process));
			series.Add("=ABORT", new __processSeries(abort_Process));
			series.Add("=OGET", new __processSeries(oven_get));
		}

//------------------------------------------------------------------------------------------------------------------------------

		private void Form1_Load(object sender, EventArgs e)
		{
			Guid hidGuid = Guid.Empty;
			Guid comGuid = new Guid(0x4D36E978,0xE325,0x11CE,0xBF,0xC1,0x08,0x00,0x2B,0xE1,0x03,0x18);

			Boolean success = false;

			FrmMy = this;

			//  Accepts: 'A System.Guid object for storing the GUID.
			Hid.HidD_GetHidGuid(ref hidGuid);

			//  Register to receive notifications if the device is removed or attached.
			success = MyDeviceManagement.RegisterForDeviceNotifications(FrmMy.Handle, hidGuid, ref deviceNotificationHandle1);
			success = MyDeviceManagement.RegisterForDeviceNotifications(FrmMy.Handle, comGuid, ref deviceNotificationHandle2);
			Debug.WriteLine("RegisterForDeviceNotifications = " + success);

			virtualSerialPortList = new VirtualSerialPorts(this);
			if (virtualSerialPortList.Count == 1)
			{
				_virtualSerialPort = virtualSerialPortList.Open(cbbCOMPorts.Text);
			}

			_hidBootloader = new HIDBootloader(this);

			_hidBootloader.FindTheHid();
		}

//------------------------------------------------------------------------------------------------------------------------------

		private void Form1_Close(object sender, FormClosingEventArgs e)
		{
			DeviceManagement.UnregisterDeviceNotification(deviceNotificationHandle1);
			DeviceManagement.UnregisterDeviceNotification(deviceNotificationHandle2);
		}

//------------------------------------------------------------------------------------------------------------------------------

		private void btnConnect_Click(object sender, EventArgs e)
		{
			try
			{
				_virtualSerialPort = virtualSerialPortList.Open(cbbCOMPorts.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

//------------------------------------------------------------------------------------------------------------------------------

		public bool ButtonConnectState
		{
			set { btnConnect.Enabled = value; }
		}

//------------------------------------------------------------------------------------------------------------------------------

		private void btnDisconnect_Click(object sender, EventArgs e)
		{
			try
			{
				_virtualSerialPort.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

//------------------------------------------------------------------------------------------------------------------------------

		public bool ButtonDisonnectState
		{
			set { btnDisconnect.Enabled = value; }
		}

//------------------------------------------------------------------------------------------------------------------------------

		private void btnProgram_Click(object sender, EventArgs e)
		{
			try
			{
				if (!_hidBootloader.IsBootloaderOpen)
				{
					_virtualSerialPort.WriteLine("**BOOT");
					_virtualSerialPort.Close();

					Thread.CurrentThread.Join(2000);
				}

				if (_hidBootloader.IsBootloaderOpen)
				{
<<<<<<< .mine
					_hidBootloader.ProgramFlash("C:\\Develop\\Reflow Oven USB\\Reflow Oven USB\\Release\\Reflow Oven USB.enc");
=======
					_hidBootloader.ProgramFlash("Z:\\Temp\\Reflow Oven USB.enc");
>>>>>>> .r2
				}
			}
			catch (Exception ex)
			{
				DisplayException(this.Name, ex);
				throw;
			}
		}

//------------------------------------------------------------------------------------------------------------------------------

		private void btnBootldr_Click(object sender, EventArgs e)
		{
			try
			{
				_virtualSerialPort.WriteLine("**BOOT");
				_virtualSerialPort.Close();
			}
			catch (Exception ex)
			{
				DisplayException(this.Name, ex);
				throw;
			}
		}

//------------------------------------------------------------------------------------------------------------------------------

		private void btnGetOven_Click(object sender, EventArgs e)
		{
			try
			{
				_virtualSerialPort.WriteLine("**OGET");
			}
			catch (Exception ex)
			{
				DisplayException(this.Name, ex);
				throw;
			}
		}

//------------------------------------------------------------------------------------------------------------------------------

		public void OutputText(string text)
		{
			txtDataReceived.AppendText(text+"\n");
			txtDataReceived.ScrollToCaret();
		}
//------------------------------------------------------------------------------------------------------------------------------

		public void ComPortsClear()
		{
			cbbCOMPorts.Items.Clear();
		}

//------------------------------------------------------------------------------------------------------------------------------

		public void ComPortsAdd(string item)
		{
			cbbCOMPorts.Items.Add(item);
			cbbCOMPorts.SelectedIndex = 0;
		}

//------------------------------------------------------------------------------------------------------------------------------

		private void clearGraph()
		{
			chart1.Series.Clear();
//			chart1.Legends.Clear();
		}

//------------------------------------------------------------------------------------------------------------------------------

		private void createGraph(string type)
		{
			int i;

			clearGraph();

			chart1.ChartAreas.FindByName("ChartArea1").AxisX.Maximum = series[type].MaxX;
			chart1.ChartAreas.FindByName("ChartArea1").AxisY.Maximum = series[type].MaxY;
			for (i = 0; i < series[type].SeriesNames.Length; i++)
			{
				chart1.Series.Add(series[type].SeriesNames[i]);
				chart1.Series.FindByName(series[type].SeriesNames[i]).Color = series[type].SeriesColours[i];
				chart1.Series.FindByName(series[type].SeriesNames[i]).ChartType = SeriesChartType.FastLine;
				chart1.Series.FindByName(series[type].SeriesNames[i]).BorderWidth = 2;
		  }
    }

//------------------------------------------------------------------------------------------------------------------------------

		internal void OnDeviceChange(Message m)
		{
			Debug.WriteLine("WM_DEVICECHANGE");

			String sComPort = "";
			Boolean success = false;

			try
			{
				if (m.LParam.ToInt32() != 0)
				{
					DeviceManagement.DEV_BROADCAST_HDR lpdb = (DeviceManagement.DEV_BROADCAST_HDR)Marshal.PtrToStructure(m.LParam, typeof(DeviceManagement.DEV_BROADCAST_HDR));

					if (lpdb.dbch_devicetype == DeviceManagement.DBT_DEVTYP_DEVICEINTERFACE)
					{
						DeviceManagement.DEV_BROADCAST_DEVICEINTERFACE_1 lpdev = (DeviceManagement.DEV_BROADCAST_DEVICEINTERFACE_1)Marshal.PtrToStructure(m.LParam, typeof(DeviceManagement.DEV_BROADCAST_DEVICEINTERFACE_1));
						String sDev = new String(lpdev.dbcc_name, 0, (lpdev.dbcc_size-32)/2);

						success = MyDeviceManagement.getComPortName(sDev, ref sComPort);
					}
				}

				if ((m.WParam.ToInt32() == DeviceManagement.DBT_DEVICEARRIVAL))
				{
					//  If WParam contains DBT_DEVICEARRIVAL, a device has been attached.
					Debug.WriteLine("A device has been attached.");

					if (success) //Found a virtual serial port for the reflow oven
					{
						Debug.WriteLine("Found reflow oven.");
						_virtualSerialPort = virtualSerialPortList.Open(sComPort);
					}
					else // See if we can find the Bootloader
					{
						if (_hidBootloader.DeviceNameIsEmpty)
						{
							_hidBootloader.FindTheHid();
						}

						//  Find out if it's the device we're communicating with.
						if (MyDeviceManagement.DeviceNameMatch(m, _hidBootloader.DevicePathName))
						{
							OutputText("Bootloader attached.");
							_hidBootloader.OpenTheHid();
						}
					}
				}
				else if ((m.WParam.ToInt32() == DeviceManagement.DBT_DEVICEREMOVECOMPLETE))
				{
					//  If WParam contains DBT_DEVICEREMOVAL, a device has been removed.
					Debug.WriteLine("A device has been removed.");

					//  Find out if it's the device we're communicating with.
					if (MyDeviceManagement.DeviceNameMatch(m, _hidBootloader.DevicePathName))
					{
						OutputText("Bootloader removed.");

						//  Set MyDeviceDetected False so on the next data-transfer attempt,
						//  FindTheHid() will be called to look for the device 
						//  and get a new handle.
						_hidBootloader.closeBootloader();
					}

					if (success && (_virtualSerialPort.PortName == sComPort))
					{
						_virtualSerialPort.Close();
					}

//					findVirtualPorts();
				}
			}
			catch (Exception ex)
			{
				DisplayException(this.Name, ex);
				throw;
			}
		}

//------------------------------------------------------------------------------------------------------------------------------

		internal static void DisplayException(String moduleName, Exception e)
		{
			String message = null;
			String caption = null;

			//  Create an error message.

			message = "Exception: " + e.Message + "\r\n" + "Module: " + moduleName + "\r\n" + "Method: " + e.TargetSite.Name;

			caption = "Unexpected Exception";

			MessageBox.Show(message, caption, MessageBoxButtons.OK);
			Debug.Write(message);
		}

//------------------------------------------------------------------------------------------------------------------------------
		
		private void AccessForm(String action, String formText)
		{
			try
			{
				//  Select an action to perform on the form:

				switch (action)
				{
					case "AddItemToListBox":
						OutputText(formText);
						break;

//srr					case "AddItemToTextBox":
//srr						txtBytesReceived.SelectedText = formText + "\r\n";
//srr						break;

//srr					case "EnableCmdOnce":
//srr						//  If it's a single transfer, re-enable the command button.
//srr						if (cmdContinuous.Text == "Continuous")
//srr						{
//srr							cmdOnce.Enabled = true;
//srr						}
//srr						break;

					case "ScrollToBottomOfListBox":
						txtDataReceived.ScrollToCaret();
						break;

//srr					case "TextBoxSelectionStart":
//srr						txtBytesReceived.SelectionStart = formText.Length;
//srr						break;

					default:
						break;
				}
			}
			catch (Exception ex)
			{
				DisplayException(this.Name, ex);
				throw;
			}
		}
		
//------------------------------------------------------------------------------------------------------------------------------

		private void MyMarshalToForm(String action, String textToDisplay)
		{
			object[] args = { action, textToDisplay };
			MarshalToForm MarshalToFormDelegate = null;

			//  The AccessForm routine contains the code that accesses the form.

			MarshalToFormDelegate = new MarshalToForm(AccessForm);

			//  Execute AccessForm, passing the parameters in args.

			base.Invoke(MarshalToFormDelegate, args);
		}

//------------------------------------------------------------------------------------------------------------------------------

		protected override void WndProc(ref Message m)
		{
			try
			{
				//  The OnDeviceChange routine processes WM_DEVICECHANGE messages.

				if (m.Msg == DeviceManagement.WM_DEVICECHANGE)
				{
					OnDeviceChange(m);
				}

				//  Let the base form process the message.

				base.WndProc(ref m);
			}
			catch (Exception ex)
			{
				DisplayException(this.Name, ex);
				throw;
			}
		}

//------------------------------------------------------------------------------------------------------------------------------

		private void setup_Process_OCAL(string[] bits)
		{
			createGraph(process);
			lastSeries = 3;
			lblProcess.Text = series[process].SeriesProcess + " - " + series[process].SeriesNames[0];
			lblProcess.ForeColor = Color.Red;
		}
		
//------------------------------------------------------------------------------------------------------------------------------

		private void Process_OCAL(string[] bits)
		{
			if (lastSeries != Convert.ToInt16(bits[0]))
			{
				lblProcess.Text = series[process].SeriesProcess + " - " + series[process].SeriesNames[Convert.ToInt16(bits[0]) - 3];

				lastSeries = Convert.ToInt16(bits[0]);
			}
		}

		//------------------------------------------------------------------------------------------------------------------------------

		private void setup_Process_RUN(string[] bits)
		{
			createGraph(process);
			lastSeries = 3;
			lblProcess.Text = series[process].SeriesProcess + " - " + series[process].SeriesNames[0];
			lblProcess.ForeColor = Color.Red;
			lblPName.Text = bits[1];
			lblPreheatTemp.Text = bits[2];
			lblSoakDutycycle.Text = bits[3] + "%";
			lblSoakTemp.Text = bits[4];
			lblReflowTime.Text = bits[5];
			lblReflowTemp.Text = bits[6];
			lblPreheatCutoff.Text = bits[8];
			lblReflowCutoff.Text = bits[9];
			gbProfile.Visible = true;
		}

		//------------------------------------------------------------------------------------------------------------------------------

		private void Process_RUN(string[] bits)
		{
			if (Convert.ToDecimal(bits[2]) > Convert.ToDecimal(lblMaxTemp.Text))
			{
				lblMaxTemp.Text = bits[2];
			}

			if ((Convert.ToInt16(bits[0]) == 3) & (tempStart == 0) & (Convert.ToDecimal(bits[2]) >= 50)) // in preheat and temp just hits 50
			{
				timeStart = Convert.ToInt16(bits[1]);
				tempStart = Convert.ToDecimal(bits[2]);
			}
			if (lastSeries != Convert.ToInt16(bits[0]))
			{
				chart1.Series.FindByName(series[process].SeriesNames[Convert.ToInt16(bits[0]) - 4]).Points.AddXY(Convert.ToInt16(bits[1]) / 2, Convert.ToDecimal(bits[2]));

				lblProcess.Text = series[process].SeriesProcess + " - " + series[process].SeriesNames[Convert.ToInt16(bits[0]) - 3];
				if (Convert.ToInt16(bits[0]) == 3)
				{
					tempStart = 0;
				}
				else if (Convert.ToInt16(bits[0]) == 4)
				{
					lblPreheatRate.Text = ((Convert.ToDecimal(bits[2]) - tempStart) / ((Convert.ToInt16(bits[1]) - timeStart) / 2)).ToString("0.00");
					lblPreheatRate.Visible = true;
					lblPreheatEndTemp.Text = bits[2];
					lblPreheatEndTemp.Visible = true;
					timeStart = Convert.ToInt16(bits[1]);
					tempStart = Convert.ToDecimal(bits[2]);
				}
				else if (Convert.ToInt16(bits[0]) == 6)
				{
					lblSoakTime.Text = ((Convert.ToInt16(bits[1]) - timeStart) / 2).ToString();
					lblSoakTime.Visible = true;
					lblSoakRate.Text = ((Convert.ToDecimal(bits[2]) - tempStart) / ((Convert.ToInt16(bits[1]) - timeStart) / 2)).ToString("0.00");
					lblSoakRate.Visible = true;
				}
				else if (Convert.ToInt16(bits[0]) == 8)
				{
					lblMaxTemp.Visible = true;
				}
				lastSeries = Convert.ToInt16(bits[0]);
			}
		}

//------------------------------------------------------------------------------------------------------------------------------

		private void end_Process(string[] bits)
		{
			lblProcess.ForeColor = Color.Black;
			lblProcess.Text = series[process].SeriesProcess + " - Complete";
		}

//------------------------------------------------------------------------------------------------------------------------------

		private void abort_Process(string[] bits)
		{
			lblProcess.ForeColor = Color.Black;
			lblProcess.Text = series[process].SeriesProcess + " - Aborted";
		}

		//------------------------------------------------------------------------------------------------------------------------------

		private void oven_get(string[] bits)
		{
		}

		//------------------------------------------------------------------------------------------------------------------------------
		
		public void processDataReceived(string data)
		{
			txtDataReceived.Font = new Font("Garamond", (float)10.0, FontStyle.Regular);
			txtDataReceived.SelectionColor = Color.Blue;
			txtDataReceived.AppendText(data+"\r\n");
			txtDataReceived.ScrollToCaret();

			string[] bits = data.TrimEnd('\n').Split(',');

			if (bits[0][0] == '=')
			{
				if ((bits[0] != "=END") && (bits[0] != "=ABORT"))
				{
					process = bits[0];
				}
				series[bits[0]].InitFunc(bits);
			}
			else
			{
				lblTemp.Text = bits[2] + "°C";
				if (Convert.ToInt16(bits[0]) > 2)
				{
					series[process].ProcessFunc(bits);

					if (chart1.ChartAreas.FindByName("ChartArea1").AxisX.Maximum < Convert.ToInt16(bits[1]) / 2)
					{
						chart1.ChartAreas.FindByName("ChartArea1").AxisX.Maximum = chart1.ChartAreas.FindByName("ChartArea1").AxisX.Maximum + 60;
					}
					chart1.Series.FindByName(series[process].SeriesNames[Convert.ToInt16(bits[0]) - 3]).Points.AddXY(Convert.ToInt16(bits[1]) / 2, Convert.ToDecimal(bits[2]));
				}
			}
		}
	}
}
