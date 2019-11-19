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
            this.DECONNECTION = new System.Windows.Forms.Button();
            this.TXWINDOW = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // CONNECT
            // 
            this.CONNECT.Location = new System.Drawing.Point(79, 368);
            this.CONNECT.Name = "CONNECT";
            this.CONNECT.Size = new System.Drawing.Size(112, 54);
            this.CONNECT.TabIndex = 0;
            this.CONNECT.Text = "connexion";
            this.CONNECT.UseVisualStyleBackColor = true;
            this.CONNECT.Click += new System.EventHandler(this.CONNECT_Click);
            // 
            // DECONNECTION
            // 
            this.DECONNECTION.Location = new System.Drawing.Point(585, 368);
            this.DECONNECTION.Name = "DECONNECTION";
            this.DECONNECTION.Size = new System.Drawing.Size(112, 54);
            this.DECONNECTION.TabIndex = 1;
            this.DECONNECTION.Text = "deconnexion";
            this.DECONNECTION.UseVisualStyleBackColor = true;
            // 
            // TXWINDOW
            // 
            this.TXWINDOW.Location = new System.Drawing.Point(315, 46);
            this.TXWINDOW.Name = "TXWINDOW";
            this.TXWINDOW.Size = new System.Drawing.Size(100, 20);
            this.TXWINDOW.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.Location = new System.Drawing.Point(506, 46);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(240, 150);
            this.data.TabIndex = 4;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TXWINDOW);
            this.Controls.Add(this.DECONNECTION);
            this.Controls.Add(this.CONNECT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CONNECT;
        private System.Windows.Forms.Button DECONNECTION;
        private System.Windows.Forms.TextBox TXWINDOW;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView data;
    }
}

