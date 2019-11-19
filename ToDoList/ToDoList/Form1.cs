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
    public partial class FrmTodoList : MetroFramework.Forms.MetroForm
    {
        //Declaramos globalmente la lista 
        public List<DatosTarea> DatosTar = new List<DatosTarea>();
        DatosTarea DaT = new DatosTarea();

        public FrmTodoList()
        {
            InitializeComponent();
        }

        private void MBAdd_Click(object sender, EventArgs e)
        {
            //mandamos a llamar al metodo para que el boton este limpio
            Guardar();

        }

        //en este metodo mandamos a llamar a a forma para que el usuario ingrese los datos de la tarea
        public void Guardar()
        {   
            FrmAgregar Ag = new FrmAgregar();
            Ag.ShowDialog();
            //Le pedimos al usuario que ingrese los datos de la tarea
            DaT.Nombre = Ag.TxtNombre.Text;
            DaT.Tarea = Ag.Txttarea.Text;
            DaT.Descripcion = Ag.TxtDescrip.Text;
            DaT.Hora = Ag.Txthora.Text;
            DaT.Fecha = Convert.ToDateTime(Ag.TxtFecha.Text);
            DaT.Status = Ag.TxtStatus.Text;

            DatosTar.Add(DaT);
            int Columna1 = DGVList.Rows.Add();
            //Agregamos al datagrid los datos de la lista
            DGVList.Rows[Columna1].Cells[0].Value = DaT.Nombre;
            DGVList.Rows[Columna1].Cells[1].Value = DaT.Tarea;
            DGVList.Rows[Columna1].Cells[2].Value = DaT.Descripcion;
            DGVList.Rows[Columna1].Cells[3].Value = DaT.Hora;
            DGVList.Rows[Columna1].Cells[4].Value = DaT.Fecha;
            DGVList.Rows[Columna1].Cells[5].Value = DaT.Status;

            DGVList.DataSource = null;
        }


        private void TxtEditar_Click(object sender, EventArgs e)
        {//Solo mandamos a llamar al metodo para que el boton este limpio
            Editarstatus();
        }
        //En este metodo mandamos a llamar a la forma para que el usuario pueda elegir a que tarea le quiere 
        //Editar el Status
        public void Editarstatus()
        {
            FrmEditar Edit = new FrmEditar();
            Edit.ShowDialog();
            DatosTarea DaT = new DatosTarea();
            //hacemos un foreach para que revise en todo el datagridview
            foreach (DataGridViewRow row in DGVList.Rows)
            {
                //hacemos un if para que el usuario eliga la tarea que quiere editar el status
                if (Edit.TxtETar.Text == Convert.ToString(row.Cells[1].Value))
                {
                    DGVList.Rows[row.Index].Cells[5].Value = Edit.Txtedit.Text;
                    break;
                }

            }

        }

        private void TxtDetalle_Click(object sender, EventArgs e)
        {//mandamos a llamar al metodo para que el boton este limpio y tener un codigo mas limpio
            Detalle();
        } 
        //hacemos un metodo donde se llama a otra forma donde se ve todos los detalles de todas las tareas
        public void Detalle()
        {
            FrmDetalles Det = new FrmDetalles();
            DatosTarea DaT = new DatosTarea();

            //hacemos un foreach para que todo en el datagrid se vea en la lista con detalles
            foreach (DataGridViewRow row in DGVList.Rows)
            {
                Det.DGVDet.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value, row.Cells[5].Value);
                

            }
            //Llamamos a la forma para que se manifieste y aparezca en el progama y el usuario pueda verlo
            Det.ShowDialog();
        }

        //hacemos un boton para que el usuario salga del progama
        private void CmdSalida_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por usar mi progama","Aviso");
            Close();
        }

        //hacemos un boton para que el usuario pueda limpiar el datagrid 
        private void CmdLimpiar_Click(object sender, EventArgs e)
        {
            DGVList.Rows.Clear();

           DGVList.Refresh();
        }
    }
}
