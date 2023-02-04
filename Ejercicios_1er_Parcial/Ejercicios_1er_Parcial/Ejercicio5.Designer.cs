namespace Ejercicios_1er_Parcial
{
    partial class Ejercicio5
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
            this.HornearButton = new System.Windows.Forms.Button();
            this.HornearAzincronoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Número1TextBox = new System.Windows.Forms.TextBox();
            this.Número2TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HornearButton
            // 
            this.HornearButton.Location = new System.Drawing.Point(56, 24);
            this.HornearButton.Name = "HornearButton";
            this.HornearButton.Size = new System.Drawing.Size(104, 35);
            this.HornearButton.TabIndex = 0;
            this.HornearButton.Text = "Hornear Pizza";
            this.HornearButton.UseVisualStyleBackColor = true;
            this.HornearButton.Click += new System.EventHandler(this.HornearButton_Click);
            // 
            // HornearAzincronoButton
            // 
            this.HornearAzincronoButton.Location = new System.Drawing.Point(210, 24);
            this.HornearAzincronoButton.Name = "HornearAzincronoButton";
            this.HornearAzincronoButton.Size = new System.Drawing.Size(104, 35);
            this.HornearAzincronoButton.TabIndex = 1;
            this.HornearAzincronoButton.Text = "Hornear Pizza Asincrono";
            this.HornearAzincronoButton.UseVisualStyleBackColor = true;
            this.HornearAzincronoButton.Click += new System.EventHandler(this.HornearAzincronoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número 1:";
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(334, 141);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(75, 23);
            this.CalcularButton.TabIndex = 3;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número 2:";
            // 
            // Número1TextBox
            // 
            this.Número1TextBox.Location = new System.Drawing.Point(133, 123);
            this.Número1TextBox.Name = "Número1TextBox";
            this.Número1TextBox.Size = new System.Drawing.Size(139, 20);
            this.Número1TextBox.TabIndex = 5;
            // 
            // Número2TextBox
            // 
            this.Número2TextBox.Location = new System.Drawing.Point(133, 160);
            this.Número2TextBox.Name = "Número2TextBox";
            this.Número2TextBox.Size = new System.Drawing.Size(139, 20);
            this.Número2TextBox.TabIndex = 6;
            // 
            // Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 289);
            this.Controls.Add(this.Número2TextBox);
            this.Controls.Add(this.Número1TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HornearAzincronoButton);
            this.Controls.Add(this.HornearButton);
            this.Name = "Ejercicio5";
            this.Text = "Ejercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HornearButton;
        private System.Windows.Forms.Button HornearAzincronoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Número1TextBox;
        private System.Windows.Forms.TextBox Número2TextBox;
    }
}