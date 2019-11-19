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
    public partial class FrmAgregar : MetroFramework.Forms.MetroForm
    {
        public FrmAgregar()
        {
            InitializeComponent();

        }
       

        private void cmdacep_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los datos Fueron guardados exitosamente","Aviso");

            Close();

        }
    }
}
