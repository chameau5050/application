using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serialcom
{

    

    public partial class Communication : Form
    {
        public Communication()
        {
            InitializeComponent();
        }

        private bool confirm = false;

        public bool getconfirm() {

            return confirm;
        }

        public int getBaudRate()
        {
            return Int32.Parse(baudRate.Text);
        }

        public string getPortName() {
            return portName.Text;
        }

        private void confirmer_Click(object sender, EventArgs e)
        {
            confirm = true;
            this.Close();
        }
    }
}
