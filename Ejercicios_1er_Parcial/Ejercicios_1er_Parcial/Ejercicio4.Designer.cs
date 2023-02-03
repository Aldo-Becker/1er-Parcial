namespace Ejercicios_1er_Parcial
{
    partial class Ejercicio4
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
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EjecutarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DíaTextBox = new System.Windows.Forms.TextBox();
            this.MesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AñoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SemanaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CitaTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DiasTextBox = new System.Windows.Forms.TextBox();
            this.DiasRestaTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NuevaFechaTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(108, 39);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(102, 20);
            this.FechaDateTimePicker.TabIndex = 0;
            // 
            // EjecutarButton
            // 
            this.EjecutarButton.Location = new System.Drawing.Point(247, 39);
            this.EjecutarButton.Name = "EjecutarButton";
            this.EjecutarButton.Size = new System.Drawing.Size(75, 23);
            this.EjecutarButton.TabIndex = 1;
            this.EjecutarButton.Text = "Ejecutar";
            this.EjecutarButton.UseVisualStyleBackColor = true;
            this.EjecutarButton.Click += new System.EventHandler(this.EjecutarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Día:";
            // 
            // DíaTextBox
            // 
            this.DíaTextBox.Location = new System.Drawing.Point(108, 105);
            this.DíaTextBox.Name = "DíaTextBox";
            this.DíaTextBox.Size = new System.Drawing.Size(128, 20);
            this.DíaTextBox.TabIndex = 3;
            // 
            // MesTextBox
            // 
            this.MesTextBox.Location = new System.Drawing.Point(108, 165);
            this.MesTextBox.Name = "MesTextBox";
            this.MesTextBox.Size = new System.Drawing.Size(128, 20);
            this.MesTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mes:";
            // 
            // AñoTextBox
            // 
            this.AñoTextBox.Location = new System.Drawing.Point(108, 198);
            this.AñoTextBox.Name = "AñoTextBox";
            this.AñoTextBox.Size = new System.Drawing.Size(128, 20);
            this.AñoTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Año:";
            // 
            // SemanaTextBox
            // 
            this.SemanaTextBox.Location = new System.Drawing.Point(108, 134);
            this.SemanaTextBox.Name = "SemanaTextBox";
            this.SemanaTextBox.Size = new System.Drawing.Size(128, 20);
            this.SemanaTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Semana:";
            // 
            // CitaTextBox
            // 
            this.CitaTextBox.Location = new System.Drawing.Point(247, 244);
            this.CitaTextBox.Name = "CitaTextBox";
            this.CitaTextBox.ReadOnly = true;
            this.CitaTextBox.Size = new System.Drawing.Size(128, 20);
            this.CitaTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cita:";
            // 
            // DiasTextBox
            // 
            this.DiasTextBox.Location = new System.Drawing.Point(108, 244);
            this.DiasTextBox.Name = "DiasTextBox";
            this.DiasTextBox.Size = new System.Drawing.Size(128, 20);
            this.DiasTextBox.TabIndex = 12;
            // 
            // DiasRestaTextBox
            // 
            this.DiasRestaTextBox.Location = new System.Drawing.Point(108, 289);
            this.DiasRestaTextBox.Name = "DiasRestaTextBox";
            this.DiasRestaTextBox.Size = new System.Drawing.Size(128, 20);
            this.DiasRestaTextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Restar:";
            // 
            // NuevaFechaTextBox
            // 
            this.NuevaFechaTextBox.Location = new System.Drawing.Point(247, 289);
            this.NuevaFechaTextBox.Name = "NuevaFechaTextBox";
            this.NuevaFechaTextBox.ReadOnly = true;
            this.NuevaFechaTextBox.Size = new System.Drawing.Size(239, 20);
            this.NuevaFechaTextBox.TabIndex = 15;
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 407);
            this.Controls.Add(this.NuevaFechaTextBox);
            this.Controls.Add(this.DiasRestaTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DiasTextBox);
            this.Controls.Add(this.CitaTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SemanaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AñoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MesTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DíaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EjecutarButton);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Name = "Ejercicio4";
            this.Text = "Ejercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Button EjecutarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DíaTextBox;
        private System.Windows.Forms.TextBox MesTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AñoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SemanaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CitaTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DiasTextBox;
        private System.Windows.Forms.TextBox DiasRestaTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NuevaFechaTextBox;
    }
}