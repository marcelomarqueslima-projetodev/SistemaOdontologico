﻿namespace SistemaOdontologico
{
    partial class FrmConDentista
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
            this.tc = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc.Location = new System.Drawing.Point(2, 2);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(911, 447);
            this.tc.TabIndex = 0;
            // 
            // FrmConDentista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.tc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConDentista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Dentista";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc;
    }
}