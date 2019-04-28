using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Entities;


//Para activar el tester das click arriba en prueba; luego, ventanas; finalmente explorador de pruebas
namespace App.Data.Test
{
    [TestClass]
    public class ArtistTXLocalDAUnitTest
    {
        [TestMethod]
        public void Count()
        {
            var da = new ArtistTXLocalDA();

            Assert.IsTrue(da.GetCount()>0);
        }

        [TestMethod]
        public void GetAllSP()
        {
            var da = new ArtistTXLocalDA();
            var listado = da.GetAllSP("Aerosmith");

            Assert.IsTrue(listado.Count > 0);
        }

        [TestMethod]
        public void Get()
        {
            var da = new ArtistTXLocalDA();
            var entity = da.Get(10);

            Assert.IsTrue(entity.ArtistId >0);
        }
        [TestMethod]
        public void InsertSP()
        {
            var da = new ArtistTXLocalDA();
            var artist = new Artista();
            artist.Name = "AeroT-269";
            var id = da.Insert(artist);

            Assert.IsTrue(id > 0,"El nombre del Artista ya existe");
        }
        [TestMethod]
        public void UpdateSP()
        {
            var da = new ArtistTXLocalDA();
            var artist = new Artista();
            artist.Name = "Youp";
            artist.ArtistId = 276;
            var registrosAfectados = da.Update(artist);

            Assert.IsTrue(registrosAfectados > 0, "El nombre del Artista ya existe");
        }
        [TestMethod]
        public void DeleteSP()
        {
            var da = new ArtistTXLocalDA();
            var artistaborrado = da.Delete(281);

            Assert.IsTrue(artistaborrado > 0);
        }
    }
}
