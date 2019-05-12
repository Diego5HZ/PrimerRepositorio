using System;
using App.Data.DataAccess;
using App.Entities.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App.Data.Access.Test
{
    [TestClass]
    public class CustomerDAUnitTest
    {
        [TestMethod]
        public void GetAll()
        {
            var da = new CustomerDA();

            var lista = da.GetAll("");

            Assert.IsTrue(lista.Count > 0);
        }

        [TestMethod]
        public void Get()
        {
            var da = new CustomerDA();

            var entity = da.Get(60);

            Assert.IsTrue(entity.CustomerId > 0);
        }

        [TestMethod]
        public void Insert()
        {
            var da = new CustomerDA();

            var entity = new Customer();
            entity.FirstName = "Costumer";
            entity.LastName = "Test";
            entity.Email = "123@hotmail.com";

            var id = da.Insert(entity);

            Assert.IsTrue(id > 0);
        }

        [TestMethod]
        public void Update()
        {
            var da = new CustomerDA();

            var entity = new Customer();
            entity.CustomerId = 63;
            entity.FirstName = "Franco";
            entity.LastName = "Devp";
            entity.Email = "Franco@eso.com";

            var result = da.Update(entity);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Delete()
        {
            var da = new CustomerDA();

            var result = da.Delete(63);

            Assert.IsTrue(result);
        }
    }
}
