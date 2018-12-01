namespace EscritorioWFBS
{
    partial class Observacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Observacion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSuperior = new System.Windows.Forms.TextBox();
            this.dgvObservacion = new System.Windows.Forms.DataGridView();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Competencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MensajeSuperior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MensajeInferior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtInferior = new System.Windows.Forms.TextBox();
            this.cbxCompetencia = new System.Windows.Forms.ComboBox();
            this.txtLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObservacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Competencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mensaje Superior";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mensaje Inferior";
            // 
            // txtSuperior
            // 
            this.txtSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSuperior.Location = new System.Drawing.Point(148, 66);
            this.txtSuperior.Multiline = true;
            this.txtSuperior.Name = "txtSuperior";
            this.txtSuperior.Size = new System.Drawing.Size(343, 72);
            this.txtSuperior.TabIndex = 3;
            // 
            // dgvObservacion
            // 
            this.dgvObservacion.AllowUserToAddRows = false;
            this.dgvObservacion.AllowUserToDeleteRows = false;
            this.dgvObservacion.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvObservacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObservacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificador,
            this.Competencia,
            this.MensajeSuperior,
            this.MensajeInferior,
            this.Estado});
            this.dgvObservacion.Location = new System.Drawing.Point(69, 330);
            this.dgvObservacion.Name = "dgvObservacion";
            this.dgvObservacion.Size = new System.Drawing.Size(370, 191);
            this.dgvObservacion.TabIndex = 4;
            this.dgvObservacion.Click += new System.EventHandler(this.dgvObservacion_Click);
            // 
            // Identificador
            // 
            this.Identificador.HeaderText = "Identificador";
            this.Identificador.Name = "Identificador";
            // 
            // Competencia
            // 
            this.Competencia.HeaderText = "Competencia";
            this.Competencia.Name = "Competencia";
            // 
            // MensajeSuperior
            // 
            this.MensajeSuperior.HeaderText = "MensajeSuperior";
            this.MensajeSuperior.Name = "MensajeSuperior";
            // 
            // MensajeInferior
            // 
            this.MensajeInferior.HeaderText = "MensajeInferior";
            this.MensajeInferior.Name = "MensajeInferior";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // txtInferior
            // 
            this.txtInferior.Location = new System.Drawing.Point(148, 170);
            this.txtInferior.Multiline = true;
            this.txtInferior.Name = "txtInferior";
            this.txtInferior.Size = new System.Drawing.Size(343, 80);
            this.txtInferior.TabIndex = 5;
            // 
            // cbxCompetencia
            // 
            this.cbxCompetencia.FormattingEnabled = true;
            this.cbxCompetencia.Location = new System.Drawing.Point(148, 30);
            this.cbxCompetencia.Name = "cbxCompetencia";
            this.cbxCompetencia.Size = new System.Drawing.Size(137, 21);
            this.cbxCompetencia.TabIndex = 6;
            // 
            // txtLimpiar
            // 
            this.txtLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtLimpiar.Location = new System.Drawing.Point(353, 279);
            this.txtLimpiar.Name = "txtLimpiar";
            this.txtLimpiar.Size = new System.Drawing.Size(75, 23);
            this.txtLimpiar.TabIndex = 14;
            this.txtLimpiar.Text = "Limpiar";
            this.txtLimpiar.UseVisualStyleBackColor = false;
            this.txtLimpiar.Click += new System.EventHandler(this.txtLimpiar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnModificar.Location = new System.Drawing.Point(69, 279);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgregar.Location = new System.Drawing.Point(201, 279);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Estado";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(353, 30);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(121, 21);
            this.cbxEstado.TabIndex = 16;
            // 
            // Observacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(531, 533);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbxCompetencia);
            this.Controls.Add(this.txtInferior);
            this.Controls.Add(this.dgvObservacion);
            this.Controls.Add(this.txtSuperior);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Observacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Observacion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvObservacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSuperior;
        private System.Windows.Forms.DataGridView dgvObservacion;
        private System.Windows.Forms.TextBox txtInferior;
        private System.Windows.Forms.ComboBox cbxCompetencia;
        private System.Windows.Forms.Button txtLimpiar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Competencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MensajeSuperior;
        private System.Windows.Forms.DataGridViewTextBoxColumn MensajeInferior;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}