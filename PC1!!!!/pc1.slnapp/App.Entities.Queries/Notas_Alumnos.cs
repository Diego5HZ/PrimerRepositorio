using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities.Queries
{
    public class Notas_Alumnos
    {
        public int AlumnoID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Grado { get; set; }
        public string Nivel { get; set; }
        public int Nota { get; set; }

    }
}
