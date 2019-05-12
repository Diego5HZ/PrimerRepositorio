using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Entities;
using App.Data;


//Para activar el tester das click arriba en prueba; luego, ventanas; finalmente explorador de pruebas
namespace App.Data.Test
{
    [TestClass]
    public class GenreDapperDaUnitTest
    {
        [TestMethod]
        public void Get()
        {
            var da = new GenreDapperDA();
            var entity = da.Get(5);

            Assert.IsTrue(entity.GenreId > 0);
        }

        [TestMethod]
        public void GetAllSP()
        {
            var da = new GenreDapperDA();
            var listado = da.GetAllSP("Rock");

            Assert.IsTrue(listado.Count > 0);
        }

        [TestMethod]
        public void InsertSP()
        {
            var da = new GenreDapperDA();
            var genre = new Genre();
            genre.Name = "Hip-HOOP";
            var id = da.Insert(genre);

            Assert.IsTrue(id > 0, "El nombre del Genero ya existe");
        }

        [TestMethod]
        public void UpdateSP()
        {
            var da = new GenreDapperDA();
            var genre = new Genre();
            genre.Name = "Beat Box";
            genre.GenreId = 26;
            var registrosAfectados = da.Update(genre);

            Assert.IsTrue(registrosAfectados > 0, "El nombre del Genero ya existe");
        }

        [TestMethod]
        public void DeleteSP()
        {
            var da = new GenreDapperDA();
            var generoborrado = da.Delete(26);

            Assert.IsTrue(generoborrado > 0);
        }
    }
}
