namespace ToDoList
{
    partial class FrmEditar
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TxtETar = new MetroFramework.Controls.MetroTextBox();
            this.Txtedit = new MetroFramework.Controls.MetroTextBox();
            this.CmdAceptar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(153, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Tarea a cambiar el status";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 121);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(85, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Nuevo Status";
            // 
            // TxtETar
            // 
            // 
            // 
            // 
            this.TxtETar.CustomButton.Image = null;
            this.TxtETar.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.TxtETar.CustomButton.Name = "";
            this.TxtETar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtETar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtETar.CustomButton.TabIndex = 1;
            this.TxtETar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtETar.CustomButton.UseSelectable = true;
            this.TxtETar.CustomButton.Visible = false;
            this.TxtETar.Lines = new string[0];
            this.TxtETar.Location = new System.Drawing.Point(195, 76);
            this.TxtETar.MaxLength = 32767;
            this.TxtETar.Name = "TxtETar";
            this.TxtETar.PasswordChar = '\0';
            this.TxtETar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtETar.SelectedText = "";
            this.TxtETar.SelectionLength = 0;
            this.TxtETar.SelectionStart = 0;
            this.TxtETar.ShortcutsEnabled = true;
            this.TxtETar.Size = new System.Drawing.Size(75, 23);
            this.TxtETar.TabIndex = 2;
            this.TxtETar.UseSelectable = true;
            this.TxtETar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtETar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Txtedit
            // 
            // 
            // 
            // 
            this.Txtedit.CustomButton.Image = null;
            this.Txtedit.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.Txtedit.CustomButton.Name = "";
            this.Txtedit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txtedit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txtedit.CustomButton.TabIndex = 1;
            this.Txtedit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txtedit.CustomButton.UseSelectable = true;
            this.Txtedit.CustomButton.Visible = false;
            this.Txtedit.Lines = new string[0];
            this.Txtedit.Location = new System.Drawing.Point(195, 117);
            this.Txtedit.MaxLength = 32767;
            this.Txtedit.Name = "Txtedit";
            this.Txtedit.PasswordChar = '\0';
            this.Txtedit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txtedit.SelectedText = "";
            this.Txtedit.SelectionLength = 0;
            this.Txtedit.SelectionStart = 0;
            this.Txtedit.ShortcutsEnabled = true;
            this.Txtedit.Size = new System.Drawing.Size(75, 23);
            this.Txtedit.TabIndex = 3;
            this.Txtedit.UseSelectable = true;
            this.Txtedit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txtedit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CmdAceptar
            // 
            this.CmdAceptar.Location = new System.Drawing.Point(135, 159);
            this.CmdAceptar.Name = "CmdAceptar";
            this.CmdAceptar.Size = new System.Drawing.Size(75, 23);
            this.CmdAceptar.TabIndex = 4;
            this.CmdAceptar.Text = "Aceptar";
            this.CmdAceptar.UseSelectable = true;
            this.CmdAceptar.Click += new System.EventHandler(this.CmdAceptar_Click);
            // 
            // FrmEditar
            // 
            this.AcceptButton = this.CmdAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 205);
            this.Controls.Add(this.CmdAceptar);
            this.Controls.Add(this.Txtedit);
            this.Controls.Add(this.TxtETar);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FrmEditar";
            this.Text = "Editar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroTextBox TxtETar;
        //Hacemos publico el txt para que se pueda usar en dif forms
        public MetroFramework.Controls.MetroTextBox Txtedit;
        private MetroFramework.Controls.MetroButton CmdAceptar;
    }
}