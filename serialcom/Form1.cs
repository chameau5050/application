using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace serialcom
{


    public partial class Form1 : Form
    {

        private SerialPort serialPort1;
        Communication com;

        public Form1()
        {
            InitializeComponent();
            serialPort1 = new SerialPort();

            com = new Communication();
            com.ShowDialog();
        }

        private void CONNECT_Click(object sender, EventArgs e)
        {

            if (com.getconfirm())
            {
                serialPort1.PortName = com.getPortName();
                serialPort1.BaudRate = com.getBaudRate();
                serialPort1.Open();

                if (!serialPort1.IsOpen) return;
                CONNECT.Enabled = false;

                MessageBox.Show("Connected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
                MessageBox.Show("Connection seting not confirmed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void send(String message) {
            serialPort1.Write(message);
        }



        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            string message = serialPort1.ReadExisting();
         // a ajouter si un bi-latéral nessésaire
         //   this.Invoke(new EventHandler(DisplayText));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tx = TXWINDOW.Text;
            serialPort1.Write(tx);
            TXWINDOW.Clear();
        }

        //  private void send_Click(object sender, EventArgs e)
        //{

        //}
    }




}
