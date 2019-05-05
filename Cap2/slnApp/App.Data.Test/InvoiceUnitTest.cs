using System;
using System.Collections.Generic;
using App.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App.Data.Test
{
    [TestClass]
    public class InvoiceUnitTest
    {
        [TestMethod]
        public void InsertTXLocal()
        {
            var invoiceDA = new InvoiceDA();

            var invoice = new Invoice();
            invoice.CustomerId = 60;
            invoice.BillingCountry = "Peru";
            invoice.BillingAddress = "Av Los Alamos";
            invoice.BillingCity = "Lima";
            invoice.BillingPostalCode = "Lima32";
            invoice.BillingState = "Lima";
            invoice.InvoiceDate = DateTime.Now;
            invoice.Total = 300;

            //Agregando los detalles
            invoice.InvoiceLine = new List<InvoiceLine>();
            //-------- 1 ----------
            invoice.InvoiceLine.Add(
                new InvoiceLine()
                {
                    TrackId = 10,
                    Quantity = 20,
                    UnitPrice = 60
                }
                );
            //-------- 2 ----------
            invoice.InvoiceLine.Add(
                new InvoiceLine()
                {
                    TrackId = 8,
                    Quantity = 40,
                    UnitPrice = 50
                }
                );

            var id = invoiceDA.InsertarTXLocal(invoice);

            Assert.IsTrue(id > 0);
        }

        [TestMethod]
        public void InsertTXDist()
        {
            var invoiceDA = new InvoiceDA();

            var invoice = new Invoice();
            invoice.CustomerId = 60;
            invoice.BillingCountry = "Peru";
            invoice.BillingAddress = "Av Los Alamos";
            invoice.BillingCity = "Lima";
            invoice.BillingPostalCode = "Lima32";
            invoice.BillingState = "Lima";
            invoice.InvoiceDate = DateTime.Now;
            invoice.Total = 300;

            //Agregando los detalles
            invoice.InvoiceLine = new List<InvoiceLine>();
            //-------- 1 ----------
            invoice.InvoiceLine.Add(
                new InvoiceLine()
                {
                    TrackId = 10,
                    Quantity = 20,
                    UnitPrice = 60
                }
                );
            //-------- 2 ----------
            invoice.InvoiceLine.Add(
                new InvoiceLine()
                {
                    TrackId = 8,
                    Quantity = 40,
                    UnitPrice = 50
                }
                );

            var id = invoiceDA.InsertarTXLocal(invoice);

            Assert.IsTrue(id > 0);
        }
    }
}
