
namespace ejercicio_5_clase
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.operar = new System.Windows.Forms.Button();
            this.Resul = new System.Windows.Forms.Label();
            this.suma = new System.Windows.Forms.CheckBox();
            this.resta = new System.Windows.Forms.CheckBox();
            this.multi = new System.Windows.Forms.CheckBox();
            this.divi = new System.Windows.Forms.CheckBox();
            this.Num1 = new System.Windows.Forms.Label();
            this.Num2 = new System.Windows.Forms.Label();
            this.nume2 = new System.Windows.Forms.TextBox();
            this.nume1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // operar
            // 
            this.operar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.operar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.operar.ForeColor = System.Drawing.Color.Black;
            this.operar.Location = new System.Drawing.Point(448, 153);
            this.operar.Name = "operar";
            this.operar.Size = new System.Drawing.Size(75, 23);
            this.operar.TabIndex = 0;
            this.operar.Text = "Operar";
            this.operar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.operar.UseVisualStyleBackColor = false;
            this.operar.Click += new System.EventHandler(this.operar_Click);
            // 
            // Resul
            // 
            this.Resul.AutoSize = true;
            this.Resul.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Resul.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Resul.Location = new System.Drawing.Point(466, 217);
            this.Resul.Name = "Resul";
            this.Resul.Size = new System.Drawing.Size(60, 15);
            this.Resul.TabIndex = 2;
            this.Resul.Text = "Resultado:";
            // 
            // suma
            // 
            this.suma.AutoSize = true;
            this.suma.Location = new System.Drawing.Point(616, 49);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(53, 17);
            this.suma.TabIndex = 3;
            this.suma.Text = "Suma";
            this.suma.UseVisualStyleBackColor = true;
            // 
            // resta
            // 
            this.resta.AutoSize = true;
            this.resta.Location = new System.Drawing.Point(616, 101);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(54, 17);
            this.resta.TabIndex = 4;
            this.resta.Text = "Resta";
            this.resta.UseVisualStyleBackColor = true;
            // 
            // multi
            // 
            this.multi.AutoSize = true;
            this.multi.Location = new System.Drawing.Point(616, 159);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(90, 17);
            this.multi.TabIndex = 5;
            this.multi.Text = "Multiplicacion";
            this.multi.UseVisualStyleBackColor = true;
            // 
            // divi
            // 
            this.divi.AutoSize = true;
            this.divi.Location = new System.Drawing.Point(616, 217);
            this.divi.Name = "divi";
            this.divi.Size = new System.Drawing.Size(63, 17);
            this.divi.TabIndex = 6;
            this.divi.Text = "Division";
            this.divi.UseVisualStyleBackColor = true;
            this.divi.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // Num1
            // 
            this.Num1.AutoSize = true;
            this.Num1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Num1.Location = new System.Drawing.Point(372, 69);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(53, 13);
            this.Num1.TabIndex = 7;
            this.Num1.Text = "Numero 1";
            // 
            // Num2
            // 
            this.Num2.AutoSize = true;
            this.Num2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Num2.Location = new System.Drawing.Point(372, 108);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(53, 13);
            this.Num2.TabIndex = 8;
            this.Num2.Text = "Numero 2";
            // 
            // nume2
            // 
            this.nume2.Location = new System.Drawing.Point(434, 101);
            this.nume2.Name = "nume2";
            this.nume2.Size = new System.Drawing.Size(100, 20);
            this.nume2.TabIndex = 9;
            // 
            // nume1
            // 
            this.nume1.Location = new System.Drawing.Point(434, 62);
            this.nume1.Name = "nume1";
            this.nume1.Size = new System.Drawing.Size(100, 20);
            this.nume1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 452);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nume1);
            this.Controls.Add(this.nume2);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.divi);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.Resul);
            this.Controls.Add(this.operar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Aqua;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button operar;
        private System.Windows.Forms.Label Resul;
        private System.Windows.Forms.CheckBox suma;
        private System.Windows.Forms.CheckBox resta;
        private System.Windows.Forms.CheckBox multi;
        private System.Windows.Forms.CheckBox divi;
        private System.Windows.Forms.Label Num1;
        private System.Windows.Forms.Label Num2;
        private System.Windows.Forms.TextBox nume2;
        private System.Windows.Forms.TextBox nume1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

