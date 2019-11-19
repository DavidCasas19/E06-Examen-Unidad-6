namespace ToDoList
{
    partial class FrmTodoList
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
            this.DGVList = new System.Windows.Forms.DataGridView();
            this.MBAdd = new MetroFramework.Controls.MetroButton();
            this.TxtDetalle = new MetroFramework.Controls.MetroButton();
            this.TxtEditar = new MetroFramework.Controls.MetroButton();
            this.CmdSalida = new MetroFramework.Controls.MetroButton();
            this.CmdLimpiar = new MetroFramework.Controls.MetroButton();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVList)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVList
            // 
            this.DGVList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNombre,
            this.CTarea,
            this.CDescripcion,
            this.CHora,
            this.CFecha,
            this.CStatus});
            this.DGVList.Location = new System.Drawing.Point(23, 63);
            this.DGVList.Name = "DGVList";
            this.DGVList.ReadOnly = true;
            this.DGVList.Size = new System.Drawing.Size(355, 150);
            this.DGVList.TabIndex = 0;
            // 
            // MBAdd
            // 
            this.MBAdd.Location = new System.Drawing.Point(428, 63);
            this.MBAdd.Name = "MBAdd";
            this.MBAdd.Size = new System.Drawing.Size(115, 62);
            this.MBAdd.TabIndex = 1;
            this.MBAdd.Text = "Agregar";
            this.MBAdd.UseSelectable = true;
            this.MBAdd.Click += new System.EventHandler(this.MBAdd_Click);
            // 
            // TxtDetalle
            // 
            this.TxtDetalle.Location = new System.Drawing.Point(428, 151);
            this.TxtDetalle.Name = "TxtDetalle";
            this.TxtDetalle.Size = new System.Drawing.Size(115, 62);
            this.TxtDetalle.TabIndex = 2;
            this.TxtDetalle.Text = "Detalles";
            this.TxtDetalle.UseSelectable = true;
            this.TxtDetalle.Click += new System.EventHandler(this.TxtDetalle_Click);
            // 
            // TxtEditar
            // 
            this.TxtEditar.Location = new System.Drawing.Point(23, 229);
            this.TxtEditar.Name = "TxtEditar";
            this.TxtEditar.Size = new System.Drawing.Size(115, 62);
            this.TxtEditar.TabIndex = 3;
            this.TxtEditar.Text = "Editar Status";
            this.TxtEditar.UseSelectable = true;
            this.TxtEditar.Click += new System.EventHandler(this.TxtEditar_Click);
            // 
            // CmdSalida
            // 
            this.CmdSalida.Location = new System.Drawing.Point(317, 229);
            this.CmdSalida.Name = "CmdSalida";
            this.CmdSalida.Size = new System.Drawing.Size(115, 62);
            this.CmdSalida.TabIndex = 4;
            this.CmdSalida.Text = "Salida";
            this.CmdSalida.UseSelectable = true;
            this.CmdSalida.Click += new System.EventHandler(this.CmdSalida_Click);
            // 
            // CmdLimpiar
            // 
            this.CmdLimpiar.Location = new System.Drawing.Point(170, 229);
            this.CmdLimpiar.Name = "CmdLimpiar";
            this.CmdLimpiar.Size = new System.Drawing.Size(115, 62);
            this.CmdLimpiar.TabIndex = 5;
            this.CmdLimpiar.Text = "Limpiar";
            this.CmdLimpiar.UseSelectable = true;
            this.CmdLimpiar.Click += new System.EventHandler(this.CmdLimpiar_Click);
            // 
            // CNombre
            // 
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            // 
            // CTarea
            // 
            this.CTarea.HeaderText = "Tarea";
            this.CTarea.Name = "CTarea";
            this.CTarea.ReadOnly = true;
            // 
            // CDescripcion
            // 
            this.CDescripcion.HeaderText = "Descripcion";
            this.CDescripcion.Name = "CDescripcion";
            this.CDescripcion.ReadOnly = true;
            this.CDescripcion.Visible = false;
            // 
            // CHora
            // 
            this.CHora.HeaderText = "Hora";
            this.CHora.Name = "CHora";
            this.CHora.ReadOnly = true;
            this.CHora.Visible = false;
            // 
            // CFecha
            // 
            this.CFecha.HeaderText = "Fecha";
            this.CFecha.Name = "CFecha";
            this.CFecha.ReadOnly = true;
            this.CFecha.Visible = false;
            // 
            // CStatus
            // 
            this.CStatus.HeaderText = "Status";
            this.CStatus.Name = "CStatus";
            this.CStatus.ReadOnly = true;
            // 
            // FrmTodoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 308);
            this.Controls.Add(this.CmdLimpiar);
            this.Controls.Add(this.CmdSalida);
            this.Controls.Add(this.TxtEditar);
            this.Controls.Add(this.TxtDetalle);
            this.Controls.Add(this.MBAdd);
            this.Controls.Add(this.DGVList);
            this.Name = "FrmTodoList";
            this.Text = "To do list";
            ((System.ComponentModel.ISupportInitialize)(this.DGVList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVList;
        private MetroFramework.Controls.MetroButton MBAdd;
        private MetroFramework.Controls.MetroButton TxtDetalle;
        private MetroFramework.Controls.MetroButton TxtEditar;
        private MetroFramework.Controls.MetroButton CmdSalida;
        private MetroFramework.Controls.MetroButton CmdLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStatus;
    }
}

