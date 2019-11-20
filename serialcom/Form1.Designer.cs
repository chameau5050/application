namespace serialcom
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.CONNECT = new System.Windows.Forms.Button();
            this.TXWINDOW = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // CONNECT
            // 
            this.CONNECT.Location = new System.Drawing.Point(1070, 51);
            this.CONNECT.Name = "CONNECT";
            this.CONNECT.Size = new System.Drawing.Size(91, 37);
            this.CONNECT.TabIndex = 0;
            this.CONNECT.Text = "connexion";
            this.CONNECT.UseVisualStyleBackColor = true;
            this.CONNECT.Click += new System.EventHandler(this.CONNECT_Click);
            // 
            // TXWINDOW
            // 
            this.TXWINDOW.Location = new System.Drawing.Point(822, 54);
            this.TXWINDOW.Name = "TXWINDOW";
            this.TXWINDOW.Size = new System.Drawing.Size(150, 20);
            this.TXWINDOW.TabIndex = 2;
            this.TXWINDOW.TextChanged += new System.EventHandler(this.TXWINDOW_TextChanged_1);
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data.ColumnHeadersHeight = 29;
            this.data.Location = new System.Drawing.Point(405, 77);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 51;
            this.data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data.Size = new System.Drawing.Size(684, 141);
            this.data.TabIndex = 4;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CONNECT);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1208, 101);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(295, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "©";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 56);
            this.label1.TabIndex = 6;
            this.label1.Text = "BiblioRobot";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(399, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bibliothèque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 44);
            this.label4.TabIndex = 7;
            this.label4.Text = "Commander avec BiblioRobot \r\nc\'est facile, rapide et efficace.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(405, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(684, 120);
            this.dataGridView1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(408, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Panier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.TXWINDOW);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.data);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(41, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1118, 505);
            this.panel3.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(411, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Votre panier est vide";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(920, 423);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(169, 60);
            this.panel6.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(405, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(475, 60);
            this.button2.TabIndex = 13;
            this.button2.Text = "Commander maintenant";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(41, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(317, 441);
            this.panel4.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(46, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 227);
            this.panel2.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(733, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "recherche :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1196, 687);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CONNECT;
        private System.Windows.Forms.TextBox TXWINDOW;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

