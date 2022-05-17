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
            sckt = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sckt.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //secondly we are setting up getting the user IP
            txtLocalIP.Text = GetLocalIP();
            txtRemoteIP.Text = GetLocalIP();

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
            //bind the socket
            ePLocalMachine = new IPEndPoint(IPAddress.Parse(txtLocalIP.Text), Convert.ToInt32(txtLocalPort.Text));
            sckt.Bind(ePLocalMachine);

            //connect to remote IP
            ePRemoteMachine = new IPEndPoint(IPAddress.Parse(txtRemoteIP.Text), Convert.ToInt32(txtRemotePort.Text));
            sckt.Connect(ePRemoteMachine);
            //listen to a specific port
            buffer = new byte[1500];
            sckt.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref ePRemoteMachine, new AsyncCallback(MessageCallBack), buffer);
        }
        
    }
}
