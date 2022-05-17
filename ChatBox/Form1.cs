using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ChatBox
{
    public partial class Form1 : Form
    {
        Socket sckt;
        EndPoint ePLocalMachine, ePRemoteMachine;
        byte[] buffer;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object theSender, EventArgs e)
        {
            //first we are setting up the socket
            sckt = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, Protocol.Udp);
            sckt.SetSockets(SetSocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //secondly we are setting up getting the user IP
            textLocalMachineIp.Text = GetLocalIP();
            textRemoteMachineIp.Text = GetLocalIP();

        }

        private string GetLocalIP()
        {
            IPHostEntry hst;
            hst = Dns.GetHostEntry(Dns.GetHostByName());
            foreach (IPAddress IP in hst.AddressList)
            {
                if (IP.AddressFamily == AddressFamily.InterNetwork)
                    return IP.ToString();
            }
            return "127.0.0.1";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

        }
        
    }
}
