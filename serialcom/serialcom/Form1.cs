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
        ControleRobot controle;
        public Form1()
        {
            InitializeComponent();
            serialPort1 = new SerialPort();

            this.KeyPreview = true;
            controle = new ControleRobot(this);
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


        public void send(String message) {
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

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
              //  if(com.getconfirm())
                    controle.ShowDialog();
            }
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

         //   MessageBox.Show("meau", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        //  private void send_Click(object sender, EventArgs e)
        //{

        //}
    }




}
