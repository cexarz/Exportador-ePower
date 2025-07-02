using System;
using System.Windows.Forms;

namespace CapacitacionWS.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAplicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoDocumental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultados)).BeginInit();
            this.Resultados.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            resources.ApplyResources(this.txtUser, "txtUser");
            this.txtUser.Name = "txtUser";
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Name = "Label1";
            this.Label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnLogout
            // 
            resources.ApplyResources(this.btnLogout, "btnLogout");
            this.btnLogout.Name = "btnLogout";
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
            resources.ApplyResources(this.dtgAplicaciones, "dtgAplicaciones");
            this.dtgAplicaciones.Name = "dtgAplicaciones";
            // 
            // Identificador
            // 
            resources.ApplyResources(this.Identificador, "Identificador");
            this.Identificador.Name = "Identificador";
            // 
            // Nombre
            // 
            resources.ApplyResources(this.Nombre, "Nombre");
            this.Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            resources.ApplyResources(this.Descripcion, "Descripcion");
            this.Descripcion.Name = "Descripcion";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
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
            resources.ApplyResources(this.dtgTipoDocumental, "dtgTipoDocumental");
            this.dtgTipoDocumental.Name = "dtgTipoDocumental";
            // 
            // IdTipoDocumental
            // 
            resources.ApplyResources(this.IdTipoDocumental, "IdTipoDocumental");
            this.IdTipoDocumental.Name = "IdTipoDocumental";
            // 
            // NombreTipoDocumental
            // 
            resources.ApplyResources(this.NombreTipoDocumental, "NombreTipoDocumental");
            this.NombreTipoDocumental.Name = "NombreTipoDocumental";
            // 
            // DescTipoDocumental
            // 
            resources.ApplyResources(this.DescTipoDocumental, "DescTipoDocumental");
            this.DescTipoDocumental.Name = "DescTipoDocumental";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
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
            resources.ApplyResources(this.dtgConsultas, "dtgConsultas");
            this.dtgConsultas.Name = "dtgConsultas";
            // 
            // IdConsulta
            // 
            resources.ApplyResources(this.IdConsulta, "IdConsulta");
            this.IdConsulta.Name = "IdConsulta";
            // 
            // NombreConsulta
            // 
            resources.ApplyResources(this.NombreConsulta, "NombreConsulta");
            this.NombreConsulta.Name = "NombreConsulta";
            // 
            // DescConsulta
            // 
            resources.ApplyResources(this.DescConsulta, "DescConsulta");
            this.DescConsulta.Name = "DescConsulta";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dtgResultados
            // 
            this.dtgResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dtgResultados, "dtgResultados");
            this.dtgResultados.Name = "dtgResultados";
            this.dtgResultados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgResultados_CellContentClick);
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnAtras
            // 
            resources.ApplyResources(this.btnAtras, "btnAtras");
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSiguiente
            // 
            resources.ApplyResources(this.btnSiguiente, "btnSiguiente");
            this.btnSiguiente.Name = "btnSiguiente";
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
            resources.ApplyResources(this.Resultados, "Resultados");
            this.Resultados.Name = "Resultados";
            this.Resultados.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnLogout);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Resultados);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dtgConsultas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtgTipoDocumental);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgAplicaciones);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAplicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoDocumental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultados)).EndInit();
            this.Resultados.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private GroupBox groupBox1;
    }
}

