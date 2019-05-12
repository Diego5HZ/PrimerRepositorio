using System;
using App.Data.DataAccess;
using App.Entities.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App.Data.Access.Test
{
    [TestClass]
    public class ArtistDAUnitTest
    {
        [TestMethod]
        public void GetAll()
        {
            var da = new ArtistDA();

            var lista = da.GetAll("");

            Assert.IsTrue(lista.Count > 0);
        }

        [TestMethod]
        public void Get()
        {
            var da = new ArtistDA();

            var entity = da.Get(1);

            Assert.IsTrue(entity.ArtistId > 0);
        }

        [TestMethod]
        public void Insert()
        {
            var da = new ArtistDA();

            var entity = new Artist();
            entity.Name = "Artista Test";

            var id = da.Insert(entity);

            Assert.IsTrue(id > 0);
        }

        [TestMethod]
        public void Update()
        {
            var da = new ArtistDA();

            var entity = new Artist();
            entity.ArtistId = 1;
            entity.Name = "Artista Update Test";

            var id = da.Insert(entity);

            var result = da.Update(entity);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Delete()
        {
            var da = new ArtistDA();

            //Agregando u registro
            var entity = new Artist();
            entity.Name = "Artista Test";
            var id = da.Insert(entity);

            //Eliminando registro
            var result = da.Delete(id);

            Assert.IsTrue(result);
        }
    }
}
