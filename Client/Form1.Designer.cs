namespace Client
{
    partial class ChatApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatApplication));
            this.textBox_Nickname = new System.Windows.Forms.TextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.listBox_chat = new System.Windows.Forms.ListBox();
            this.textBox_sendMessage = new System.Windows.Forms.TextBox();
            this.button_sendMessage = new System.Windows.Forms.Button();
            this.listBox_nicknames = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Nickname
            // 
            this.textBox_Nickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Nickname.Location = new System.Drawing.Point(5, 10);
            this.textBox_Nickname.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Nickname.Multiline = true;
            this.textBox_Nickname.Name = "textBox_Nickname";
            this.textBox_Nickname.Size = new System.Drawing.Size(197, 31);
            this.textBox_Nickname.TabIndex = 0;
            // 
            // button_connect
            // 
            this.button_connect.BackColor = System.Drawing.Color.Transparent;
            this.button_connect.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_connect.Location = new System.Drawing.Point(206, 10);
            this.button_connect.Margin = new System.Windows.Forms.Padding(2);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(124, 31);
            this.button_connect.TabIndex = 1;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = false;
            this.button_connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox_chat
            // 
            this.listBox_chat.FormattingEnabled = true;
            this.listBox_chat.HorizontalScrollbar = true;
            this.listBox_chat.Location = new System.Drawing.Point(12, 155);
            this.listBox_chat.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_chat.Name = "listBox_chat";
            this.listBox_chat.Size = new System.Drawing.Size(335, 121);
            this.listBox_chat.TabIndex = 2;
            // 
            // textBox_sendMessage
            // 
            this.textBox_sendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_sendMessage.Location = new System.Drawing.Point(5, 61);
            this.textBox_sendMessage.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_sendMessage.Multiline = true;
            this.textBox_sendMessage.Name = "textBox_sendMessage";
            this.textBox_sendMessage.Size = new System.Drawing.Size(197, 30);
            this.textBox_sendMessage.TabIndex = 3;
            // 
            // button_sendMessage
            // 
            this.button_sendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_sendMessage.Location = new System.Drawing.Point(206, 61);
            this.button_sendMessage.Margin = new System.Windows.Forms.Padding(2);
            this.button_sendMessage.Name = "button_sendMessage";
            this.button_sendMessage.Size = new System.Drawing.Size(124, 30);
            this.button_sendMessage.TabIndex = 4;
            this.button_sendMessage.Text = "Send Message";
            this.button_sendMessage.UseVisualStyleBackColor = true;
            this.button_sendMessage.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox_nicknames
            // 
            this.listBox_nicknames.FormattingEnabled = true;
            this.listBox_nicknames.HorizontalScrollbar = true;
            this.listBox_nicknames.Location = new System.Drawing.Point(370, 51);
            this.listBox_nicknames.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_nicknames.Name = "listBox_nicknames";
            this.listBox_nicknames.Size = new System.Drawing.Size(116, 225);
            this.listBox_nicknames.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button_Reset);
            this.groupBox1.Controls.Add(this.textBox_Nickname);
            this.groupBox1.Controls.Add(this.button_connect);
            this.groupBox1.Controls.Add(this.button_sendMessage);
            this.groupBox1.Controls.Add(this.textBox_sendMessage);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 138);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(365, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Online :";
            // 
            // button_Reset
            // 
            this.button_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Reset.Location = new System.Drawing.Point(5, 103);
            this.button_Reset.Margin = new System.Windows.Forms.Padding(2);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(325, 30);
            this.button_Reset.TabIndex = 5;
            this.button_Reset.Text = "Reset chat";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // ChatApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 292);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_nicknames);
            this.Controls.Add(this.listBox_chat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(523, 331);
            this.MinimumSize = new System.Drawing.Size(523, 331);
            this.Name = "ChatApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatApplication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Nickname;
        private System.Windows.Forms.Button button_connect;
        public System.Windows.Forms.ListBox listBox_chat;
        private System.Windows.Forms.TextBox textBox_sendMessage;
        private System.Windows.Forms.Button button_sendMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListBox listBox_nicknames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Reset;
    }
}

