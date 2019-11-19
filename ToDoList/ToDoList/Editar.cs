using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace ToDoList
{
    public partial class FrmEditar : MetroFramework.Forms.MetroForm
    {
        public FrmEditar()
        {
            InitializeComponent();
        }
     //un boton para dar a entender que es todo lo que el usuario quiere hacer
        private void CmdAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El Status a cambiado correctamente", "Aviso");
            Close();
        }
    }
}
