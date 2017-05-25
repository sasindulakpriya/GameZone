using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcUse
{
    public partial class Form1 : Form 
    {
        delegate void ShowMessageMethod(string msg);

        UdpClient _server = null;
        IPEndPoint _client = null;
        Thread _listenThread = null;
        private bool _isServerStarted = false;
        private LinkedList<Object> linked;
        Funtion doFuntion = new Funtion();
        public Form1()
        {
            InitializeComponent();
            linked = new LinkedList<Object>();
            testPanal.Hide();
        }

        
        private void Start()
        {
            //Create the server.
            IPEndPoint serverEnd = new IPEndPoint(IPAddress.Any, 9876);
            _server = new UdpClient(serverEnd);
            // ShowMsg();
            //Create the client end.
            _client = new IPEndPoint(IPAddress.Any, 0);

            //Start listening.
            Thread listenThread = new Thread(new ThreadStart(Listening));
            listenThread.Start();
            //Change state to indicate the server starts.
            _isServerStarted = true;
        }

        private void Stop()
        {
            try
            {
                //Stop listening.
                _listenThread.Join();
                ShowMsg("Server stops.");
                _server.Close();
                //Changet state to indicate the server stops.
                _isServerStarted = false;
            }
            catch (Exception excp)
            { }
        }

        public void Listening()
        {
            byte[] data;
            //Listening loop.
            while (true)
            {
                //receieve a message form a client.
                data = _server.Receive(ref _client);
                string receivedMsg = Encoding.ASCII.GetString(data, 0, data.Length);
                //Show the message.
                // this.Invoke(new ShowMessageMethod(ShowMsg), new object[] { "Client:" + receivedMsg });

                this.Invoke(new ShowMessageMethod(ShowMsg), new object[] { receivedMsg });

                //Send a response message.
                data = Encoding.ASCII.GetBytes("Server:" + receivedMsg);
                // string result = System.Text.Encoding.UTF8.GetString(data);

                _server.Send(data, data.Length, _client);
                //Sleep for UI to work.
                Thread.Sleep(500);
            }
        }

        private void ShowMsg(string msg)
        {
            string command;
            string tm;
            string timeString;
            int time;

            this.richTextBox1.Text += msg;
            string sentence = msg.Trim();

            command = sentence.Substring(0, 2);
            tm = sentence.Substring(1, 5);
            timeString = sentence.Substring(2, 4);

            this.tBox1.Text += command;
            this.tBox2.Text += timeString;



            if (sentence.Equals("online"))
            {

                this.status.Text = "pc is online";


            }
            else if (command.Equals("sd"))
            {

                time = Int32.Parse(timeString);
                this.status.Text = "pc will shutdown" + time;
                int i = time;
                TimeOutThread mm = new TimeOutThread();
                beanLinked b = new beanLinked();
                Thread threadinit;

                if (b.isEmpty())
                {
                    textBox.Text = "This is if part...";
                    threadinit = new Thread(() => mm.onTimeDo(time));
                    b.setLinkFirst(threadinit);
                     threadinit.Start();
                }
                else

                {
                    richTextBox1.Text = "This is else part...";

                    Thread t = b.getLinkFirst();
                    t.Abort();
                    status.Text = "This is else part...";
                    threadinit = new Thread(() => mm.onTimeDo(time));
                    threadinit.Start();
                    b.setLinkFirst(threadinit);
                }





            }
            else if (command.Equals("ud"))
            {

                time = Int32.Parse(timeString);
                this.status.Text = "pc will " + time;
                TimeOutThread timeOut = new TimeOutThread();
                TimeOutThread mm = new TimeOutThread();
                mm.onTimeDo(time);


            }
            else
            {
                this.status.Text = command + "gdfgdff";

            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.Alt && e.KeyCode.ToString() == "F4")
            { Form r = new Form();
            r.Show(); }
          if (e.Control && e.KeyCode.ToString() == "F1")
                    testPanal.Show();
            if (e.Control && e.KeyCode.ToString() == "F2")
                testPanal.Hide();



        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            WindowState = FormWindowState.Minimized;
        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fullScn(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        
        }
        private void admin()
        {
            Admin_Panal hh = new Admin_Panal();
            hh.Show();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (_isServerStarted)
            {
                Stop();
                startBtn.Text = "StartServer";
                online.Text = "sever is offline";
            }
            else
            {
                Start();
                startBtn.Text = "StopServer";
                online.Text = "sever is online";
            }
        }

        private void testPanal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openTask_Click(object sender, EventArgs e)
        {
            doFuntion.openTask();
        }

        private void closeEx_Click(object sender, EventArgs e)
        {
            doFuntion.closeExplorer();
        }

        private void usbD_Click(object sender, EventArgs e)
        {
            doFuntion.disbleUsb1();

        }

        private void usbE_Click(object sender, EventArgs e)
        {
            doFuntion.enableUsb1();
        }

        private void gameOpen1_Click(object sender, EventArgs e)
        {
            doFuntion.openGame1();
        }
    }
}
