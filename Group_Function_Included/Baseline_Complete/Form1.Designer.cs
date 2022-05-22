namespace ChatBox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLocalPort = new System.Windows.Forms.TextBox();
            this.txtLocalIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemotePort = new System.Windows.Forms.TextBox();
            this.txtRemoteIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lboxChat = new System.Windows.Forms.ListBox();
            this.txtMess = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GroupConnect = new System.Windows.Forms.Button();
            this.ContactsList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLocalPort);
            this.groupBox1.Controls.Add(this.txtLocalIP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Info:";
            // 
            // txtLocalPort
            // 
            this.txtLocalPort.Location = new System.Drawing.Point(44, 76);
            this.txtLocalPort.Name = "txtLocalPort";
            this.txtLocalPort.Size = new System.Drawing.Size(162, 20);
            this.txtLocalPort.TabIndex = 6;
            // 
            // txtLocalIP
            // 
            this.txtLocalIP.Location = new System.Drawing.Point(44, 38);
            this.txtLocalIP.Name = "txtLocalIP";
            this.txtLocalIP.Size = new System.Drawing.Size(162, 20);
            this.txtLocalIP.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtRemotePort);
            this.groupBox2.Controls.Add(this.txtRemoteIP);
            this.groupBox2.Location = new System.Drawing.Point(316, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 107);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reviever\'s Info:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Port: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "IP: ";
            // 
            // txtRemotePort
            // 
            this.txtRemotePort.Location = new System.Drawing.Point(44, 76);
            this.txtRemotePort.Name = "txtRemotePort";
            this.txtRemotePort.Size = new System.Drawing.Size(162, 20);
            this.txtRemotePort.TabIndex = 8;
            // 
            // txtRemoteIP
            // 
            this.txtRemoteIP.Location = new System.Drawing.Point(44, 38);
            this.txtRemoteIP.Name = "txtRemoteIP";
            this.txtRemoteIP.Size = new System.Drawing.Size(162, 20);
            this.txtRemoteIP.TabIndex = 7;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(570, 53);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lboxChat
            // 
            this.lboxChat.FormattingEnabled = true;
            this.lboxChat.Location = new System.Drawing.Point(12, 125);
            this.lboxChat.Name = "lboxChat";
            this.lboxChat.Size = new System.Drawing.Size(784, 290);
            this.lboxChat.TabIndex = 11;
            // 
            // txtMess
            // 
            this.txtMess.Location = new System.Drawing.Point(12, 436);
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(703, 20);
            this.txtMess.TabIndex = 9;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(721, 436);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GroupConnect
            // 
            this.GroupConnect.Location = new System.Drawing.Point(570, 12);
            this.GroupConnect.Name = "GroupConnect";
            this.GroupConnect.Size = new System.Drawing.Size(108, 23);
            this.GroupConnect.TabIndex = 13;
            this.GroupConnect.Text = "Connect to group";
            this.GroupConnect.UseVisualStyleBackColor = true;
            this.GroupConnect.Click += new System.EventHandler(this.button2_Click);
            // 
            // ContactsList
            // 
            this.ContactsList.FormattingEnabled = true;
            this.ContactsList.Items.AddRange(new object[] {
            "Dirk:10.0.0.4:49677",
            "Emile:192.168.1.10:45615",
            "Andrew:192.168.1.20:56986"});
            this.ContactsList.Location = new System.Drawing.Point(684, 24);
            this.ContactsList.Name = "ContactsList";
            this.ContactsList.Size = new System.Drawing.Size(120, 95);
            this.ContactsList.TabIndex = 14;
            this.ContactsList.SelectedIndexChanged += new System.EventHandler(this.ContactsList_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(685, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Contacts";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 491);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ContactsList);
            this.Controls.Add(this.GroupConnect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMess);
            this.Controls.Add(this.lboxChat);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ChatBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLocalPort;
        private System.Windows.Forms.TextBox txtLocalIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRemotePort;
        private System.Windows.Forms.TextBox txtRemoteIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListBox lboxChat;
        private System.Windows.Forms.TextBox txtMess;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GroupConnect;
        private System.Windows.Forms.ListBox ContactsList;
        private System.Windows.Forms.Label label5;
    }
}

