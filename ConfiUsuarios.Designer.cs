namespace ProyectoCine
{
    partial class ConfiUsuarios
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
            this.Seleccionar = new System.Windows.Forms.Button();
            this.Eliminar_Usuario = new System.Windows.Forms.Button();
            this.Editar_Usuario = new System.Windows.Forms.Button();
            this.Agregar_Usuario = new System.Windows.Forms.Button();
            this.Inicio = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Seleccionar
            // 
            this.Seleccionar.AutoSize = true;
            this.Seleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.Seleccionar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Seleccionar.FlatAppearance.BorderSize = 0;
            this.Seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seleccionar.ForeColor = System.Drawing.Color.Gainsboro;
            this.Seleccionar.Location = new System.Drawing.Point(752, 568);
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Seleccionar.Size = new System.Drawing.Size(250, 45);
            this.Seleccionar.TabIndex = 14;
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.UseVisualStyleBackColor = false;
            this.Seleccionar.Visible = false;
            this.Seleccionar.Click += new System.EventHandler(this.Seleccionar_Click);
            // 
            // Eliminar_Usuario
            // 
            this.Eliminar_Usuario.AutoSize = true;
            this.Eliminar_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.Eliminar_Usuario.FlatAppearance.BorderSize = 0;
            this.Eliminar_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar_Usuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.Eliminar_Usuario.Location = new System.Drawing.Point(8, 231);
            this.Eliminar_Usuario.Name = "Eliminar_Usuario";
            this.Eliminar_Usuario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Eliminar_Usuario.Size = new System.Drawing.Size(215, 45);
            this.Eliminar_Usuario.TabIndex = 13;
            this.Eliminar_Usuario.Text = "Eliminar Usuario";
            this.Eliminar_Usuario.UseVisualStyleBackColor = false;
            this.Eliminar_Usuario.Click += new System.EventHandler(this.Eliminar_Usuario_Click);
            // 
            // Editar_Usuario
            // 
            this.Editar_Usuario.AutoSize = true;
            this.Editar_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.Editar_Usuario.FlatAppearance.BorderSize = 0;
            this.Editar_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editar_Usuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.Editar_Usuario.Location = new System.Drawing.Point(8, 168);
            this.Editar_Usuario.Name = "Editar_Usuario";
            this.Editar_Usuario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Editar_Usuario.Size = new System.Drawing.Size(215, 45);
            this.Editar_Usuario.TabIndex = 12;
            this.Editar_Usuario.Text = "Editar Usuario";
            this.Editar_Usuario.UseVisualStyleBackColor = false;
            this.Editar_Usuario.Click += new System.EventHandler(this.Editar_Usuario_Click);
            // 
            // Agregar_Usuario
            // 
            this.Agregar_Usuario.AutoSize = true;
            this.Agregar_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.Agregar_Usuario.FlatAppearance.BorderSize = 0;
            this.Agregar_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregar_Usuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.Agregar_Usuario.Location = new System.Drawing.Point(8, 104);
            this.Agregar_Usuario.Name = "Agregar_Usuario";
            this.Agregar_Usuario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Agregar_Usuario.Size = new System.Drawing.Size(215, 45);
            this.Agregar_Usuario.TabIndex = 11;
            this.Agregar_Usuario.Text = "Agregar Usuario";
            this.Agregar_Usuario.UseVisualStyleBackColor = false;
            this.Agregar_Usuario.Click += new System.EventHandler(this.Agregar_Usuario_Click);
            // 
            // Inicio
            // 
            this.Inicio.AutoSize = true;
            this.Inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.Inicio.FlatAppearance.BorderSize = 0;
            this.Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inicio.ForeColor = System.Drawing.Color.Gainsboro;
            this.Inicio.Location = new System.Drawing.Point(8, 40);
            this.Inicio.Name = "Inicio";
            this.Inicio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Inicio.Size = new System.Drawing.Size(215, 45);
            this.Inicio.TabIndex = 10;
            this.Inicio.Text = "Inicio";
            this.Inicio.UseVisualStyleBackColor = false;
            this.Inicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CI,
            this.Nombre,
            this.Apellidos,
            this.Celular,
            this.Correo,
            this.Departamento,
            this.Sexo});
            this.dataGridView1.Location = new System.Drawing.Point(229, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(773, 508);
            this.dataGridView1.TabIndex = 9;
            // 
            // CI
            // 
            this.CI.HeaderText = "CI";
            this.CI.MinimumWidth = 6;
            this.CI.Name = "CI";
            this.CI.Width = 65;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 110;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.MinimumWidth = 6;
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Width = 130;
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.MinimumWidth = 6;
            this.Celular.Name = "Celular";
            this.Celular.Width = 110;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.Width = 110;
            // 
            // Departamento
            // 
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.MinimumWidth = 6;
            this.Departamento.Name = "Departamento";
            this.Departamento.Width = 125;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.MinimumWidth = 6;
            this.Sexo.Name = "Sexo";
            this.Sexo.Width = 70;
            // 
            // ConfiUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1014, 651);
            this.Controls.Add(this.Seleccionar);
            this.Controls.Add(this.Eliminar_Usuario);
            this.Controls.Add(this.Editar_Usuario);
            this.Controls.Add(this.Agregar_Usuario);
            this.Controls.Add(this.Inicio);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConfiUsuarios";
            this.Text = "ConfiUsuarios";
            this.Load += new System.EventHandler(this.ConfiUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Seleccionar;
        private System.Windows.Forms.Button Eliminar_Usuario;
        private System.Windows.Forms.Button Editar_Usuario;
        private System.Windows.Forms.Button Agregar_Usuario;
        private System.Windows.Forms.Button Inicio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
    }
}