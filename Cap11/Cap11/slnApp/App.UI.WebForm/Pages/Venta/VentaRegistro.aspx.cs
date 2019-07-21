using App.Data.Repository;
using App.Data.Repository.Interface;
using App.Entities.Base;
using App.Entities.Queries;
using App.UI.WebForm.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace App.UI.WebForm.Pages.Venta
{
    public partial class VentaRegistro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadInit();
            }
        }

        private void LoadInit()
        {
            IAppUnitOfWork uw = new AppUnitOfWork();

            Helpers.ConfigurarCombo(ddlTrack, "Name", "TrackId", uw.TrackRepository.GetAll());
            uw.Dispose();

            SetDataGrid(ManageSession.SaleDetails);
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            var detail = new SaleDetail();
            var sales = ManageSession.SaleDetails;
            detail.TrackId = Convert.ToInt32(ddlTrack.SelectedValue);

            //Usando LINQ to objects para verificar que el producto no exista
            var trackfound = sales
                .Where(item => item.TrackId == detail.TrackId)
                .FirstOrDefault();

            if (trackfound!=null) //Significa que el track ya existe
            {
                litMensajeTrack.Text = "El track ya fue agregado :P" +
                    "";
                return; 
            }
            else
            {
                litMensajeTrack.Text = "Creado Exitosamente :D";
            }

            detail.TrackName = ddlTrack.SelectedItem.Text;
            detail.UnitPrice = Convert.ToDecimal(txtPrecio.Text);
            detail.Quantity = Convert.ToInt32(txtCantidad.Text);
            detail.Total = detail.UnitPrice * detail.Quantity;

            sales.Add(detail);

            //Actualizando el nuevo elemtno de la lista en la variable session
            ManageSession.SaleDetails = sales;

            //Mostrando la informacion en el data grid
            SetDataGrid(sales);
        }

        private void SetDataGrid(List<SaleDetail> sales)
        {
            grvPedido.DataSource = sales;
            grvPedido.DataBind();

        }

        protected void ddlTrack_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            SeleccionarTrack();
        }
        private void SeleccionarTrack()
        {
            var id = Convert.ToInt32(ddlTrack.SelectedItem.Value);
            IAppUnitOfWork uw = new AppUnitOfWork();
            var trackSeleccionado = uw.TrackRepository.GetById<int>(id);
            txtPrecio.Text = trackSeleccionado.UnitPrice.ToString();

            uw.Dispose();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            var invoice = new Invoice();
            invoice.CustomerId = 65;
            invoice.InvoiceDate = DateTime.Now;
            invoice.InvoiceLine = new List<InvoiceLine>();
            decimal invoiceTotal = 0;
            foreach (var item in ManageSession.SaleDetails)
            {
                invoice.InvoiceLine.Add(
                    new InvoiceLine
                    {
                        TrackId = item.TrackId,
                        Quantity = item.Quantity,
                        UnitPrice = item.UnitPrice
                    }
                    );
                //Sumando todos los subtotales
                invoiceTotal += item.Total;
            }

            invoice.Total = invoiceTotal;

            //Grabando en DB
            IAppUnitOfWork uw = new AppUnitOfWork();

            uw.InvoiceRepository.Add(invoice);
            uw.Complete();
            uw.Dispose();

            litMensajeTrack.Text = $"El total a pagar es: {invoiceTotal}" ;

            if (invoice.InvoiceId>0)
            {
                ManageSession.SaleDetails = null;
                litMensajeConfirmacion.Text = "La venta se registro correctamente";
                SetDataGrid(ManageSession.SaleDetails);
            }
        }
    }
}