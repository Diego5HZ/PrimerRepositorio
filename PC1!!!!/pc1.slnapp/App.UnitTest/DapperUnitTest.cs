using System;
using App.Data.Access;
using App.Entities.Dapper;
using App.Entities.Queries;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App.UnitTest
{
    [TestClass]
    public class DAPPERUnitTest
    {
        [TestMethod]
        public void InsertSP()
        {
            var da = new NotasDapper();
            var nota = new Notas();
            nota.AlumnoID = 6;
            nota.CursoID = 1;
            nota.Nota = 20;

            var id = da.Insert(nota);

            Assert.IsTrue(id > 0);
        }

        [TestMethod]
        public void ConsultarNotas()
        {
            var da = new NotasAlumnos();
            var listado = da.ConsultarNotas("Informatica","Primaria");

            Assert.IsTrue(listado.Count > 0);
        }

    }
}
