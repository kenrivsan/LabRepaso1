using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LabRepaso1
{
    public partial class Form1 : Form
    {
        //cargar los empleados
        List<clsEmpleado> empleados = new List<clsEmpleado>();
        //cargar las asistencias
        List<clsAsistencia> asistencias = new List<clsAsistencia>();
        //
        List<clsReporte> reportes = new List<clsReporte>();

        
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void MostarEmpleados()
        {
            dtvEmpleados.DataSource = null;
            dtvEmpleados.DataSource = empleados;
            dtvEmpleados.Refresh();
        }
        private void MostarAsistencia()
        {
            dtvAsistencia.DataSource = null;
            dtvAsistencia.DataSource = asistencias;
            dtvAsistencia.Refresh();
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
            MostarEmpleados();
            CargarAsistencia();
            MostarAsistencia();
        }
        public void CargarAsistencia()
        {
            //Guardamos en una variable el nombre del archivo que abrimos
            string fileName = "Asistencia.txt";

            //Abrimos el archivo, en este caso lo abrimos para lectura
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                //clase
                clsAsistencia asistencia = new clsAsistencia();
                asistencia.NoEmpleado = Convert.ToInt16(reader.ReadLine());
                asistencia.HorasMes = Convert.ToInt32(reader.ReadLine());
                asistencia.Mes = Convert.ToInt32(reader.ReadLine());

                //Guadar en la lista
                asistencias.Add(asistencia);
            }
            reader.Close();
            //Mostrar a lista de empleados en el dgv
        }
        public void CargarEmpleados()
        {
            //Guardamos en una variable el nombre del archivo que abrimos
            string fileName = "Empleados.txt";

            //Abrimos el archivo, en este caso lo abrimos para lectura
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                //clase
                clsEmpleado empleado = new clsEmpleado();
                empleado.NoEmpleado = Convert.ToInt16(reader.ReadLine());
                empleado.Nombre = reader.ReadLine();
                empleado.SueldoHora = Convert.ToDecimal(reader.ReadLine());

                //Guadar en la lista
                empleados.Add(empleado);
            }
            reader.Close();
            //Mostrar a lista de empleados en el dgv
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            List<clsReporte> reportes = new List<clsReporte>();   
            foreach (clsEmpleado empleado in empleados)
            {
                foreach (clsAsistencia asistencia in asistencias)
                {
                    if (empleado.NoEmpleado == asistencia.NoEmpleado)
                    {
                        clsReporte reporte = new clsReporte();
                        reporte.NombreEmpleado = empleado.Nombre;
                        reporte.Mes = asistencia.Mes;
                        reporte.SueldoMes = empleado.SueldoHora * asistencia.HorasMes;
                        reportes.Add(reporte);

                    }
                }
            }
            dtvReportes.DataSource = null;
            dtvReportes.DataSource = reportes;
            dtvReportes.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.DataSource = empleados;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int noEmpleado =  Convert.ToInt16(comboBox1.SelectedValue);
            //for (int i = 0; i < empleados.Count ; i++)
            //{
            //    if (No)
            //    {

            //    }
            //}
            clsEmpleado empleadoEncontrado = empleados.Find(c => c.NoEmpleado == noEmpleado);
            label1.Text = empleadoEncontrado.Nombre;
        }
    }
}
