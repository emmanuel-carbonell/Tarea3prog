using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tarea3prog.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Tarea3prog.Models
{
       public class ManejoArchivo
        {
          
            private static ManejoArchivo instance = null;
            public static ManejoArchivo GetInstance
            {
                get
                {
                    if (instance == null)
                        instance = new ManejoArchivo();
                    return instance;
                }
            }
        private ManejoArchivo()
            {
                
            }
            public void Guardar(Empleado data)
            {
            data.Id = Guid.NewGuid();

            var listaEmpleados = new List<Empleado>();

            listaEmpleados.Add(data);

            string jsonString = JsonSerializer.Serialize(listaEmpleados);



            using (StreamWriter writer = new StreamWriter("ListaEmp"))
            {
                writer.WriteLine(jsonString);
            }
            }
        }

    


        
}



