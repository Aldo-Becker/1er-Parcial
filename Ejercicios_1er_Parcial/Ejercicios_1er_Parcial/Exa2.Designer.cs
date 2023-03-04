namespace Ejercicios_1er_Parcial
{
    partial class Exa2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Producto1TextBox = new System.Windows.Forms.TextBox();
            this.Producto2TextBox = new System.Windows.Forms.TextBox();
            this.Precio1TextBox = new System.Windows.Forms.TextBox();
            this.Precio2TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Producto 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio:";
            // 
            // Producto1TextBox
            // 
            this.Producto1TextBox.Location = new System.Drawing.Point(144, 87);
            this.Producto1TextBox.Name = "Producto1TextBox";
            this.Producto1TextBox.Size = new System.Drawing.Size(147, 20);
            this.Producto1TextBox.TabIndex = 5;
            // 
            // Producto2TextBox
            // 
            this.Producto2TextBox.Location = new System.Drawing.Point(377, 87);
            this.Producto2TextBox.Name = "Producto2TextBox";
            this.Producto2TextBox.Size = new System.Drawing.Size(141, 20);
            this.Producto2TextBox.TabIndex = 6;
            // 
            // Precio1TextBox
            // 
            this.Precio1TextBox.Location = new System.Drawing.Point(142, 129);
            this.Precio1TextBox.Name = "Precio1TextBox";
            this.Precio1TextBox.Size = new System.Drawing.Size(49, 20);
            this.Precio1TextBox.TabIndex = 7;
            // 
            // Precio2TextBox
            // 
            this.Precio2TextBox.Location = new System.Drawing.Point(343, 135);
            this.Precio2TextBox.Name = "Precio2TextBox";
            this.Precio2TextBox.Size = new System.Drawing.Size(47, 20);
            this.Precio2TextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lps.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lps.";
            // 
            // Exa2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Precio2TextBox);
            this.Controls.Add(this.Precio1TextBox);
            this.Controls.Add(this.Producto2TextBox);
            this.Controls.Add(this.Producto1TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Exa2";
            this.Text = "Exa2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Producto1TextBox;
        private System.Windows.Forms.TextBox Producto2TextBox;
        private System.Windows.Forms.TextBox Precio1TextBox;
        private System.Windows.Forms.TextBox Precio2TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}