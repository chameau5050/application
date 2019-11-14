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
    public partial class ControleRobot : Form
    {
        Form1 com;
        
        public ControleRobot(Form1 main)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.com = main;

        }

        private void ControleRobot_KeyDown(object sender, KeyEventArgs e)
        {
            
             if (e.KeyCode == Keys.W)
            {
                com.send("w"); 
            }
            else if (e.KeyCode == Keys.S)
            {
                com.send("A");
            }
            else if (e.KeyCode == Keys.A)
            {
                com.send("A");
            }
            else if (e.KeyCode == Keys.D)
            {
                com.send("D");
            }


        }

        private void ControleRobot_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void ControleRobot_KeyUp(object sender, KeyEventArgs e)
        {
            com.send("B");
        }
    }
}
