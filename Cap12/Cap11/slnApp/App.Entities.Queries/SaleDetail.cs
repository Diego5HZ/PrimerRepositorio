namespace App.Entities.Queries
{
    using System;
    using System.Collections.Generic;
    

    public partial class SaleDetail
    {
        public int TrackId { get; set; }

        public string TrackName { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        public decimal Total { get; set; }
    }
}
