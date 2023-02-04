namespace Ejercicios_1er_Parcial
{
    partial class Tarea1
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
            this.NúmeroTextBox = new System.Windows.Forms.TextBox();
            this.VerificarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero:";
            // 
            // NúmeroTextBox
            // 
            this.NúmeroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NúmeroTextBox.Location = new System.Drawing.Point(141, 71);
            this.NúmeroTextBox.Name = "NúmeroTextBox";
            this.NúmeroTextBox.Size = new System.Drawing.Size(159, 26);
            this.NúmeroTextBox.TabIndex = 1;
            // 
            // VerificarButton
            // 
            this.VerificarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerificarButton.Location = new System.Drawing.Point(135, 135);
            this.VerificarButton.Name = "VerificarButton";
            this.VerificarButton.Size = new System.Drawing.Size(159, 42);
            this.VerificarButton.TabIndex = 2;
            this.VerificarButton.Text = "Verificar";
            this.VerificarButton.UseVisualStyleBackColor = true;
            this.VerificarButton.Click += new System.EventHandler(this.VerificarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese Un Número Para Identificar Si es Par o Impar y Si es Positivo o Negativo";
            // 
            // Tarea1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 340);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VerificarButton);
            this.Controls.Add(this.NúmeroTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Tarea1";
            this.Text = "Tarea1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NúmeroTextBox;
        private System.Windows.Forms.Button VerificarButton;
        private System.Windows.Forms.Label label2;
    }
}