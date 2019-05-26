using App.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace App.Data
{
    public class AlbumDA:BaseConection
    {
        public Album Get(int id)
        {
            var result = new Album();
            var sql = "usp_GetAlbum";

            using (IDbConnection cn = new SqlConnection
                (base.ConnectionString))
            {
                IDbCommand cmd = new SqlCommand(sql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cn.Open();

                cmd.Parameters.Add(
                    new SqlParameter("@paramID", id)
                    );

                var reader = cmd.ExecuteReader();
                var indice = 0;
                while (reader.Read())
                {
                    var album = new Album();
                    indice = reader.GetOrdinal("AlbumId");
                    result.AlbumId = reader.GetInt32(indice);

                    indice = reader.GetOrdinal("Title");
                    result.Title = reader.GetString(indice);

                }
            }

            return result;
        }

        public List<Album> GetAll(string filterByName = "")
        {
            var result = new List<Album>();
            var sql = "usp_GetAll_Album";

            using (IDbConnection cn = new SqlConnection(this.ConnectionString))
            {
                IDbCommand cmd = new SqlCommand(sql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cn.Open();

                filterByName = $"%{filterByName}%";

                cmd.Parameters.Add(
                    new SqlParameter("@filterByName", filterByName));

                var reader = cmd.ExecuteReader();
                var indice = 0;
                while (reader.Read())
                {
                    var album = new Album();
                    indice = reader.GetOrdinal("AlbumId");
                    album.AlbumId = reader.GetInt32(indice);

                    indice = reader.GetOrdinal("Title");
                    album.Title = reader.GetString(indice);

                    result.Add(album);
                }
            }

            return result;
        }

        public int Insert(Album entity)
        {
            var result = 0;
            var sql = "Insert_Album";

            using (IDbConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();

                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(
                    new SqlParameter("@pName", entity.Title));
                cmd.Parameters.Add(
                    new SqlParameter("@pArtistId", entity.ArtistId));

                result = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return result;
        }

        public int Update(Album entity)
        {
            var result = 0;

            using (IDbConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();

                IDbCommand cmd = new SqlCommand("usp_UpdateAlbum");
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(
                    new SqlParameter("@pName", entity.Title));
                cmd.Parameters.Add(
                    new SqlParameter("@pId", entity.AlbumId ));

                result = cmd.ExecuteNonQuery();
            }

            return result;
        } 
    }
}
