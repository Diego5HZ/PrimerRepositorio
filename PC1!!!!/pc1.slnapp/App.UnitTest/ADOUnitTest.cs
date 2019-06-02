using System;
using App.Data.Access;
using App.Entities.ADO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App.UnitTest
{
    [TestClass]
    public class ADOUnitTest
    {
        [TestMethod]
        public void Insert()
        {
            var da = new AlumnosADO();
            var alumno = new Alumno();
            alumno.Nombres = "leo";
            alumno.Apellidos = "sanchez";
            alumno.Direccion = "Av. Los INgenieros";
            alumno.Sexo = "M";
            alumno.FechaNacimiento = DateTime.Now;
            var id = da.Insert_Alumno(alumno);

            Assert.IsTrue(id > 0, "El nombre del Album ya existe");
        }
        [TestMethod]
        public void GetAll()
        {
            var da = new AlumnosADO();
            var alumno = da.GetAll("Juan");

            Assert.IsTrue(alumno.Count > 0);
        }
    }
}
