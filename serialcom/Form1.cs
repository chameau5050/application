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
using System.Data.OleDb;
using System.IO;


namespace serialcom
{

    public partial class Form1 : Form
    {



        private string BD = "data.csv";
        private DataTable table = new DataTable();

        private SerialPort serialPort1 =null;
        Communication com; //window for first connexion, ask the user
        ControleRobot controle; //window blank for connexion shortcut
        public Form1()
        {
            InitializeComponent();
         
            this.KeyPreview = true;
            controle = new ControleRobot(this);
            com = new Communication(); //window principal can ask com, mais pas l'inverse
            com.ShowDialog(); //appel à l'ouverture de la window com



            StreamReader sr = new StreamReader("data.csv");
            
            String line;

            // Read and display lines from the file until the end of 
            // the file is reached.

            bool confirm = true;

            //inisialisation de la dataGrillView de livre             
            while ((line = sr.ReadLine()) != null)
            {
                String[] split;
                split = line.Split(';');

                if (confirm)
                {
                    for(int x =0; x< split.Length; x++)
                    {
                        DataColumn colone = new DataColumn();
                        if(split[x].Contains('$'))
                            colone.DataType = System.Type.GetType("System.Int32");
                        
                        colone.ColumnName = split[x];
                        table.Columns.Add(colone);
                    }
                    confirm = false;
                }
                else
                {
                    DataRow row = table.NewRow();
                    for (int x = 0; x < split.Length; x++)
                    {
                        row[x] = split[x];
                    }
                    table.Rows.Add(row);
                }
            }
            data.DataSource = table;
            
        }


        // IsNumeric Function
        static bool IsNumeric(object Expression)
        {
            // Variable to collect the Return value of the TryParse method.
            bool isNum;

            // Define variable to collect out parameter of the TryParse method. If the conversion fails, the out parameter is zero.
            double retNum;

            // The TryParse method converts a string in a specified style and culture-specific format to its double-precision floating point number equivalent.
            // The TryParse method does not generate an exception if the conversion fails. If the conversion passes, True is returned. If it does not, False is returned.
            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        private void CONNECT_Click(object sender, EventArgs e)
        {
            serialPort1 = new SerialPort();
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
               if(serialPort1 != null)
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

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void TXWINDOW_TextChanged(object sender, EventArgs e) //_TextChanged est un event
        {
            DataTable clone = table.Clone();
            clone.Rows.Clear();
            for (int count=0;count<table.Rows.Count;count++)
            {
                if (table.Rows[count][0].ToString().Contains(TXWINDOW.Text)) //.Text est le texte
                {
                    DataRow row = clone.NewRow();
                        for (int x=0; x<table.Columns.Count;x++)
                    { row[x] = table.Rows[count][x];
                    }
                    clone.Rows.Add(row);
                }
            }
            data.DataSource = clone;


        }

        //  private void send_Click(object sender, EventArgs e)
        //{

        //}
    }




}
