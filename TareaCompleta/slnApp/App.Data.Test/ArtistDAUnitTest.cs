using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Entities;
using App.Data;


//Para activar el tester das click arriba en prueba; luego, ventanas; finalmente explorador de pruebas
namespace App.Data.Test
{
    [TestClass]
    public class ArtistDAUnitTest
    {
        [TestMethod]
        public void Count()
        {
            var da = new ArtistDA();

            Assert.IsTrue(da.GetCount()>0);
        }

        [TestMethod]
        public void GetAllSP()
        {
            var da = new ArtistDA();
            var listado = da.GetAllSP("Aerosmith");

            Assert.IsTrue(listado.Count > 0);
        }

        [TestMethod]
        public void Get()
        {
            var da = new ArtistDA();
            var entity = da.Get(10);

            Assert.IsTrue(entity.ArtistId >0);
        }
        [TestMethod]
        public void InsertSP()
        {
            var da = new ArtistDA();
            var artist = new Artista();
            artist.Name = "Aero---";
            var id = da.Insert(artist);

            Assert.IsTrue(id > 0,"El nombre del Artista ya existe");
        }
        [TestMethod]
        public void UpdateSP()
        {
            var da = new ArtistDA();
            var artist = new Artista();
            artist.Name = "BillT";
            artist.ArtistId = 276;
            var registrosAfectados = da.Update(artist);

            Assert.IsTrue(registrosAfectados > 0, "El nombre del Artista ya existe");
        }
        [TestMethod]
        public void DeleteSP()
        {
            var da = new ArtistDA();
            var artistaborrado = da.Delete(279);

            Assert.IsTrue(artistaborrado > 0);
        }
    }
    //Acuerdate hay validacion de repeticion, todos los nombres de artistas tienen q ser diferentes
    //si quiera por un caracter
}
