using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Entities;
using App.Data;


//Para activar el tester das click arriba en prueba; luego, ventanas; finalmente explorador de pruebas
namespace App.Data.Test
{
    [TestClass]
    public class AlbumDapperUnitTest
    {
        [TestMethod]
        public void Get()
        {
            var da = new AlbumDapperDA();
            var entity = da.Get(8);

            Assert.IsTrue(entity.AlbumId > 0);
        }

        [TestMethod]
        public void GetAllSP()
        {
            var da = new AlbumDapperDA();
            var listado = da.GetAllSP("Mozart: Chamber Music");

            Assert.IsTrue(listado.Count > 0);
        }

        [TestMethod]
        public void InsertSP()
        {
            var da = new AlbumDapperDA();
            var album = new Album();
            album.Title = "PARACHUTeeE";
            album.ArtistId = 280;
            var id = da.Insert(album);

            Assert.IsTrue(id > 0, "El nombre del Album ya existe");
        }

        [TestMethod]
        public void UpdateSP()
        {
            var da = new AlbumDapperDA();
            var album = new Album();
            album.Title = "Origin";
            album.AlbumId = 5;
            var registrosAfectados = da.Update(album);

            Assert.IsTrue(registrosAfectados > 0, "El nombre del Album ya existe");
        }

        [TestMethod]
        public void DeleteSP()
        {
            var da = new AlbumDapperDA();
            var albumborrado = da.Delete(351);

            Assert.IsTrue(albumborrado > 0);
        }
    }
}
