namespace serialcom
{
    partial class choix
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.TXWINDOW = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(343, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Recherche :";
            // 
            // TXWINDOW
            // 
            this.TXWINDOW.Location = new System.Drawing.Point(440, 22);
            this.TXWINDOW.Name = "TXWINDOW";
            this.TXWINDOW.Size = new System.Drawing.Size(257, 20);
            this.TXWINDOW.TabIndex = 16;
            this.TXWINDOW.TextChanged += new System.EventHandler(this.TXWINDOW_TextChanged);
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data.ColumnHeadersHeight = 29;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6});
            this.data.Location = new System.Drawing.Point(12, 48);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 51;
            this.data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data.Size = new System.Drawing.Size(684, 346);
            this.data.TabIndex = 17;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ajouter/Retirer";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "Bibliothèque";
            // 
            // choix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TXWINDOW);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label3);
            this.Name = "choix";
            this.Text = "choix";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXWINDOW;
        public System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.Label label3;
    }
}