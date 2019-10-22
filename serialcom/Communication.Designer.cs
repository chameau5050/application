namespace serialcom
{
    partial class Communication
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
            this.confirmer = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.portName = new System.Windows.Forms.TextBox();
            this.baudRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmer
            // 
            this.confirmer.Location = new System.Drawing.Point(12, 109);
            this.confirmer.Name = "confirmer";
            this.confirmer.Size = new System.Drawing.Size(75, 23);
            this.confirmer.TabIndex = 0;
            this.confirmer.Text = "confirmer";
            this.confirmer.UseVisualStyleBackColor = true;
            this.confirmer.Click += new System.EventHandler(this.confirmer_Click);
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(98, 109);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 23);
            this.annuler.TabIndex = 1;
            this.annuler.Text = "annuler";
            this.annuler.UseVisualStyleBackColor = true;
            // 
            // portName
            // 
            this.portName.Location = new System.Drawing.Point(73, 35);
            this.portName.Name = "portName";
            this.portName.Size = new System.Drawing.Size(100, 20);
            this.portName.TabIndex = 2;
            this.portName.Text = "COM8";
            // 
            // baudRate
            // 
            this.baudRate.Location = new System.Drawing.Point(73, 67);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(100, 20);
            this.baudRate.TabIndex = 3;
            this.baudRate.Text = "9600";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "port name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "baud rate :";
            // 
            // Communication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 144);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baudRate);
            this.Controls.Add(this.portName);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.confirmer);
            this.Name = "Communication";
            this.Text = "Communication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmer;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.TextBox portName;
        private System.Windows.Forms.TextBox baudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}