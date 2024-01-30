using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace SocketClient
{
	class SendHDR
	{
		public List<Byte> odrHDR;
		public SendHDR()
		{
			odrHDR = new List<byte>();
		}
	}
	//class SendBody
	//{
	//	public List<Byte> odrBody;
	//	public SendBody()
	//	{
	//		odrBody = new List<byte>();
	//		odrBody.Add((byte)'H');
	//		odrBody.Add((byte)'B');
	//		odrBody.AddRange(Encoding.ASCII.GetBytes("HEARTBEAT "));
	//		odrBody.Add(0);
	//		odrBody.Add(0);
	//		odrBody.AddRange(Encoding.ASCII.GetBytes(DateTime.Now.ToString("HHmmss")));
	//		odrBody.Add(0);
	//		odrBody.Add(0);
	//		odrBody.Add(0);
	//		odrBody.Add(0);
	//		odrBody.Add(0);
	//		odrBody.Add(3);
	//		odrBody.Add(0);
	//		odrBody.Add(6);
	//		odrBody.AddRange(Encoding.ASCII.GetBytes("            "));
	//		odrBody.AddRange(Encoding.ASCII.GetBytes("F905000"));
	//		odrBody.AddRange(Encoding.ASCII.GetBytes("P00"));
	//		odrBody.AddRange(Encoding.ASCII.GetBytes("          "));
	//		odrBody.AddRange(Encoding.ASCII.GetBytes("1001        "));
	//		int today = 20230106;
	//		byte[] intByte = BitConverter.GetBytes(today);
	//		if (BitConverter.IsLittleEndian)
	//			Array.Reverse(intByte);
	//		foreach (byte b in intByte)
	//		{
	//			if (b != 0)
	//				odrBody.Add(b);
	//		}
	//		odrBody.AddRange(Encoding.ASCII.GetBytes(" "));
	//		odrBody.AddRange(Encoding.ASCII.GetBytes("F905000"));
	//		odrBody.AddRange(Encoding.ASCII.GetBytes("P00"));
	//		odrBody.AddRange(Encoding.ASCII.GetBytes(" "));


	//		odrBody.AddRange(Encoding.ASCII.GetBytes("F905000"));
	//		odrBody.AddRange(Encoding.ASCII.GetBytes("P00"));
	//		odrBody.AddRange(Encoding.ASCII.GetBytes("TT000"));
	//		odrBody.AddRange(Encoding.ASCII.GetBytes("F000000"));
	//		odrBody.AddRange(Encoding.ASCII.GetBytes("S538000"));
	//		//odrBody.AddRange(Encoding.ASCII.GetBytes("0005438"));
	//		odrBody.Add(0);
	//		odrBody.Add(0);
	//		odrBody.Add(0);
	//		odrBody.Add(5);
	//		odrBody.Add(4);
	//		odrBody.Add(3);
	//		odrBody.Add(8);
	//		//odrBody.AddRange(Encoding.ASCII.GetBytes("0000000"));
	//		odrBody.Add(0);
	//		odrBody.Add(0);
	//		odrBody.Add(0);
	//		odrBody.Add(0);
	//		odrBody.Add(0);
	//		odrBody.Add(0);
	//		odrBody.Add(0);

	//		odrBody.Add(0);
	//		odrBody.AddRange(Encoding.ASCII.GetBytes(" "));
	//		odrBody.AddRange(Encoding.ASCII.GetBytes("L"));
	//	}
	//}

	class Receive
	{
		private static byte[] result = new byte[4096];
		private static Socket clientSocket;
		private static SendHDR sendHDR = new SendHDR();
		//private static SendBody sendBody = new SendBody();

		public static void initSocket(string ip, int port)
		{
			if(clientSocket != null)
			{
				clientSocket.Close();
				writeMsg(String.Format("已連線,斷線重連!", ip));
				Thread.Sleep(2000);
			}
			IPAddress tndmIP = IPAddress.Parse(ip);
			clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			try
			{
				clientSocket.Connect(new IPEndPoint(tndmIP, port));				
				writeMsg(String.Format("連線{0}成功! Local IP = {1}", ip, clientSocket.LocalEndPoint));
			}
			catch (Exception ex)
			{
				writeMsg(ex.Message);
				writeMsg(String.Format("連線{0}:{1}失敗! 請重新連線", ip, port));
				//return;
				initSocket(Form1.form1.ipTxBox.Text, int.Parse(Form1.form1.portTxBox.Text));
			}
			//Thread recvThread = new Thread(recvMsg);
			//recvThread.IsBackground = true;
			//recvThread.Start();
		}

		public static void sendMsg()
		{
			if (clientSocket == null)
			{
				writeMsg("尚未連線!");
			}
			else
			{
				string input = Form1.form1.sendTxBox.Text;			
				clientSocket.Send(Encoding.ASCII.GetBytes(input));
				writeMsg("Send:" + input);
			}
		}

		public static void sendOdr()
		{
			if (clientSocket == null)
			{
				writeMsg("尚未連線!");
			}
			else
			{
				//Body
				List<byte> odrBody = new List<byte>();
				odrBody = new List<byte>();
				odrBody.Add((byte)'F');
				odrBody.Add((byte)'1');
				odrBody.AddRange(Encoding.ASCII.GetBytes("FUS310001 "));
				odrBody.Add(0);
				odrBody.Add(0);
				odrBody.AddRange(Encoding.ASCII.GetBytes(DateTime.Now.ToString("HHmmss")));
				odrBody.Add(0);
				odrBody.Add(0);
				odrBody.Add(0);
				odrBody.Add(0);
				odrBody.Add(0);
				odrBody.Add(3);
				odrBody.Add(0);
				odrBody.Add(6);
				odrBody.AddRange(Encoding.ASCII.GetBytes("            "));
				odrBody.AddRange(Encoding.ASCII.GetBytes("F905000"));
				odrBody.AddRange(Encoding.ASCII.GetBytes("P00"));
				odrBody.AddRange(Encoding.ASCII.GetBytes("          "));
				odrBody.AddRange(Encoding.ASCII.GetBytes("1001        "));
				int today = 20230106;
				byte[] intBodyByte = BitConverter.GetBytes(today);
				if (BitConverter.IsLittleEndian)
					Array.Reverse(intBodyByte);
				foreach (byte b in intBodyByte)
				{
					if (b != 0)
						odrBody.Add(b);
				}
				odrBody.AddRange(Encoding.ASCII.GetBytes(" "));
				odrBody.AddRange(Encoding.ASCII.GetBytes("F905000"));
				odrBody.AddRange(Encoding.ASCII.GetBytes("P00"));
				odrBody.AddRange(Encoding.ASCII.GetBytes(" "));


				odrBody.AddRange(Encoding.ASCII.GetBytes("F905000"));
				odrBody.AddRange(Encoding.ASCII.GetBytes("P00"));
				odrBody.AddRange(Encoding.ASCII.GetBytes("TT000"));
				odrBody.AddRange(Encoding.ASCII.GetBytes("F000000"));
				odrBody.AddRange(Encoding.ASCII.GetBytes("S538000"));
				//odrBody.AddRange(Encoding.ASCII.GetBytes("0005438"));
				odrBody.Add(0);
				odrBody.Add(0);
				odrBody.Add(0);
				odrBody.Add(5);
				odrBody.Add(4);
				odrBody.Add(3);
				odrBody.Add(8);
				//odrBody.AddRange(Encoding.ASCII.GetBytes("0000000"));
				odrBody.Add(0);
				odrBody.Add(0);
				odrBody.Add(0);
				odrBody.Add(0);
				odrBody.Add(0);
				odrBody.Add(0);
				odrBody.Add(0);

				odrBody.Add(0);
				odrBody.AddRange(Encoding.ASCII.GetBytes(" "));
				odrBody.AddRange(Encoding.ASCII.GetBytes("L"));
				//Body
				sendHDR.odrHDR.Clear();
				int bodyLen = odrBody.Count();
				byte[] intByte = BitConverter.GetBytes(bodyLen);
				if (BitConverter.IsLittleEndian)
					Array.Reverse(intByte);
				sendHDR.odrHDR.Add(intByte[2]);
				sendHDR.odrHDR.Add(intByte[3]);

				clientSocket.Send(sendHDR.odrHDR.Concat(odrBody).ToArray());
				writeMsg("Send: ODR OK!");
			}
		}

		public static void sendAckHdr()
		{
			if (clientSocket == null)
			{
				writeMsg("尚未連線!");
			}
			else
			{
				//Body
				List<byte> odrBody = new List<byte>();
				odrBody = new List<byte>();
				odrBody.Add((byte)'H');
				odrBody.Add((byte)'B');
				odrBody.AddRange(Encoding.ASCII.GetBytes("HEARTBEAT "));
				odrBody.Add(0);
				odrBody.Add(0);
				odrBody.AddRange(Encoding.ASCII.GetBytes(DateTime.Now.ToString("HHmmss")));
				odrBody.Add(0);
				odrBody.Add(0);
				odrBody.Add(0);
				odrBody.Add(0);
				odrBody.Add(0);
				odrBody.Add(3);
				odrBody.Add(0);
				odrBody.Add(6);
				odrBody.AddRange(Encoding.ASCII.GetBytes("            "));
				odrBody.AddRange(Encoding.ASCII.GetBytes("F905000"));
				odrBody.AddRange(Encoding.ASCII.GetBytes("P00"));
				odrBody.AddRange(Encoding.ASCII.GetBytes("          "));
				odrBody.AddRange(Encoding.ASCII.GetBytes("1001        "));
				int today = 20230106;
				byte[] intBodyByte = BitConverter.GetBytes(today);
				if (BitConverter.IsLittleEndian)
					Array.Reverse(intBodyByte);
				foreach (byte b in intBodyByte)
				{
					if (b != 0)
						odrBody.Add(b);
				}
				odrBody.AddRange(Encoding.ASCII.GetBytes(" "));
				odrBody.AddRange(Encoding.ASCII.GetBytes("F905000"));
				odrBody.AddRange(Encoding.ASCII.GetBytes("P00"));
				odrBody.AddRange(Encoding.ASCII.GetBytes(" "));


				odrBody.AddRange(Encoding.ASCII.GetBytes("F905000"));
				odrBody.AddRange(Encoding.ASCII.GetBytes("P00"));
				odrBody.AddRange(Encoding.ASCII.GetBytes("TT000"));
				odrBody.AddRange(Encoding.ASCII.GetBytes("F000000"));
				odrBody.AddRange(Encoding.ASCII.GetBytes("S538000"));
				//odrBody.AddRange(Encoding.ASCII.GetBytes("0005438"));
				odrBody.Add(0);
				odrBody.Add(0);
				odrBody.Add(0);
				odrBody.Add(5);
				odrBody.Add(4);
				odrBody.Add(3);
				odrBody.Add(8);
				//odrBody.AddRange(Encoding.ASCII.GetBytes("0000000"));
				odrBody.Add(0);
				odrBody.Add(0);
				odrBody.Add(0);
				odrBody.Add(0);
				odrBody.Add(0);
				odrBody.Add(0);
				odrBody.Add(0);

				odrBody.Add(0);
				odrBody.AddRange(Encoding.ASCII.GetBytes(" "));
				odrBody.AddRange(Encoding.ASCII.GetBytes("L"));
				//Body
				sendHDR.odrHDR.Clear();
				int bodyLen = odrBody.Count();
				byte[] intByte = BitConverter.GetBytes(bodyLen);
				if (BitConverter.IsLittleEndian)
					Array.Reverse(intByte);
				sendHDR.odrHDR.Add(intByte[2]);
				sendHDR.odrHDR.Add(intByte[3]);

				clientSocket.Send(sendHDR.odrHDR.Concat(odrBody).ToArray());
				writeMsg("Send: ODR OK!");
			}
		}

		public static void sendAck()
		{
			if (clientSocket == null)
			{
				writeMsg("尚未連線!");
			}
			else
			{
				string outBuf = "ACK" + DateTime.Now.ToString("HHmmssf");
				 byte[] sendByte = Encoding.ASCII.GetBytes(outBuf);
				clientSocket.Send(sendByte);
				writeMsg("Send: ACK");
			}
		}

		public static void sendRecv()
		{
			if (clientSocket == null)
			{
				writeMsg("尚未連線!");
			}
			else
			{
				string outBuf = "RECV" + DateTime.Now.ToString("HHmmss");
				byte[] sendByte = Encoding.ASCII.GetBytes(outBuf);
				clientSocket.Send(sendByte);
				writeMsg("Send: RECV");
			}
		}

		public static void writeMsg(string msg)
		{
            //Form1.form1.msgTxBox.AppendText(DateTime.Now.ToString("HH:mm:ss.ffffff") + " " + msg + "\n");
            try
            {
				Form1.form1.Invoke(new Action(() =>
				{
					Form1.form1.msgTxBox.AppendText(DateTime.Now.ToString("HH:mm:ss.ffffff") + " " + msg + "\n");
				}));
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
            }
		}

		public static void recvMsg()
		{
			while (true)
			{
				try
				{
					int count = clientSocket.Receive(result);

					if (count > 0)
					{
						//String tests = Encoding.ASCII.GetString(result, 0, count);
						String[] s = Encoding.ASCII.GetString(result, 0, count).Split('\u0001');
						foreach(String msg in s)
						{
							if(msg.Length > 0)
								writeMsg(msg);
						}
						//writeMsg(Encoding.ASCII.GetString(result, 0, count) + "\n");
					}
				}
				catch (Exception ex)
				{
					writeMsg(ex.Message);
					writeMsg("接收失敗，請確認!");
					clientSocket.Close();
					initSocket(Form1.form1.ipTxBox.Text, int.Parse(Form1.form1.portTxBox.Text));
				}
			}
		}
	}
}
