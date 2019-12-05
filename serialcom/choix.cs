using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace serialcom
{
    public partial class choix : Form
    {
        private string BD = "data.csv";
        private DataTable table = new DataTable();

        Form1 com; //window for first connexion, ask the user
        ControleRobot controle; //window blank for connexion shortcut
        DataTable achat;
        DataTable recherche;

        List<String> file = new List<string>();

        public choix(Form1 com)
        {
            InitializeComponent();

            this.com = com;
            this.KeyPreview = true;
           
            StreamReader sr = new StreamReader("data.csv");

            String line;

            // Read and display lines from the file until the end of 
            // the file is reached.

            bool confirm = true;

            //initialisation de la dataGrillView de livre             
            while ((line = sr.ReadLine()) != null)
            {
                String[] split;
                split = line.Split(';');

                if (confirm)
                {
                    for (int x = 0; x < split.Length; x++)
                    {
                        DataColumn colone = new DataColumn();
                        if (split[x].Contains('$'))
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
            achat = table.Clone();
            achat.Rows.Clear();
            recherche = table.Clone();
            recherche.Clear();
            recherche = table.Clone();

            TXWINDOW.Text = "a";
            TXWINDOW.Text = "";
          
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int b = data.CurrentCell.ColumnIndex;
            int a = data.CurrentCell.RowIndex;

            if (b == 0) {

                com.send(recherche.Rows[a][5].ToString() + "1");
            }

        }

        private void TXWINDOW_TextChanged(object sender, EventArgs e)
        {
            recherche = table.Clone();
            recherche.Rows.Clear();//enleve tout ce qu'il y a dans bibliotheque
            for (int count = 0; count < table.Rows.Count; count++)
            {

                //for (int count2 = 0; count2 < (table.Columns.Count - 1); count2++)
                //{

                if (table.Rows[count][0].ToString().Contains(TXWINDOW.Text)) //.Text est le texte
                {
                    DataRow row = recherche.NewRow();
                    for (int x = 0; x < table.Columns.Count; x++)
                    {
                        row[x] = table.Rows[count][x];
                    }
                    recherche.Rows.Add(row);
                }
                // }

            }
            data.DataSource = recherche;
        }
    }
}
