using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRepaso1
{
    class clsReporte
    {
        string nombreEmpleado;
        int mes;
        decimal sueldoMes;

        
        public int Mes { get => mes; set => mes = value; }
        public decimal SueldoMes { get => sueldoMes; set => sueldoMes = value; }
        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }
    }
}
