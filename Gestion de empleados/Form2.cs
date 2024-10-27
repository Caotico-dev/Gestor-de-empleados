using Gestion_de_empleados_.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_empleados_
{
    public partial class DepartamentoDeProyectos : Form
    {
        private readonly FormInicio FormInicio;
        private GestorEmpleadosContext GestorEmpleadosContext;
        public DepartamentoDeProyectos(FormInicio formInicio, GestorEmpleadosContext gestorEmpleadosContext)
        {
            InitializeComponent();

            FormInicio = formInicio;

            this.GestorEmpleadosContext = gestorEmpleadosContext;
        }

        private void DepartamentoDeProyectos_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormInicio.Show();
        }

        private void DepartamentoDeProyectos_Load(object sender, EventArgs e)
        {

            //Cargar base de datos
            this.GestorEmpleadosContext.Departamentos.Load();
            this.GestorEmpleadosContext.Proyectos.Load();

            //Conexion del datagridview
            dataGridViewdep.DataSource = this.GestorEmpleadosContext.Departamentos.Local.ToBindingList();
            dataGridViewpr.DataSource = this.GestorEmpleadosContext.Proyectos.Local.ToBindingList();

        }

        private void dataGridViewpr_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.GestorEmpleadosContext != null)
                {
                    var Proyecto = (Proyecto)this.dataGridViewpr.CurrentRow.DataBoundItem;

                    if (Proyecto != null)
                    {
                        this.GestorEmpleadosContext.Entry(Proyecto).Collection(e => e.Departamentos!).Load();
                    }
                }
                else
                {
                    MessageBox.Show("Seleciona un campos con valor");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleciona un campos con valor");
            }
        }
        private void BuscarPro()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(box_proyecto.Text))
                {
                    var proyecto = this.GestorEmpleadosContext.Proyectos.ToList();
                    //Mostrar producto en datagridview
                    dataGridViewpr.DataSource = proyecto;
                    box_proyecto.Text = null;

                }
                else
                {
                    string nombre = box_proyecto.Text.Trim().ToLower();
                    //buscar el nombre en la base de datos
                    var busqueda = this.GestorEmpleadosContext.Proyectos.Where(p => p.Nombre.ToLower().Contains(nombre)).ToList();
                    //Confirmacion de datos
                    if (busqueda != null)
                    {
                        dataGridViewpr.DataSource = busqueda;
                    }
                    else
                    {
                        MessageBox.Show("Proyecto no encontrado.");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Recuerda rellenar todos los campos correctamente");
                box_proyecto.Text = null;
            }
        }
        private void BuscarDpt()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(BoxDpt.Text))
                {
                    var departamentos = this.GestorEmpleadosContext.Departamentos.ToList();
                    //Mostrar producto en datagridview
                    dataGridViewdep.DataSource = departamentos;
                    BoxDpt.Text = null;

                }
                else
                {
                    string nombre = BoxDpt.Text.Trim().ToLower();
                    //buscar el nombre en la base de datos
                    var busqueda = this.GestorEmpleadosContext.Departamentos.Where(p => p.Nombre.ToLower().Contains(nombre)).ToList();
                    //Confirmacion de datos
                    if (busqueda != null)
                    {
                        dataGridViewdep.DataSource = busqueda;
                    }
                    else
                    {
                        MessageBox.Show("Departamento no encontrado.");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Recuerda rellenar todos los campos correctamente");
                BoxDpt.Text = null;
            }


        }
        private void buscardept_Click(object sender, EventArgs e)
        {
            BuscarDpt();
        }

        private void btn_buscardescripcion_Click(object sender, EventArgs e)
        {
            BuscarPro();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //Guarda cambios
            try
            {
                this.GestorEmpleadosContext.SaveChanges();
                dataGridViewdep.Refresh();
                dataGridViewpr.Refresh();
                MessageBox.Show("Registro guardado correctamente.");
            }
            catch
            {
                MessageBox.Show("Recuerda rellenar todos los campos correctamente.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewdep.Refresh();
            dataGridViewpr.Refresh();
        }
    }
}
