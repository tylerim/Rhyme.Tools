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
	}
}
