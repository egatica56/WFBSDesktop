namespace EscritorioWFBS
{
    partial class Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAbreviacion = new System.Windows.Forms.TextBox();
            this.dgvPerfil = new System.Windows.Forms.DataGridView();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abreviacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblComp = new System.Windows.Forms.Label();
            this.cbxCompetencias = new System.Windows.Forms.ComboBox();
            this.btnComp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Abreviacion";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(129, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(174, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtAbreviacion
            // 
            this.txtAbreviacion.Location = new System.Drawing.Point(129, 88);
            this.txtAbreviacion.Name = "txtAbreviacion";
            this.txtAbreviacion.Size = new System.Drawing.Size(174, 20);
            this.txtAbreviacion.TabIndex = 3;
            // 
            // dgvPerfil
            // 
            this.dgvPerfil.AllowUserToAddRows = false;
            this.dgvPerfil.AllowUserToDeleteRows = false;
            this.dgvPerfil.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPerfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerfil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificador,
            this.Nombre,
            this.Abreviacion,
            this.Estado});
            this.dgvPerfil.Location = new System.Drawing.Point(12, 310);
            this.dgvPerfil.Name = "dgvPerfil";
            this.dgvPerfil.Size = new System.Drawing.Size(343, 164);
            this.dgvPerfil.TabIndex = 4;
            this.dgvPerfil.Click += new System.EventHandler(this.dgvPerfil_Click);
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
            // Abreviacion
            // 
            this.Abreviacion.HeaderText = "Abreviacion";
            this.Abreviacion.Name = "Abreviacion";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // txtLimpiar
            // 
            this.txtLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtLimpiar.Location = new System.Drawing.Point(280, 229);
            this.txtLimpiar.Name = "txtLimpiar";
            this.txtLimpiar.Size = new System.Drawing.Size(75, 23);
            this.txtLimpiar.TabIndex = 15;
            this.txtLimpiar.Text = "Limpiar";
            this.txtLimpiar.UseVisualStyleBackColor = false;
            this.txtLimpiar.Click += new System.EventHandler(this.txtLimpiar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnModificar.Location = new System.Drawing.Point(45, 229);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgregar.Location = new System.Drawing.Point(159, 229);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Location = new System.Drawing.Point(46, 131);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(74, 13);
            this.lblComp.TabIndex = 16;
            this.lblComp.Text = "Competencias";
            // 
            // cbxCompetencias
            // 
            this.cbxCompetencias.FormattingEnabled = true;
            this.cbxCompetencias.Location = new System.Drawing.Point(129, 128);
            this.cbxCompetencias.Name = "cbxCompetencias";
            this.cbxCompetencias.Size = new System.Drawing.Size(121, 21);
            this.cbxCompetencias.TabIndex = 17;
            // 
            // btnComp
            // 
            this.btnComp.Location = new System.Drawing.Point(270, 128);
            this.btnComp.Name = "btnComp";
            this.btnComp.Size = new System.Drawing.Size(121, 23);
            this.btnComp.TabIndex = 18;
            this.btnComp.Text = "Asignar Competencia";
            this.btnComp.UseVisualStyleBackColor = true;
            this.btnComp.Click += new System.EventHandler(this.btnComp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Estado";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(129, 172);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(121, 21);
            this.cbxEstado.TabIndex = 20;
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(394, 496);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnComp);
            this.Controls.Add(this.cbxCompetencias);
            this.Controls.Add(this.lblComp);
            this.Controls.Add(this.txtLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvPerfil);
            this.Controls.Add(this.txtAbreviacion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Perfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtAbreviacion;
        private System.Windows.Forms.DataGridView dgvPerfil;
        private System.Windows.Forms.Button txtLimpiar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abreviacion;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.ComboBox cbxCompetencias;
        private System.Windows.Forms.Button btnComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxEstado;
    }
}