namespace ToDoList
{
    partial class FrmDetalles
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
            this.DGVDet = new System.Windows.Forms.DataGridView();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmdSalir = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDet)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVDet
            // 
            this.DGVDet.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVDet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNombre,
            this.CTarea,
            this.CDescripcion,
            this.CHora,
            this.CFecha,
            this.CStatus});
            this.DGVDet.Location = new System.Drawing.Point(11, 51);
            this.DGVDet.Name = "DGVDet";
            this.DGVDet.ReadOnly = true;
            this.DGVDet.Size = new System.Drawing.Size(741, 150);
            this.DGVDet.TabIndex = 1;
            // 
            // CNombre
            // 
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            // 
            // CTarea
            // 
            this.CTarea.HeaderText = "Tarea";
            this.CTarea.Name = "CTarea";
            // 
            // CDescripcion
            // 
            this.CDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CDescripcion.HeaderText = "Descripcion";
            this.CDescripcion.Name = "CDescripcion";
            // 
            // CHora
            // 
            this.CHora.HeaderText = "Hora";
            this.CHora.Name = "CHora";
            // 
            // CFecha
            // 
            this.CFecha.HeaderText = "Fecha";
            this.CFecha.Name = "CFecha";
            // 
            // CStatus
            // 
            this.CStatus.HeaderText = "Status";
            this.CStatus.Name = "CStatus";
            // 
            // CmdSalir
            // 
            this.CmdSalir.Location = new System.Drawing.Point(333, 218);
            this.CmdSalir.Name = "CmdSalir";
            this.CmdSalir.Size = new System.Drawing.Size(75, 23);
            this.CmdSalir.TabIndex = 2;
            this.CmdSalir.Text = "Salir";
            this.CmdSalir.UseSelectable = true;
            this.CmdSalir.Click += new System.EventHandler(this.CmdSalir_Click);
            // 
            // FrmDetalles
            // 
            this.AcceptButton = this.CmdSalir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 264);
            this.Controls.Add(this.CmdSalir);
            this.Controls.Add(this.DGVDet);
            this.Name = "FrmDetalles";
            this.Text = "Detalles";
            ((System.ComponentModel.ISupportInitialize)(this.DGVDet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DGVDet;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStatus;
        private MetroFramework.Controls.MetroButton CmdSalir;
    }
}