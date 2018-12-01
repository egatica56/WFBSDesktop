namespace EscritorioWFBS
{
    partial class Perfil_Competencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil_Competencia));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPerfil = new System.Windows.Forms.ComboBox();
            this.cbxCompetencia = new System.Windows.Forms.ComboBox();
            this.dgvPC = new System.Windows.Forms.DataGridView();
            this.IdPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCompetencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompetencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Perfil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Competencia";
            // 
            // cbxPerfil
            // 
            this.cbxPerfil.FormattingEnabled = true;
            this.cbxPerfil.Location = new System.Drawing.Point(191, 39);
            this.cbxPerfil.Name = "cbxPerfil";
            this.cbxPerfil.Size = new System.Drawing.Size(121, 21);
            this.cbxPerfil.TabIndex = 2;
            // 
            // cbxCompetencia
            // 
            this.cbxCompetencia.FormattingEnabled = true;
            this.cbxCompetencia.Location = new System.Drawing.Point(191, 81);
            this.cbxCompetencia.Name = "cbxCompetencia";
            this.cbxCompetencia.Size = new System.Drawing.Size(121, 21);
            this.cbxCompetencia.TabIndex = 3;
            // 
            // dgvPC
            // 
            this.dgvPC.AllowUserToAddRows = false;
            this.dgvPC.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPerfil,
            this.NombrePerfil,
            this.IdCompetencia,
            this.NombreCompetencia});
            this.dgvPC.Location = new System.Drawing.Point(31, 207);
            this.dgvPC.Name = "dgvPC";
            this.dgvPC.Size = new System.Drawing.Size(445, 150);
            this.dgvPC.TabIndex = 4;
            // 
            // IdPerfil
            // 
            this.IdPerfil.HeaderText = "IdPerfil";
            this.IdPerfil.Name = "IdPerfil";
            // 
            // NombrePerfil
            // 
            this.NombrePerfil.HeaderText = "NombrePerfil";
            this.NombrePerfil.Name = "NombrePerfil";
            // 
            // IdCompetencia
            // 
            this.IdCompetencia.HeaderText = "IdCompetencia";
            this.IdCompetencia.Name = "IdCompetencia";
            // 
            // NombreCompetencia
            // 
            this.NombreCompetencia.HeaderText = "NombreCompetencia";
            this.NombreCompetencia.Name = "NombreCompetencia";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEliminar.Location = new System.Drawing.Point(-190, 153);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 40;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgregar.Location = new System.Drawing.Point(50, 149);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 39;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Perfil_Competencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(508, 428);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvPC);
            this.Controls.Add(this.cbxCompetencia);
            this.Controls.Add(this.cbxPerfil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Perfil_Competencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil_Competencia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxPerfil;
        private System.Windows.Forms.ComboBox cbxCompetencia;
        private System.Windows.Forms.DataGridView dgvPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompetencia;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
    }
}