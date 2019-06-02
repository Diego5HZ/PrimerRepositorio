using App.Entities.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Access
{
    public class AlumnoEntityFramework
    {
        public List<Alumno> GetAll(string nombre)
        {
            var result = new List<Alumno>();
            using (var db = new DBModel())
            {
                result = db.Alumno
                    .Where(item => item.Nombres.Contains(nombre))
                    .OrderBy(item => item.Nombres)
                    .ToList();
            }

            return result;
        }
    }
}
