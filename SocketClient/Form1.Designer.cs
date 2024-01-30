
namespace SocketClient
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
            this.ConnectBut = new System.Windows.Forms.Button();
            this.ipTxBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.portTxBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.msgTxBox = new System.Windows.Forms.RichTextBox();
            this.sendBut = new System.Windows.Forms.Button();
            this.sendTxBox = new System.Windows.Forms.TextBox();
            this.cleanBut = new System.Windows.Forms.Button();
            this.sendAckBut = new System.Windows.Forms.Button();
            this.sendAckHdr = new System.Windows.Forms.Button();
            this.sendOdrBut = new System.Windows.Forms.Button();
            this.sendRecvBut = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectBut
            // 
            this.ConnectBut.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ConnectBut.Location = new System.Drawing.Point(31, 39);
            this.ConnectBut.Name = "ConnectBut";
            this.ConnectBut.Size = new System.Drawing.Size(122, 33);
            this.ConnectBut.TabIndex = 0;
            this.ConnectBut.Text = "Start Connect";
            this.ConnectBut.UseVisualStyleBackColor = true;
            this.ConnectBut.Click += new System.EventHandler(this.ConnectBut_Click);
            // 
            // ipTxBox
            // 
            this.ipTxBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ipTxBox.Location = new System.Drawing.Point(34, 3);
            this.ipTxBox.Name = "ipTxBox";
            this.ipTxBox.Size = new System.Drawing.Size(139, 27);
            this.ipTxBox.TabIndex = 1;
            this.ipTxBox.Text = "172.16.82.2";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.ipTxBox);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.portTxBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(173, 39);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(348, 33);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(179, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port:";
            // 
            // portTxBox
            // 
            this.portTxBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.portTxBox.Location = new System.Drawing.Point(226, 3);
            this.portTxBox.Name = "portTxBox";
            this.portTxBox.Size = new System.Drawing.Size(100, 27);
            this.portTxBox.TabIndex = 3;
            this.portTxBox.Text = "17635";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(27, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Receive:";
            // 
            // msgTxBox
            // 
            this.msgTxBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.msgTxBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.msgTxBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.msgTxBox.Location = new System.Drawing.Point(31, 247);
            this.msgTxBox.Name = "msgTxBox";
            this.msgTxBox.ReadOnly = true;
            this.msgTxBox.Size = new System.Drawing.Size(727, 256);
            this.msgTxBox.TabIndex = 4;
            this.msgTxBox.Text = "";
            this.msgTxBox.WordWrap = false;
            this.msgTxBox.TextChanged += new System.EventHandler(this.msgTxBox_TextChanged);
            // 
            // sendBut
            // 
            this.sendBut.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sendBut.Location = new System.Drawing.Point(31, 96);
            this.sendBut.Name = "sendBut";
            this.sendBut.Size = new System.Drawing.Size(122, 33);
            this.sendBut.TabIndex = 5;
            this.sendBut.Text = "Send:";
            this.sendBut.UseVisualStyleBackColor = true;
            this.sendBut.Click += new System.EventHandler(this.sendbut_Click);
            // 
            // sendTxBox
            // 
            this.sendTxBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sendTxBox.Location = new System.Drawing.Point(173, 100);
            this.sendTxBox.Name = "sendTxBox";
            this.sendTxBox.Size = new System.Drawing.Size(585, 27);
            this.sendTxBox.TabIndex = 6;
            // 
            // cleanBut
            // 
            this.cleanBut.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cleanBut.Location = new System.Drawing.Point(651, 200);
            this.cleanBut.Name = "cleanBut";
            this.cleanBut.Size = new System.Drawing.Size(107, 32);
            this.cleanBut.TabIndex = 7;
            this.cleanBut.Text = "Clean msg";
            this.cleanBut.UseVisualStyleBackColor = true;
            this.cleanBut.Click += new System.EventHandler(this.cleanBut_Click);
            // 
            // sendAckBut
            // 
            this.sendAckBut.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sendAckBut.Location = new System.Drawing.Point(545, 12);
            this.sendAckBut.Name = "sendAckBut";
            this.sendAckBut.Size = new System.Drawing.Size(98, 33);
            this.sendAckBut.TabIndex = 8;
            this.sendAckBut.Text = "Send Ack";
            this.sendAckBut.UseVisualStyleBackColor = true;
            this.sendAckBut.Click += new System.EventHandler(this.sendAckBut_Click);
            // 
            // sendAckHdr
            // 
            this.sendAckHdr.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sendAckHdr.Location = new System.Drawing.Point(173, 151);
            this.sendAckHdr.Name = "sendAckHdr";
            this.sendAckHdr.Size = new System.Drawing.Size(107, 33);
            this.sendAckHdr.TabIndex = 11;
            this.sendAckHdr.Text = "OdrAck";
            this.sendAckHdr.UseVisualStyleBackColor = true;
            this.sendAckHdr.Click += new System.EventHandler(this.sendAckHdr_Click);
            // 
            // sendOdrBut
            // 
            this.sendOdrBut.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sendOdrBut.Location = new System.Drawing.Point(31, 151);
            this.sendOdrBut.Name = "sendOdrBut";
            this.sendOdrBut.Size = new System.Drawing.Size(122, 33);
            this.sendOdrBut.TabIndex = 12;
            this.sendOdrBut.Text = "SendODR";
            this.sendOdrBut.UseVisualStyleBackColor = true;
            this.sendOdrBut.Click += new System.EventHandler(this.sendOdrBut_Click);
            // 
            // sendRecvBut
            // 
            this.sendRecvBut.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sendRecvBut.Location = new System.Drawing.Point(545, 52);
            this.sendRecvBut.Name = "sendRecvBut";
            this.sendRecvBut.Size = new System.Drawing.Size(119, 32);
            this.sendRecvBut.TabIndex = 13;
            this.sendRecvBut.Text = "Send Recv";
            this.sendRecvBut.UseVisualStyleBackColor = true;
            this.sendRecvBut.Click += new System.EventHandler(this.sendRecvBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.sendRecvBut);
            this.Controls.Add(this.sendOdrBut);
            this.Controls.Add(this.sendAckHdr);
            this.Controls.Add(this.sendAckBut);
            this.Controls.Add(this.cleanBut);
            this.Controls.Add(this.sendTxBox);
            this.Controls.Add(this.sendBut);
            this.Controls.Add(this.msgTxBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ConnectBut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ConnectBut;
		public System.Windows.Forms.TextBox ipTxBox;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox portTxBox;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.RichTextBox msgTxBox;
		private System.Windows.Forms.Button sendBut;
		public System.Windows.Forms.TextBox sendTxBox;
		private System.Windows.Forms.Button cleanBut;
		private System.Windows.Forms.Button sendAckBut;
		public System.Windows.Forms.Button sendAckHdr;
		private System.Windows.Forms.Button sendOdrBut;
		private System.Windows.Forms.Button sendRecvBut;
	}
}

