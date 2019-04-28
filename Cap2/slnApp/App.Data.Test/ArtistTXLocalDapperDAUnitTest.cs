using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Entities;


//Para activar el tester das click arriba en prueba; luego, ventanas; finalmente explorador de pruebas
namespace App.Data.Test
{
    [TestClass]
    public class ArtistTXLocalDapperDAUnitTest
    {
        [TestMethod]
        public void Count()
        {
            var da = new ArtistTXLocalDapperDA();

            Assert.IsTrue(da.GetCount()>0);
        }

        [TestMethod]
        public void GetAllSP()
        {
            var da = new ArtistTXLocalDapperDA();
            var listado = da.GetAllSP("Aerosmith");

            Assert.IsTrue(listado.Count > 0);
        }

        [TestMethod]
        public void Get()
        {
            var da = new ArtistTXLocalDapperDA();
            var entity = da.Get(8);

            Assert.IsTrue(entity.ArtistId >0);
        }
        [TestMethod]
        public void InsertSP()
        {
            var da = new ArtistTXLocalDapperDA();
            var artist = new Artista();
            artist.Name = "AeroT-2666669";
            var id = da.Insert(artist);

            Assert.IsTrue(id > 0,"El nombre del Artista ya existe");
        }
        [TestMethod]
        public void UpdateSP()
        {
            var da = new ArtistTXLocalDapperDA();
            var artist = new Artista();
            artist.Name = "Nel";
            artist.ArtistId = 284;
            var registrosAfectados = da.Update(artist);

            Assert.IsTrue(registrosAfectados > 0, "El nombre del Artista ya existe");
        }
        [TestMethod]
        public void DeleteSP()
        {
            var da = new ArtistTXLocalDA();
            var artistaborrado = da.Delete(284);

            Assert.IsTrue(artistaborrado > 0);
        }
    }
}
