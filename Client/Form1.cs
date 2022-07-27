using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ChatApplication : Form
    {
        public ChatApplication()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox_chat.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChatServerConnector.Connect(textBox_Nickname.Text);
            ChatServerConnector.GetInstance().UserJoinMain(textBox_Nickname.Text);
            textBox_Nickname.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChatServerConnector.GetInstance().SendMessageToServer(textBox_sendMessage.Text, textBox_Nickname.Text);
            textBox_sendMessage.Text = "";
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            listBox_chat.Items.Clear();
        }
    }
}
