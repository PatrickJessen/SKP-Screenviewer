using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Drawing.Imaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Net;

namespace SKP_Screenviewer
{
    public partial class Form2 : Form
    {
        private int portNumber2;
        private TcpClient client2;
        private TcpListener server;
        private NetworkStream mainStream;

        private readonly Thread Listening;
        private readonly Thread GetImage;

        public Form2(int Port)
        {
            portNumber2 = Port;
            client2 = new TcpClient();
            Listening = new Thread(StartListening);
            GetImage = new Thread(ReceiveImage);

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void StartListening()
        {
            while (!client2.Connected)
            {
                server.Start();
                client2 = server.AcceptTcpClient();
            }
            GetImage.Start();
        }

        private void StopListening()
        {
            server.Stop();
            client2 = null;
            if (Listening.IsAlive)
            {
                Listening.Abort();
            }
            if (GetImage.IsAlive)
            {
                Listening.Abort();
            }
        }

        private void ReceiveImage()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            while (client2.Connected)
            {
                mainStream = client2.GetStream();
                pictureBox1.Image = (Image)binaryFormatter.Deserialize(mainStream);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            server = new TcpListener(IPAddress.Any, portNumber2);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            StopListening();
        }
    }
}
