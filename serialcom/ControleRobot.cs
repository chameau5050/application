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
        MainWindow com;
        
        public ControleRobot(MainWindow main)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.com = main;

        }

        //sending notification that user is pressing WASD
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

        //sending notification that user spot pressing WASD
        private void ControleRobot_KeyUp(object sender, KeyEventArgs e)
        {
            com.send("B");
        }

        private void ControleRobot_Load(object sender, EventArgs e)
        {

        }
    }
}
