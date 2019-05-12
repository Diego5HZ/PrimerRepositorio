using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Entities;
using App.Data;


//Para activar el tester das click arriba en prueba; luego, ventanas; finalmente explorador de pruebas
namespace App.Data.Test
{
    [TestClass]
    public class ArtistTXDistribuidaDAUnitTest
    {
        [TestMethod]
        public void Count()
        {
            var da = new ArtistTXDistribuidaDA();

            Assert.IsTrue(da.GetCount()>0);
        }

        [TestMethod]
        public void GetAllSP()
        {
            var da = new ArtistTXDistribuidaDA();
            var listado = da.GetAllSP("Aerosmith");

            Assert.IsTrue(listado.Count > 0);
        }

        [TestMethod]
        public void Get()
        {
            var da = new ArtistTXDistribuidaDA();
            var entity = da.Get(10);

            Assert.IsTrue(entity.ArtistId >0);
        }
        [TestMethod]
        public void InsertSP()
        {
            var da = new ArtistTXDistribuidaDA();
            var artist = new Artista();
            artist.Name = "AeroT-234269";
            var id = da.Insert(artist);

            Assert.IsTrue(id > 0,"El nombre del Artista ya existe");
        }
        [TestMethod]
        public void UpdateSP()
        {
            var da = new ArtistTXDistribuidaDA();
            var artist = new Artista();
            artist.Name = "Youpooo";
            artist.ArtistId = 276;
            var registrosAfectados = da.Update(artist);

            Assert.IsTrue(registrosAfectados > 0, "El nombre del Artista ya existe");
        }
        [TestMethod]
        public void DeleteSP()
        {
            var da = new ArtistTXDistribuidaDA();
            var artistaborrado = da.Delete(283);

            Assert.IsTrue(artistaborrado > 0);
        }
    }
}
