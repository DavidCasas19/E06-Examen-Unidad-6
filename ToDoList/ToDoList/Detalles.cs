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
    public partial class FrmDetalles : MetroFramework.Forms.MetroForm
    {
        public FrmDetalles()
        {
            InitializeComponent();
        }

        //un boton para que el usuario salga de la forma
        private void CmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
