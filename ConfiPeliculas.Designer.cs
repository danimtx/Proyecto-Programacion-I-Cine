namespace ProyectoCine
{
    partial class ConfiPeliculas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duración = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Protagonista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inicio = new System.Windows.Forms.Button();
            this.Agregar_Pelicula = new System.Windows.Forms.Button();
            this.Editar_Pelicula = new System.Windows.Forms.Button();
            this.Eliminar_Pelicula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Genero,
            this.Duración,
            this.Protagonista,
            this.Director,
            this.Precio});
            this.dataGridView1.Location = new System.Drawing.Point(202, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 551);
            this.dataGridView1.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 70;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 179;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.MinimumWidth = 6;
            this.Genero.Name = "Genero";
            this.Genero.Width = 115;
            // 
            // Duración
            // 
            this.Duración.HeaderText = "Duración";
            this.Duración.MinimumWidth = 6;
            this.Duración.Name = "Duración";
            this.Duración.Width = 70;
            // 
            // Protagonista
            // 
            this.Protagonista.HeaderText = "Protagonista";
            this.Protagonista.MinimumWidth = 6;
            this.Protagonista.Name = "Protagonista";
            this.Protagonista.Width = 125;
            // 
            // Director
            // 
            this.Director.HeaderText = "Director";
            this.Director.MinimumWidth = 6;
            this.Director.Name = "Director";
            this.Director.Width = 130;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 57;
            // 
            // Inicio
            // 
            this.Inicio.AutoSize = true;
            this.Inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.Inicio.FlatAppearance.BorderSize = 0;
            this.Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inicio.ForeColor = System.Drawing.Color.Gainsboro;
            this.Inicio.Location = new System.Drawing.Point(3, 68);
            this.Inicio.Name = "Inicio";
            this.Inicio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Inicio.Size = new System.Drawing.Size(193, 45);
            this.Inicio.TabIndex = 4;
            this.Inicio.Text = "Inicio";
            this.Inicio.UseVisualStyleBackColor = false;
            this.Inicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // Agregar_Pelicula
            // 
            this.Agregar_Pelicula.AutoSize = true;
            this.Agregar_Pelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.Agregar_Pelicula.FlatAppearance.BorderSize = 0;
            this.Agregar_Pelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregar_Pelicula.ForeColor = System.Drawing.Color.Gainsboro;
            this.Agregar_Pelicula.Location = new System.Drawing.Point(3, 132);
            this.Agregar_Pelicula.Name = "Agregar_Pelicula";
            this.Agregar_Pelicula.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Agregar_Pelicula.Size = new System.Drawing.Size(193, 45);
            this.Agregar_Pelicula.TabIndex = 5;
            this.Agregar_Pelicula.Text = "Agregar Película";
            this.Agregar_Pelicula.UseVisualStyleBackColor = false;
            this.Agregar_Pelicula.Click += new System.EventHandler(this.Agregar_Pelicula_Click);
            // 
            // Editar_Pelicula
            // 
            this.Editar_Pelicula.AutoSize = true;
            this.Editar_Pelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.Editar_Pelicula.FlatAppearance.BorderSize = 0;
            this.Editar_Pelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editar_Pelicula.ForeColor = System.Drawing.Color.Gainsboro;
            this.Editar_Pelicula.Location = new System.Drawing.Point(3, 196);
            this.Editar_Pelicula.Name = "Editar_Pelicula";
            this.Editar_Pelicula.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Editar_Pelicula.Size = new System.Drawing.Size(193, 45);
            this.Editar_Pelicula.TabIndex = 6;
            this.Editar_Pelicula.Text = "Editar Película";
            this.Editar_Pelicula.UseVisualStyleBackColor = false;
            this.Editar_Pelicula.Click += new System.EventHandler(this.Editar_Pelicula_Click);
            // 
            // Eliminar_Pelicula
            // 
            this.Eliminar_Pelicula.AutoSize = true;
            this.Eliminar_Pelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.Eliminar_Pelicula.FlatAppearance.BorderSize = 0;
            this.Eliminar_Pelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar_Pelicula.ForeColor = System.Drawing.Color.Gainsboro;
            this.Eliminar_Pelicula.Location = new System.Drawing.Point(3, 259);
            this.Eliminar_Pelicula.Name = "Eliminar_Pelicula";
            this.Eliminar_Pelicula.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Eliminar_Pelicula.Size = new System.Drawing.Size(193, 45);
            this.Eliminar_Pelicula.TabIndex = 7;
            this.Eliminar_Pelicula.Text = "Eliminar Película";
            this.Eliminar_Pelicula.UseVisualStyleBackColor = false;
            this.Eliminar_Pelicula.Click += new System.EventHandler(this.Eliminar_Pelicula_Click);
            // 
            // ConfiPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1014, 651);
            this.Controls.Add(this.Eliminar_Pelicula);
            this.Controls.Add(this.Editar_Pelicula);
            this.Controls.Add(this.Agregar_Pelicula);
            this.Controls.Add(this.Inicio);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConfiPeliculas";
            this.Text = "ConfiPeliculas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Inicio;
        private System.Windows.Forms.Button Agregar_Pelicula;
        private System.Windows.Forms.Button Editar_Pelicula;
        private System.Windows.Forms.Button Eliminar_Pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duración;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protagonista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Director;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}