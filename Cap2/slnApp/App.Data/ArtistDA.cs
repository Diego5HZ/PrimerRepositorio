using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class ArtistDA:BaseConection
    {
        public int GetCount()
        {
            //Permite obtener la cantidad de registros
            ////que existe en la tabla de artista
            //<return>Retorna el numero de registro
            var result = 0;
            var sql = "SELECT COUNT(1) FROM Artist";
            /*1.- Creando la instancia del objeto
             conection*/
            using (IDbConnection
               cn = new SqlConnection(base.ConnecteionString))
            {
                /*2.- Creando Objeto command*/
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = cn;
                cn.Open(); //Abriendo conexion a la base de datos

                result = (int)cmd.ExecuteScalar();
            }

            return result;
        }
    }
}
