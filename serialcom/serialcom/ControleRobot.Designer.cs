﻿namespace serialcom
{
    partial class ControleRobot
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
            this.SuspendLayout();
            // 
            // ControleRobot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ControleRobot";
            this.Text = "ControleRobot";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControleRobot_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ControleRobot_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ControleRobot_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}