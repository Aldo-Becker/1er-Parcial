﻿namespace Ejercicios_1er_Parcial
{
    partial class Ejercicio6
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ArreglosButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(52, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            // 
            // ArreglosButton
            // 
            this.ArreglosButton.Location = new System.Drawing.Point(222, 60);
            this.ArreglosButton.Name = "ArreglosButton";
            this.ArreglosButton.Size = new System.Drawing.Size(75, 23);
            this.ArreglosButton.TabIndex = 1;
            this.ArreglosButton.Text = "Arreglos";
            this.ArreglosButton.UseVisualStyleBackColor = true;
            this.ArreglosButton.Click += new System.EventHandler(this.ArreglosButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(222, 173);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // Ejercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 361);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ArreglosButton);
            this.Controls.Add(this.listBox1);
            this.Name = "Ejercicio6";
            this.Text = "Ejercicio6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ArreglosButton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}