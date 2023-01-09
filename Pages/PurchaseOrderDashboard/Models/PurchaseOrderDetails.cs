using System;
using System.Collections.Generic;

namespace BlazorExamples.WASM.Pages.PurchaseOrderDashboard.Models;

public class PurchaseOrderDetails
{
    public string Number { get; set; }
    public DateTime Date { get; set; }

    public List<Material> Materials { get; set; } = new List<Material>();

    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Received { get; set; }
    }
}