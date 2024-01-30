using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketClient
{
	public partial class Form1 : Form
	{
		public static Form1 form1;
		private float x;
		private float y;
		Thread recvThread = new Thread(Receive.recvMsg);

		public Form1()
		{
			InitializeComponent();
			form1 = this;
			x = this.Width;
			y = this.Height;
			setTag(this);
		}

		private void setTag(Control cons)
		{
			foreach(Control con in cons.Controls)
			{
				con.Tag = con.Width + ";" + con.Height + ";" + con.Left + ";" + con.Top + ";" + con.Font.Size;
				if (con.Controls.Count > 0)
				{
					setTag(con);
				}
			}
		}

		private void setControls(float newX, float newY, Control cons)
		{
			foreach(Control con in cons.Controls)
			{
				if (con.Tag != null)
				{
					string[] mytag = con.Tag.ToString().Split(new char[] { ';' });

					con.Width = Convert.ToInt32(System.Convert.ToSingle(mytag[0]) * newX);
					con.Height = Convert.ToInt32(System.Convert.ToSingle(mytag[1]) * newY);
					con.Left = Convert.ToInt32(System.Convert.ToSingle(mytag[2]) * newX);
					con.Top = Convert.ToInt32(System.Convert.ToSingle(mytag[3]) * newY);
					Single currentSize = System.Convert.ToSingle(mytag[4]) * newY;
					con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
					if (con.Controls.Count > 0)
					{
						setControls(newX, newY, con);
					}
				}
			}
		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			float newX = (this.Width) / x;
			float newY = (this.Height) / y;
			setControls(newX, newY, this);
		}

		private void msgTxBox_TextChanged(object sender, EventArgs e)
		{
			msgTxBox.SelectionStart = msgTxBox.Text.Length;
			msgTxBox.ScrollToCaret();
		}

		private void ConnectBut_Click(object sender, EventArgs e)
		{
			Receive.initSocket(ipTxBox.Text, int.Parse(portTxBox.Text));
			
			if (!recvThread.IsAlive)
            {
				recvThread.IsBackground = true;
				recvThread.Start();
			}
		}
		private void Form1_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			System.Environment.Exit(0);
		}

		private void sendbut_Click(object sender, EventArgs e)
		{
			Receive.sendMsg();
		}

		private void cleanBut_Click(object sender, EventArgs e)
		{
			msgTxBox.Text = "";
		}

		private void sendAckBut_Click(object sender, EventArgs e)
		{
			Receive.sendAck();
		}

		private void sendAckHdr_Click(object sender, EventArgs e)
		{
			Receive.sendAckHdr();
		}

		private void sendOdrBut_Click(object sender, EventArgs e)
		{
			Receive.sendOdr();
		}

		private void sendRecvBut_Click(object sender, EventArgs e)
		{
			Receive.sendRecv();
		}
	}
}
