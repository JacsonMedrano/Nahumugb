
namespace Empleados
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
            this.components = new System.ComponentModel.Container();
            this.btGuardar = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDui = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textDUI = new System.Windows.Forms.TextBox();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.labelRegistr = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btAFP = new System.Windows.Forms.Button();
            this.textAFP = new System.Windows.Forms.TextBox();
            this.textSalario = new System.Windows.Forms.TextBox();
            this.labelSalario = new System.Windows.Forms.Label();
            this.btISSS = new System.Windows.Forms.Button();
            this.textISSS = new System.Windows.Forms.TextBox();
            this.btNeto = new System.Windows.Forms.Button();
            this.textSalarioNeto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(179, 402);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 0;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click_1);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelID.ForeColor = System.Drawing.Color.Black;
            this.labelID.Location = new System.Drawing.Point(116, 98);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(20, 15);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNombre.Location = new System.Drawing.Point(116, 179);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(46, 15);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDui
            // 
            this.labelDui.AutoSize = true;
            this.labelDui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelDui.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDui.Location = new System.Drawing.Point(116, 254);
            this.labelDui.Name = "labelDui";
            this.labelDui.Size = new System.Drawing.Size(25, 15);
            this.labelDui.TabIndex = 3;
            this.labelDui.Text = "Dui";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(279, 98);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 4;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(279, 179);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 5;
            // 
            // textDUI
            // 
            this.textDUI.Location = new System.Drawing.Point(279, 254);
            this.textDUI.Name = "textDUI";
            this.textDUI.Size = new System.Drawing.Size(100, 20);
            this.textDUI.TabIndex = 6;
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Location = new System.Drawing.Point(208, 312);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(0, 13);
            this.labelRegistro.TabIndex = 7;
            // 
            // labelRegistr
            // 
            this.labelRegistr.AutoSize = true;
            this.labelRegistr.Location = new System.Drawing.Point(596, 350);
            this.labelRegistr.Name = "labelRegistr";
            this.labelRegistr.Size = new System.Drawing.Size(46, 13);
            this.labelRegistr.TabIndex = 8;
            this.labelRegistr.Text = "Registro";
            this.labelRegistr.Click += new System.EventHandler(this.labelRegistr_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btAFP
            // 
            this.btAFP.Location = new System.Drawing.Point(493, 121);
            this.btAFP.Name = "btAFP";
            this.btAFP.Size = new System.Drawing.Size(75, 23);
            this.btAFP.TabIndex = 9;
            this.btAFP.Text = "AFP";
            this.btAFP.UseVisualStyleBackColor = true;
            this.btAFP.Click += new System.EventHandler(this.btAFP_Click);
            // 
            // textAFP
            // 
            this.textAFP.Location = new System.Drawing.Point(638, 121);
            this.textAFP.Name = "textAFP";
            this.textAFP.Size = new System.Drawing.Size(100, 20);
            this.textAFP.TabIndex = 10;
            this.textAFP.TextChanged += new System.EventHandler(this.textAFP_TextChanged);
            // 
            // textSalario
            // 
            this.textSalario.Location = new System.Drawing.Point(279, 319);
            this.textSalario.Name = "textSalario";
            this.textSalario.Size = new System.Drawing.Size(100, 20);
            this.textSalario.TabIndex = 11;
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelSalario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSalario.Location = new System.Drawing.Point(116, 319);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(41, 15);
            this.labelSalario.TabIndex = 12;
            this.labelSalario.Text = "Salario";
            // 
            // btISSS
            // 
            this.btISSS.Location = new System.Drawing.Point(493, 194);
            this.btISSS.Name = "btISSS";
            this.btISSS.Size = new System.Drawing.Size(75, 23);
            this.btISSS.TabIndex = 13;
            this.btISSS.Text = "ISSS";
            this.btISSS.UseVisualStyleBackColor = true;
            this.btISSS.Click += new System.EventHandler(this.btISSS_Click);
            // 
            // textISSS
            // 
            this.textISSS.Location = new System.Drawing.Point(638, 194);
            this.textISSS.Name = "textISSS";
            this.textISSS.Size = new System.Drawing.Size(100, 20);
            this.textISSS.TabIndex = 14;
            // 
            // btNeto
            // 
            this.btNeto.Location = new System.Drawing.Point(493, 276);
            this.btNeto.Name = "btNeto";
            this.btNeto.Size = new System.Drawing.Size(75, 23);
            this.btNeto.TabIndex = 15;
            this.btNeto.Text = "SalarioNeto";
            this.btNeto.UseVisualStyleBackColor = true;
            this.btNeto.Click += new System.EventHandler(this.btNeto_Click);
            // 
            // textSalarioNeto
            // 
            this.textSalarioNeto.Location = new System.Drawing.Point(638, 276);
            this.textSalarioNeto.Name = "textSalarioNeto";
            this.textSalarioNeto.Size = new System.Drawing.Size(100, 20);
            this.textSalarioNeto.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textSalarioNeto);
            this.Controls.Add(this.btNeto);
            this.Controls.Add(this.textISSS);
            this.Controls.Add(this.btISSS);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.textSalario);
            this.Controls.Add(this.textAFP);
            this.Controls.Add(this.btAFP);
            this.Controls.Add(this.labelRegistr);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.textDUI);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.labelDui);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.btGuardar);
            this.Name = "Form1";
            this.Text = "Registro Formulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDui;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textDUI;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.Label labelRegistr;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.TextBox textSalario;
        private System.Windows.Forms.TextBox textAFP;
        private System.Windows.Forms.Button btAFP;
        private System.Windows.Forms.TextBox textISSS;
        private System.Windows.Forms.Button btISSS;
        private System.Windows.Forms.TextBox textSalarioNeto;
        private System.Windows.Forms.Button btNeto;
    }
}

