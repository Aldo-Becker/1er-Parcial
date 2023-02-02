namespace Ejercicios_1er_Parcial
{
    partial class Ejercicio1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Número1TextBox = new System.Windows.Forms.TextBox();
            this.Número2TextBox = new System.Windows.Forms.TextBox();
            this.SumarButton = new System.Windows.Forms.Button();
            this.ResultadoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 2:";
            // 
            // Número1TextBox
            // 
            this.Número1TextBox.Location = new System.Drawing.Point(137, 42);
            this.Número1TextBox.Name = "Número1TextBox";
            this.Número1TextBox.Size = new System.Drawing.Size(100, 20);
            this.Número1TextBox.TabIndex = 2;
            // 
            // Número2TextBox
            // 
            this.Número2TextBox.Location = new System.Drawing.Point(137, 85);
            this.Número2TextBox.Name = "Número2TextBox";
            this.Número2TextBox.Size = new System.Drawing.Size(100, 20);
            this.Número2TextBox.TabIndex = 3;
            // 
            // SumarButton
            // 
            this.SumarButton.Location = new System.Drawing.Point(137, 129);
            this.SumarButton.Name = "SumarButton";
            this.SumarButton.Size = new System.Drawing.Size(100, 23);
            this.SumarButton.TabIndex = 4;
            this.SumarButton.Text = "Sumar";
            this.SumarButton.UseVisualStyleBackColor = true;
            this.SumarButton.Click += new System.EventHandler(this.SumarButton_Click);
            // 
            // ResultadoLabel
            // 
            this.ResultadoLabel.AutoSize = true;
            this.ResultadoLabel.Location = new System.Drawing.Point(286, 48);
            this.ResultadoLabel.Name = "ResultadoLabel";
            this.ResultadoLabel.Size = new System.Drawing.Size(35, 13);
            this.ResultadoLabel.TabIndex = 5;
            this.ResultadoLabel.Text = "label3";
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 310);
            this.Controls.Add(this.ResultadoLabel);
            this.Controls.Add(this.SumarButton);
            this.Controls.Add(this.Número2TextBox);
            this.Controls.Add(this.Número1TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio1";
            this.Text = "Ejercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Número1TextBox;
        private System.Windows.Forms.TextBox Número2TextBox;
        private System.Windows.Forms.Button SumarButton;
        private System.Windows.Forms.Label ResultadoLabel;
    }
}