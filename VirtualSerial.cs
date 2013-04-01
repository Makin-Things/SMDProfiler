using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace SMDProfiler
{
	class VirtualSerialPort
	{
		private SerialPort _serialPort;
		private SMDReflowProfiler mainForm;

//------------------------------------------------------------------------------------------------------------------------------

		public VirtualSerialPort(SMDReflowProfiler myform, string port)
		{
			try
			{
				mainForm = myform;
				_serialPort = new SerialPort(port, 9600, Parity.None, 8, StopBits.One);
				_serialPort.Handshake = Handshake.None;
				return;
			}
			catch (Exception)
			{
				return;
			}
		}

//------------------------------------------------------------------------------------------------------------------------------

		public string PortName
		{
			get { return _serialPort.PortName; }
		}

//------------------------------------------------------------------------------------------------------------------------------

		public VirtualSerialPort Open()
		{
			try
			{
				_serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
				_serialPort.Open();

				mainForm.OutputText(_serialPort.PortName + " connected.");
				/*				lblMessage.Text = port + " connected."; */
				mainForm.ButtonConnectState = false;
				mainForm.ButtonDisonnectState = true;
				return this;
			}
			catch (Exception)
			{
				return null;
			}
		}

//------------------------------------------------------------------------------------------------------------------------------

		private delegate void myDelegate(string text);

//------------------------------------------------------------------------------------------------------------------------------

		void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
		{
			try
			{
				string data = _serialPort.ReadLine();

				mainForm.BeginInvoke(new myDelegate(dataReceived), new object[] { data });
			}
			catch (Exception ex)
			{
//				SMDReflowProfiler.DisplayException(this.PortName, ex);
				return;
			}
		}

//------------------------------------------------------------------------------------------------------------------------------

		private void dataReceived(string data)
		{
			mainForm.processDataReceived(data);
		}

//------------------------------------------------------------------------------------------------------------------------------

		public void WriteLine(string data)
		{
			try
			{
				_serialPort.WriteLine(data);
			}
			catch (Exception)
			{
				return;
			}
		}

//------------------------------------------------------------------------------------------------------------------------------

		public void findVirtualPorts()
		{
/*			vPorts = 0;

			ManagementObjectCollection USBCollection = mc.GetInstances();

			cbbCOMPorts.Items.Clear();

			foreach (ManagementObject USB in mc.GetInstances())
			{
				if (USB["PnPDeviceID"].ToString().StartsWith(@"USB\VID_03EB&PID_2044\"))
				{
					cbbCOMPorts.Items.Add(USB["DeviceID"].ToString());
					vPorts++;
				}
			}

			btnDisconnect.Enabled = false;
			if (vPorts > 0)
			{
				Debug.WriteLine("Reflow ovens found = " + vPorts);
				txtDataReceived.AppendText("Reflow ovens found = " + vPorts + "\n");
				txtDataReceived.ScrollToCaret();
				cbbCOMPorts.SelectedIndex = 0;
				if (vPorts == 1)
				{
					Open(cbbCOMPorts.Text);
				}
			}
			else
			{
				Debug.WriteLine("No reflow ovens found.");
				btnConnect.Enabled = false;
			}*/
		}

//------------------------------------------------------------------------------------------------------------------------------

		public void Close()
		{
			try
			{
				if (_serialPort.IsOpen)
				{
					mainForm.OutputText(_serialPort.PortName + " disconnected.");
					/*				lblMessage.Text = _serialPort.PortName + " disconnected."; */
					mainForm.ButtonConnectState = true;
					mainForm.ButtonDisonnectState = false;
					_serialPort.Close();
				}
			}
			catch (Exception)
			{
				_serialPort = new SerialPort(_serialPort.PortName, 9600, Parity.None, 8, StopBits.One);
				_serialPort.Handshake = Handshake.None;
				return;
			}
		}
	}

//------------------------------------------------------------------------------------------------------------------------------
	
	class VirtualSerialPorts
	{
		private SMDReflowProfiler mainForm;
		private List<VirtualSerialPort> listPorts = new List<VirtualSerialPort>();

//------------------------------------------------------------------------------------------------------------------------------

		public VirtualSerialPorts(SMDReflowProfiler myForm) 
		{
			mainForm = myForm;

			ManagementClass mc = new ManagementClass("Win32_SerialPort");

			ManagementObjectCollection USBCollection = mc.GetInstances();

			foreach (ManagementObject USB in mc.GetInstances())
			{
				if (USB["PnPDeviceID"].ToString().StartsWith(@"USB\VID_03EB&PID_2044\"))
				{
					listPorts.Add(new VirtualSerialPort(mainForm, USB["DeviceID"].ToString()));
				}
			}

			mainForm.ComPortsClear();
			mainForm.ButtonDisonnectState = false;

			if (listPorts.Count > 0)
			{
				Debug.WriteLine("Reflow ovens found = " + listPorts.Count);
				mainForm.OutputText("Reflow ovens found = " + listPorts.Count);
				foreach (VirtualSerialPort v in listPorts)
				{
					mainForm.ComPortsAdd(v.PortName);
				}
			}
			else
			{
				Debug.WriteLine("No reflow ovens found.");
				mainForm.OutputText("No reflow ovens found.");
				mainForm.btnConnect.Enabled = false;
			}
		}

//------------------------------------------------------------------------------------------------------------------------------

		public int Count
		{
			get { return listPorts.Count; }
		}

//------------------------------------------------------------------------------------------------------------------------------
		
		public VirtualSerialPort Open(string port)
		{
			try
			{
				foreach (VirtualSerialPort v in listPorts)
				{
					if (v.PortName == port)
					{
						return v.Open();
					}
				}
				return null;
			}
			catch (Exception)
			{
				return null;
			}
		}
	}
}
