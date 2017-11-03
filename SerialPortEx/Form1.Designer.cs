namespace SerialPortEx
{
    partial class SerialComm_Load
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.cbHandShake = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbDataSize = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRecvMessage = new System.Windows.Forms.RichTextBox();
            this.tbSendMessage = new System.Windows.Forms.TextBox();
            this.btSendMessage = new System.Windows.Forms.Button();
            this.btConnectControl = new System.Windows.Forms.Button();
            this.gbSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.cbHandShake);
            this.gbSettings.Controls.Add(this.cbParity);
            this.gbSettings.Controls.Add(this.cbDataSize);
            this.gbSettings.Controls.Add(this.cbBaudRate);
            this.gbSettings.Controls.Add(this.cbComPort);
            this.gbSettings.Controls.Add(this.label5);
            this.gbSettings.Controls.Add(this.label4);
            this.gbSettings.Controls.Add(this.label3);
            this.gbSettings.Controls.Add(this.label2);
            this.gbSettings.Controls.Add(this.label1);
            this.gbSettings.Location = new System.Drawing.Point(13, 13);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(320, 202);
            this.gbSettings.TabIndex = 0;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // cbHandShake
            // 
            this.cbHandShake.FormattingEnabled = true;
            this.cbHandShake.Items.AddRange(new object[] {
            "none",
            "Xon/Xoff",
            "request to send",
            "request to send Xon/Xoff"});
            this.cbHandShake.Location = new System.Drawing.Point(129, 170);
            this.cbHandShake.Name = "cbHandShake";
            this.cbHandShake.Size = new System.Drawing.Size(177, 20);
            this.cbHandShake.TabIndex = 9;
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "none",
            "even",
            "mark",
            "odd",
            "space"});
            this.cbParity.Location = new System.Drawing.Point(129, 135);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(177, 20);
            this.cbParity.TabIndex = 8;
            // 
            // cbDataSize
            // 
            this.cbDataSize.FormattingEnabled = true;
            this.cbDataSize.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
            this.cbDataSize.Location = new System.Drawing.Point(129, 100);
            this.cbDataSize.Name = "cbDataSize";
            this.cbDataSize.Size = new System.Drawing.Size(177, 20);
            this.cbDataSize.TabIndex = 7;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "115200",
            "19200",
            "38400",
            "57600",
            "9600"});
            this.cbBaudRate.Location = new System.Drawing.Point(129, 68);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(177, 20);
            this.cbBaudRate.TabIndex = 6;
            // 
            // cbComPort
            // 
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(129, 34);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(177, 20);
            this.cbComPort.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "handshake";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "parity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "baudrate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(362, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Messages";
            // 
            // tbRecvMessage
            // 
            this.tbRecvMessage.Location = new System.Drawing.Point(365, 50);
            this.tbRecvMessage.Name = "tbRecvMessage";
            this.tbRecvMessage.Size = new System.Drawing.Size(291, 199);
            this.tbRecvMessage.TabIndex = 2;
            this.tbRecvMessage.Text = "";
            // 
            // tbSendMessage
            // 
            this.tbSendMessage.Location = new System.Drawing.Point(365, 266);
            this.tbSendMessage.Name = "tbSendMessage";
            this.tbSendMessage.Size = new System.Drawing.Size(208, 21);
            this.tbSendMessage.TabIndex = 3;
            // 
            // btSendMessage
            // 
            this.btSendMessage.Location = new System.Drawing.Point(581, 264);
            this.btSendMessage.Name = "btSendMessage";
            this.btSendMessage.Size = new System.Drawing.Size(75, 23);
            this.btSendMessage.TabIndex = 4;
            this.btSendMessage.Text = "Send";
            this.btSendMessage.UseVisualStyleBackColor = true;
            this.btSendMessage.Click += new System.EventHandler(this.btSendMessage_Click);
            // 
            // btConnectControl
            // 
            this.btConnectControl.Location = new System.Drawing.Point(13, 225);
            this.btConnectControl.Name = "btConnectControl";
            this.btConnectControl.Size = new System.Drawing.Size(320, 62);
            this.btConnectControl.TabIndex = 5;
            this.btConnectControl.Text = "연결";
            this.btConnectControl.UseVisualStyleBackColor = true;
            this.btConnectControl.Click += new System.EventHandler(this.btConnectControl_Click);
            // 
            // SerialComm_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 311);
            this.Controls.Add(this.btConnectControl);
            this.Controls.Add(this.btSendMessage);
            this.Controls.Add(this.tbSendMessage);
            this.Controls.Add(this.tbRecvMessage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbSettings);
            this.Name = "SerialComm_Load";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SerialComm_Load_Load);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHandShake;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbDataSize;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox tbRecvMessage;
        private System.Windows.Forms.TextBox tbSendMessage;
        private System.Windows.Forms.Button btSendMessage;
        private System.Windows.Forms.Button btConnectControl;
    }
}

