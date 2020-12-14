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
    public partial class SKPScreenViewer : Form
    {
        private readonly TcpClient client = new TcpClient();
        private NetworkStream mainStream;
        private int portNumber;

        private static Image GetDesktop()
        {
            Rectangle bound = Screen.PrimaryScreen.Bounds;
            Bitmap screenshot = new Bitmap(bound.Width, bound.Height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(screenshot);
            graphics.CopyFromScreen(bound.X, bound.Y, 0, 0, bound.Size, CopyPixelOperation.SourceCopy);

            return screenshot;
        }

        private void SendDesktopImage()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            mainStream = client.GetStream();
            binaryFormatter.Serialize(mainStream, GetDesktop());
        }

        public SKPScreenViewer()
        {

            InitializeComponent();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            share.Enabled = false;
        }

        private void ConnectionClickEvent(object sender, EventArgs e)
        {
            try
            {
                portNumber = int.Parse(port.Text);
                client.Connect(conId.Text, portNumber);
                connect.Text = "Connected";
                MessageBox.Show("Connected");
                connect.Enabled = false;
                share.Enabled = true;
            }
            catch(Exception f)
            {
                MessageBox.Show("Failed to connect" + f);
            }
        }

        private void ShareScreenClickEvent(object sender, EventArgs e)
        {
            if (share.Text.StartsWith("Share"))
            {
                timer1.Start();
                share.Text = "Stop sharing";
            }
            else
            {
                timer1.Stop();
                share.Text = "Share Screen";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendDesktopImage();
        }

        private void port2_TextChanged(object sender, EventArgs e)
        {

        }

        private void conId2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
