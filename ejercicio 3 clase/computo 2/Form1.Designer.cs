
namespace computo_2
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
            this.suma = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.TextBox();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Numero1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resta = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // suma
            // 
            this.suma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.suma.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.suma.Location = new System.Drawing.Point(505, 32);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(75, 23);
            this.suma.TabIndex = 0;
            this.suma.Text = "Suma";
            this.suma.UseVisualStyleBackColor = false;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // Num1
            // 
            this.Num1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Num1.Location = new System.Drawing.Point(326, 32);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(100, 20);
            this.Num1.TabIndex = 1;
            this.Num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Num2
            // 
            this.Num2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Num2.Location = new System.Drawing.Point(326, 75);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(100, 20);
            this.Num2.TabIndex = 2;
            this.Num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Location = new System.Drawing.Point(337, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Resultado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numero 2";
            // 
            // Numero1
            // 
            this.Numero1.AutoSize = true;
            this.Numero1.Location = new System.Drawing.Point(252, 32);
            this.Numero1.Name = "Numero1";
            this.Numero1.Size = new System.Drawing.Size(53, 13);
            this.Numero1.TabIndex = 6;
            this.Numero1.Text = "Numero 1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::computo_2.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(2, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 187);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // resta
            // 
            this.resta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.resta.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.resta.Location = new System.Drawing.Point(505, 82);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(75, 23);
            this.resta.TabIndex = 12;
            this.resta.Text = "Resta";
            this.resta.UseVisualStyleBackColor = false;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // multi
            // 
            this.multi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.multi.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.multi.Location = new System.Drawing.Point(505, 139);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(91, 23);
            this.multi.TabIndex = 13;
            this.multi.Text = "Multiplicacion";
            this.multi.UseVisualStyleBackColor = false;
            this.multi.Click += new System.EventHandler(this.multi_Click);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.division.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.division.Location = new System.Drawing.Point(505, 203);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(75, 23);
            this.division.TabIndex = 14;
            this.division.Text = "Division";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Numero1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.suma);
            this.Name = "Form1";
            this.Text = "Operaciones Basicas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.TextBox Num1;
        private System.Windows.Forms.TextBox Num2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Numero1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button division;
    }
}

