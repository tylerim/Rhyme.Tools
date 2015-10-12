using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RhymeLoginTool.Z_Socket
{
	public partial class frmSocket : Form
	{
		public frmSocket()
		{
			InitializeComponent();
		}

		private Socket _socket;
		private List<Socket> _socketList = new List<Socket>();
		private bool _isMultiStart = false;

		private void btnConnect_Click(object sender, EventArgs e)
		{
			_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			_socket.Connect(new IPEndPoint(IPAddress.Parse(txtAddress.Text), int.Parse(txtPort.Text)));
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			if (_socket == null)
				return;

			var sendBytes = Encoding.Unicode.GetBytes(txtSend.Text);
			_socket.Send(sendBytes, sendBytes.Length, SocketFlags.None);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			if (_socket == null)
				return;

			_socket.Close();
		}

		private void btnStartMulti_Click(object sender, EventArgs e)
		{
			btnStopMulti_Click(this, EventArgs.Empty);

			_isMultiStart = true;
			var ipEndPoint = new IPEndPoint(IPAddress.Parse(txtMultiIp.Text), int.Parse(txtMultiPort.Text));
			var threadCount = int.Parse(txtMultiThreadCount.Text);

			for (var i = 0; i < threadCount; i++)
			{
				Task.Factory.StartNew(() =>
				{
					while (_isMultiStart)
					{
						var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
						try
						{
							_socketList.Add(socket);

							socket.Connect(ipEndPoint);
							socket.Close();
						}
						catch (Exception)
						{
						}
						finally
						{
							_socketList.Remove(socket);
						}
					}
				});
			}
		}

		private void btnStopMulti_Click(object sender, EventArgs e)
		{
			_isMultiStart = false;

			foreach (var socket in _socketList.ToList())
			{
				try
				{
					if (socket != null)
						socket.Close();
				}
				catch (Exception)
				{
				}
			}

			_socketList.Clear();
		}
	}
}
