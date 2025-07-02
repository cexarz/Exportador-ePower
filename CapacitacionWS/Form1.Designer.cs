using System;
using System.Windows.Forms;

namespace CapacitacionWS
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

    
        private void InitializeComponent()
        {
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dtgAplicaciones = new System.Windows.Forms.DataGridView();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgTipoDocumental = new System.Windows.Forms.DataGridView();
            this.IdTipoDocumental = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTipoDocumental = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescTipoDocumental = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.dtgConsultas = new System.Windows.Forms.DataGridView();
            this.IdConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dtgResultados = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.Resultados = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAplicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoDocumental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultados)).BeginInit();
            this.Resultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(53, 12);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(250, 12);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(53, 38);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(4, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(43, 13);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Usuario";
            this.Label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(250, 38);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dtgAplicaciones
            // 
            this.dtgAplicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAplicaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificador,
            this.Nombre,
            this.Descripcion});
            this.dtgAplicaciones.Location = new System.Drawing.Point(7, 82);
            this.dtgAplicaciones.Name = "dtgAplicaciones";
            this.dtgAplicaciones.Size = new System.Drawing.Size(343, 115);
            this.dtgAplicaciones.TabIndex = 6;
            // 
            // Identificador
            // 
            this.Identificador.HeaderText = "Identificador";
            this.Identificador.Name = "Identificador";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Listar Aplicaciones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dtgTipoDocumental
            // 
            this.dtgTipoDocumental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTipoDocumental.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTipoDocumental,
            this.NombreTipoDocumental,
            this.DescTipoDocumental});
            this.dtgTipoDocumental.Location = new System.Drawing.Point(7, 221);
            this.dtgTipoDocumental.Name = "dtgTipoDocumental";
            this.dtgTipoDocumental.Size = new System.Drawing.Size(343, 162);
            this.dtgTipoDocumental.TabIndex = 8;
            // 
            // IdTipoDocumental
            // 
            this.IdTipoDocumental.HeaderText = "IdTipoDocumental";
            this.IdTipoDocumental.Name = "IdTipoDocumental";
            // 
            // NombreTipoDocumental
            // 
            this.NombreTipoDocumental.HeaderText = "NombreTipoDocumental";
            this.NombreTipoDocumental.Name = "NombreTipoDocumental";
            // 
            // DescTipoDocumental
            // 
            this.DescTipoDocumental.HeaderText = "DescTipoDocumental";
            this.DescTipoDocumental.Name = "DescTipoDocumental";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Listar Tipos Documentales";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtgConsultas
            // 
            this.dtgConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdConsulta,
            this.NombreConsulta,
            this.DescConsulta});
            this.dtgConsultas.Location = new System.Drawing.Point(7, 401);
            this.dtgConsultas.Name = "dtgConsultas";
            this.dtgConsultas.Size = new System.Drawing.Size(343, 168);
            this.dtgConsultas.TabIndex = 10;
            // 
            // IdConsulta
            // 
            this.IdConsulta.HeaderText = "IdConsulta";
            this.IdConsulta.Name = "IdConsulta";
            // 
            // NombreConsulta
            // 
            this.NombreConsulta.HeaderText = "NombreConsulta";
            this.NombreConsulta.Name = "NombreConsulta";
            // 
            // DescConsulta
            // 
            this.DescConsulta.HeaderText = "DescConsulta";
            this.DescConsulta.Name = "DescConsulta";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(356, 481);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Listar Consultas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(574, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Ejecutar consulta";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dtgResultados
            // 
            this.dtgResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultados.Location = new System.Drawing.Point(37, 33);
            this.dtgResultados.Name = "dtgResultados";
            this.dtgResultados.Size = new System.Drawing.Size(531, 397);
            this.dtgResultados.TabIndex = 13;
            this.dtgResultados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgResultados_CellContentClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(574, 63);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Extraer Imagen";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(574, 92);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "Obtener Url Img";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(37, 446);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 16;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(493, 446);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 17;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // Resultados
            // 
            this.Resultados.Controls.Add(this.button5);
            this.Resultados.Controls.Add(this.btnSiguiente);
            this.Resultados.Controls.Add(this.button4);
            this.Resultados.Controls.Add(this.btnAtras);
            this.Resultados.Controls.Add(this.button6);
            this.Resultados.Controls.Add(this.dtgResultados);
            this.Resultados.Location = new System.Drawing.Point(585, 12);
            this.Resultados.Name = "Resultados";
            this.Resultados.Size = new System.Drawing.Size(673, 489);
            this.Resultados.TabIndex = 18;
            this.Resultados.TabStop = false;
            this.Resultados.Text = "Resultados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 572);
            this.Controls.Add(this.Resultados);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dtgConsultas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtgTipoDocumental);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgAplicaciones);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Name = "Form1";
            this.Text = "    ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAplicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoDocumental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultados)).EndInit();
            this.Resultados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dtgResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dtgAplicaciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridView dtgTipoDocumental;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoDocumental;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTipoDocumental;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescTipoDocumental;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtgConsultas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescConsulta;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dtgResultados;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnSiguiente;
        private GroupBox Resultados;
    }
}

