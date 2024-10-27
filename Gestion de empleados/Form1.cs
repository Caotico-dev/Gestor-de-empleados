using Gestion_de_empleados_.Models;
using Microsoft.EntityFrameworkCore;

namespace Gestion_de_empleados_
{
    public partial class FormGestion : Form
    {
        private readonly FormInicio FormInicio;
        private GestorEmpleadosContext Context;
        public FormGestion(FormInicio formInicio, GestorEmpleadosContext gestorEmpleadosContext)
        {
            InitializeComponent();
            FormInicio = formInicio;
            this.Context = gestorEmpleadosContext;
        }

        private void FormGestion_Load(object sender, EventArgs e)
        {
            //Cargar la tabla
            this.Context.Empleados.Load();
            //Mostrar
            empleadoBindingSource.DataSource = this.Context.Empleados.Local.ToBindingList();

        }
        private void Eliminar()
        {

            try
            {
                int EmpleadoId = int.Parse(Box_Eliminar.Text);
                //Buscar en la base de datos
                var Empleado = this.Context.Empleados.Find(EmpleadoId);

                if (Empleado != null)
                {
                    this.Context.Empleados.Remove(Empleado!);
                    this.Context.SaveChanges();
                    MessageBox.Show("Registro borrado con exito!.");

                }
                else
                {
                    MessageBox.Show("Empleado no encontrado.");
                }
            }
            catch
            {
                MessageBox.Show("Recuerda rellenar el campo correctamente.");
            }

            Box_Eliminar.Text = null;

        }
        private void BuscarEmpleado()
        {
            try
            {
                int buscarempleado = int.Parse(Box_Eliminar.Text);
                //buscar empleado
                var empleado = this.Context.Empleados.Find(buscarempleado);
                if (empleado != null)
                {
                    empleadoBindingSource.DataSource = empleado;
                    MessageBox.Show("Registro encontrado, Recuerda reiniciar la pestaña para actualizar los registro.");
                }
                else
                {
                    MessageBox.Show("Registro no encontrado.");
                }
            }
            catch
            {
                MessageBox.Show("Recuerda rellenar los campos correctamente.");
            }
            Box_Eliminar.Text = null;
        }

        private void FormGestion_FormClosing(object sender, FormClosingEventArgs e)
        {
            //actualizar
            FormInicio.Acceso(1);
            //Mostrar
            FormInicio.Show();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            //Guarda cambios
            try
            {
                this.Context.SaveChanges();
                dataGridViewEmpleados.Refresh();
                MessageBox.Show("Registro guardado correctamente.");
            }
            catch
            {
                MessageBox.Show("Recuerda rellenar todos los campos correctamente.");
            }


        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarEmpleado();
        }

        private void dataGridViewEmpleados_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Recuerda poner un id que no este en uso.");
        }

        private void btn_buscardescripcion_Click(object sender, EventArgs e)
        {
            dataGridViewEmpleados.Refresh();
        }
    }
}
