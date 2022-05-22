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
using System.Threading;

namespace ChatBox
{
    public partial class Form1 : Form
    {
        Socket sckt, sckt2;
        EndPoint ePLocalMachine, ePRemoteMachine, ePRemoteMachine1, ePRemoteMachine2;
        byte[] buffer, buffer1, buffer2;
        int Counter;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object theSender, EventArgs e)
        {
            //first we are setting up the socket
            sckt = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sckt.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //Second socket for group chat
            sckt2 = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sckt2.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //secondly we are setting up getting the user IP
            txtLocalIP.Text = GetLocalIP();
            txtRemoteIP.Text = GetLocalIP();

            Counter = 0;
        }

        private string GetLocalIP()
        {
            IPHostEntry hst;
            hst = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress IP in hst.AddressList)
            {
                if (IP.AddressFamily == AddressFamily.InterNetwork)
                    return IP.ToString();
            }
            return "127.0.0.1";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //In the send button
            // convert message string to byte[]
            ASCIIEncoding encode = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = encode.GetBytes(txtMess.Text);

            //send the encoded message 
            sckt.Send(sendingMessage);

            //Send to group chat, if group chat.
            if (Counter == 1)
            {
                sckt2.Send(sendingMessage);
            }

            //Add to listbox 
            lboxChat.Items.Add("Me: " + txtMess.Text);
            txtMess.Text = "";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Counter = 0;

            //bind the socket
            ePLocalMachine = new IPEndPoint(IPAddress.Parse(txtLocalIP.Text), Convert.ToInt32(txtLocalPort.Text));
            sckt.Bind(ePLocalMachine);

            //connect to remote IP
            ePRemoteMachine = new IPEndPoint(IPAddress.Parse(txtRemoteIP.Text), Convert.ToInt32(txtRemotePort.Text));
            sckt.Connect(ePRemoteMachine);
            //listen to a specific port
            buffer = new byte[1500];
            sckt.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref ePRemoteMachine, new AsyncCallback(MessageCallback), buffer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Counter = 1;

            //first we are setting up the socket
            sckt = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sckt.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //Second socket for group chat
            sckt2 = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sckt2.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //connect to remote IP
            string Contact1 = "";
            string Contact2 = "";
            int counter = 0;
            string MyPort = "";
            for (int i = 0; i < ContactsList.Items.Count; i++)
            {
                string[] Details = ContactsList.Items[i].ToString().Split(':');
                if(Details[1] == GetLocalIP().ToString())
                {
                    MyPort = Details[2];
                }
                else if(counter == 0)
                {
                    Contact1 = ContactsList.Items[i].ToString();
                    counter += 1;
                }
                else
                {
                    Contact2 = ContactsList.Items[i].ToString();
                    counter += 1;
                }
            }

            //bind the socket
            ePLocalMachine = new IPEndPoint(IPAddress.Parse(GetLocalIP()), Convert.ToInt32(MyPort));
            sckt.Bind(ePLocalMachine);
            sckt2.Bind(ePLocalMachine);

            string[] Contact1Split = Contact1.Split(':');
            string[] Contact2Split = Contact2.Split(':');


            ePRemoteMachine1 = new IPEndPoint(IPAddress.Parse(GetLocalIP()), Convert.ToInt32(MyPort));
            ePRemoteMachine2 = new IPEndPoint(IPAddress.Parse(GetLocalIP()), Convert.ToInt32(MyPort));

            sckt.Connect(ePRemoteMachine1);
            sckt2.Connect(ePRemoteMachine2);

            Thread TOne = new Thread(new ThreadStart(BeginReceive1));
            Thread TTwo = new Thread(new ThreadStart(BeginReceive2));

            TOne.Start();
            TTwo.Start();
        }

        private void BeginReceive1()
        {
            //listen to a specific port
            buffer1 = new byte[1500];
            sckt.BeginReceiveFrom(buffer1, 0, buffer1.Length, SocketFlags.None, ref ePRemoteMachine1, new AsyncCallback(MessageCallback3), buffer1);
        }

        private void BeginReceive2()
        {
            
            //listen to second port
            buffer2 = new byte[1500];
            sckt2.BeginReceiveFrom(buffer2, 0, buffer2.Length, SocketFlags.None, ref ePRemoteMachine2, new AsyncCallback(MessageCallback2), buffer2);
        }


        private void ContactsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //first we are setting up the socket
            sckt = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sckt.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //secondly we are setting up getting the user IP
            txtLocalIP.Text = GetLocalIP();
            txtRemoteIP.Text = GetLocalIP();
        }

        private void MessageCallback(IAsyncResult iaResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])iaResult.AsyncState;

                //convert byte array to string
                ASCIIEncoding encode = new ASCIIEncoding();
                string receivedMessage = encode.GetString(receivedData);

                //Add message to the listbox 
                
                lboxChat.Items.Add("Friend:" + receivedMessage);
                
                

                buffer = new byte[1500];
                sckt.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref ePRemoteMachine, new AsyncCallback(MessageCallback), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void MessageCallback3(IAsyncResult iaResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])iaResult.AsyncState;

                //convert byte array to string
                ASCIIEncoding encode = new ASCIIEncoding();
                string receivedMessage = encode.GetString(receivedData);

                Thread.Sleep(500);

                if (lboxChat.InvokeRequired)
                {
                    lboxChat.Invoke(new Action(BeginReceive1));
                    return;
                }
                //Add message to the listbox 
                lboxChat.Items.Add("Friend 1:" + receivedMessage);

                Thread.Sleep(500);



                buffer1 = new byte[1500];
                sckt.BeginReceiveFrom(buffer1, 0, buffer1.Length, SocketFlags.None, ref ePRemoteMachine1, new AsyncCallback(MessageCallback3), buffer1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void MessageCallback2(IAsyncResult iaResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])iaResult.AsyncState;

                //convert byte array to string
                ASCIIEncoding encode = new ASCIIEncoding();
                string receivedMessage = encode.GetString(receivedData);


                if (lboxChat.InvokeRequired)
                {
                    lboxChat.Invoke(new Action(BeginReceive2));
                    return;
                }

                //Add message to the listbox 
                lboxChat.Items.Add("Friend 2:" + receivedMessage);

                
                buffer2 = new byte[1500];
                sckt2.BeginReceiveFrom(buffer2, 0, buffer2.Length, SocketFlags.None, ref ePRemoteMachine2, new AsyncCallback(MessageCallback2), buffer2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
