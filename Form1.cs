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

namespace MwaChat
{
    public partial class Form1 : Form
    {
        Socket sok;
        EndPoint epLocal, epRemote;

        public Form1()
        {
            InitializeComponent();

            sok = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sok.SetSocketOption(SocketOptionLevel.Socket,SocketOptionName.ReuseAddress,true);

            TextLocalIP.Text = GetLocalIP();
            User_TwoIP.Text = GetLocalIP();
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }               
            }
            return "127.0.0.1";
        }

        private void MessageCallBack(IAsyncResult aRsult)
        {
            try 
            {
                int size = sok.EndReceiveFrom(aRsult,ref epRemote);

                if (size > 0)
                {
                    byte[] receivedData = new byte[1464];
                    receivedData = (byte[])aRsult.AsyncState;

                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);
                    ListMassage.Items.Add("Friend: " + receivedMessage);

                }
                byte[] buffer = new byte[1500];
                sok.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString());
            } 
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(MessagetextBox.Text);

                sok.Send(msg);

                ListMassage.Items.Add("Me: " + MessagetextBox.Text);
                MessagetextBox.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(TextLocalIP.Text), Convert.ToInt32(textlocalPort.Text));
                sok.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(User_TwoIP.Text), Convert.ToInt32(text_userTwoPort.Text));
                sok.Connect(epRemote);

                byte[] buffer = new byte[1500];
                sok.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                Startbutton1.Text = "Connected";
                Startbutton1.Enabled = false;

                Sendbutton2.Enabled = true;
                MessagetextBox.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void TextLocalIP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
