using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using App.Entities;

namespace App.Data
{
    public class ArtistTXDistribuidaDA : BaseConection
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
               cn = new SqlConnection(base.ConnectionString))
            {
                /*2.- Creando Objeto command*/
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = cn;
                cn.Open(); //Abriendo conexion a la base de datos

                result = (int)cmd.ExecuteScalar();
            }

            return result;
        }

        public Artista Get(int id)
        {
            var result = new Artista();
            var sql = "Select * from Artist where ArtistId = @paramID";
                    //$"Select * from Artist where ArtistId = {id}  <-- hazlo y te hackean :D"

            using (IDbConnection cn = new SqlConnection(this.ConnectionString))
            {
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = cn;
                cn.Open();

                /*Configuracion los parametros <-- anti hack xd*/
                cmd.Parameters.Add(
                    new SqlParameter("@paramID", id)
                    );

                var reader = cmd.ExecuteReader();
                var indice = 0;
                while (reader.Read())
                {
                    var artist = new Artista();
                    indice = reader.GetOrdinal("ArtistId");
                    result.ArtistId = reader.GetInt32(indice);

                    indice = reader.GetOrdinal("Name");
                    result.Name = reader.GetString(indice);
                }

            }
                return result;
        }

        public List<Artista> GetAllSP(string filterByName = "")
        {
            var result = new List<Artista>();
            var sql = "usp_GetAll";

            using (IDbConnection cn = new SqlConnection(this.ConnectionString))
            {
                IDbCommand cmd = new SqlCommand(sql);
                /*Indicar que ahora es un procedimiento almacenado*/
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cn.Open();

                //Este es el string interpolation
                filterByName = $"%{filterByName}%";

                cmd.Parameters.Add(
                    new SqlParameter("@filterByName", filterByName));

                var reader = cmd.ExecuteReader();
                var indice = 0;
                while (reader.Read())
                {
                    var artist = new Artista();
                    indice = reader.GetOrdinal("ArtistId");
                    artist.ArtistId = reader.GetInt32(indice);

                    indice = reader.GetOrdinal("Name");
                    artist.Name = reader.GetString(indice);

                    result.Add(artist);
                }
            }
            return result;
        }/*Para hacer paso a paso pon punto rojo y en la cosa de prueba dar depurar*/

        public int Insert(Artista entity)
        {
            var result = 0;

            using (var trx = new TransactionScope())
            {
                try
                {
      
                    using (IDbConnection cn = new SqlConnection(this.ConnectionString))
                    {
                        cn.Open();

                        IDbCommand cmd = new SqlCommand("usp_InsertArtist");
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(

                            new SqlParameter("@pName", entity.Name)
                            );


                        result = Convert.ToInt32(cmd.ExecuteScalar());

                        //Generando una excepcion
                        //throw new Exception("Error");

                    }
                    //confirma la ransaccion
                    trx.Complete();
                }
                catch (Exception ex)
                {

                }
            }

            
            return result;
        }

        public int Update(Artista entity)
        {
            var result = 0;

                using (var trx = new TransactionScope())
                {
                    try
                    {
                        using (IDbConnection cn = new SqlConnection(this.ConnectionString))
                        {
                            cn.Open();

                        IDbCommand cmd = new SqlCommand("usp_UpdateArtist");
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(

                            new SqlParameter("@pName", entity.Name)
                            );
                        cmd.Parameters.Add(

                            new SqlParameter("@pId", entity.ArtistId)
                            );

                        result = cmd.ExecuteNonQuery();
                        }

                        trx.Complete();
                    }
                    catch (Exception ex)
                    {


                    }
                }
            return result;
        }

        public int Delete(int id)
        {
            var result = 0;
            using (var trx = new TransactionScope())
            {
                try
                {
                    using (IDbConnection cn = new SqlConnection(this.ConnectionString))
                    {
                        cn.Open();

                        IDbCommand cmd = new SqlCommand("usp_DeleteArtist");
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(

                            new SqlParameter("@pId", id)
                            );

                        result = cmd.ExecuteNonQuery();

                    }

                    trx.Complete();
                }
                catch (Exception)
                {

                }
            }
            return result;
        }
    }

}
