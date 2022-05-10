using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using System.Threading.Tasks;

namespace Tarea3prog.Models
{
    public class Empleado
    {
        public Guid Id { get; set; }

        public int Cedula { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }


        public string Email { get; set; }

        public int Telefono { get; set; }

        public string Departamento { get; set; }

        public string Cargo { get; set; }

        public CategoriaEmpleado CategoriaEmpleado { get; set; }

        public decimal Salario { get; set; }

        public void CalcularBono()
        {
            switch (CategoriaEmpleado)
            {
                case CategoriaEmpleado.Gerencial: Salario = Salario * 1.5M;
                    break;

                case CategoriaEmpleado.Administrativo: Salario = Salario * 1.25M;
                    break;

                case CategoriaEmpleado.Operativo: Salario = Salario * 1.10M;
                    break;

            }
        }
    





}
    }
