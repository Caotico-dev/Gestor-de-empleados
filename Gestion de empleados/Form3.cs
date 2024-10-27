using Gestion_de_empleados_.Models;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_empleados_
{
    public partial class FormInicio : Form
    {
        // Variables globales
        private int imagenActual = 0;
        private Image[] imagenes;
        private GestorEmpleadosContext GestorEmpleadosContext;

        public FormInicio()
        {
            InitializeComponent();
            //Imagen principal
            pictureBox.Image = Gestion_de_empleados_.Properties.Resources.imagen_3;

            // Inicializa el arreglo de imágenes desde los recursos
            imagenes = new Image[]
            {
              Gestion_de_empleados_.Properties.Resources.imagen_1,
              Gestion_de_empleados_.Properties.Resources.imagen_2,
              Gestion_de_empleados_.Properties.Resources.imagen_3
            };
           
            // Inicia el Timer cuando se cargue el formulario
            timer1.Interval = 7000; // 7 segundos
            timer1.Start();
            GestorEmpleadosContext = new GestorEmpleadosContext();
            Estadisticas();

        }  
               
        private void button1_Click(object sender, EventArgs e)
        {
            //crea new form
            FormGestion formGestion = new FormGestion(this, this.GestorEmpleadosContext);
            //Mostrar
            formGestion.Show();
            //ocultar
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Crear New Form
            DepartamentoDeProyectos departamentoDeProyectos = new DepartamentoDeProyectos(this, this.GestorEmpleadosContext);
            //Mostrar
            departamentoDeProyectos.Show();
            //ocultar
            this.Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Cambiar la imagen en el PictureBox
            pictureBox.Image = imagenes[imagenActual];

            // Incrementar el índice de la imagen actual y reiniciar si llega al final
            imagenActual++;
            if (imagenActual >= imagenes.Length)
            {
                imagenActual = 0; // Reinicia el índice
            }

        }
        private void Estadisticas()
        {
            
                //Cantidad de departamento
                int cantidadpt = this.GestorEmpleadosContext.Departamentos.Select( n => n.Nombre ).Distinct().Count();
                Cantidadpt.Text = cantidadpt.ToString();
                //Cantidad de proyecto
                var cantidapro = this.GestorEmpleadosContext.Proyectos.Count();
                Cantidapro.Text = cantidapro.ToString();
                //Cantida empleados
                int cantidactiva = this.GestorEmpleadosContext.Empleados.Where(e => e.Activo!.ToLower() == "si").Count();
                Cantidaemple.Text = cantidactiva.ToString();                       
                    
        }
        public void Acceso(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    Estadisticas(); 
                    break;  
                default:
                    MessageBox.Show("Opcion no encontrada");
                    break;
            }
        } 
        private void FormInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.GestorEmpleadosContext.Dispose();
            this.GestorEmpleadosContext = null!;
        }
    }
}
