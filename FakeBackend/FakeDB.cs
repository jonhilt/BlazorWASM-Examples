using System;
using System.Collections.Generic;

namespace BlazorExamples.WASM.FakeBackend;

public class FakeDB
{
    public List<PurchaseOrder> Orders { get; set; } = new List<PurchaseOrder>
    {
        new PurchaseOrder{Date = new DateTime(2022,1,1), Id = 1, Number = "PO-1", Materials = new List<Material>
        {
            new Material{Id = 1, Name = "Material 1", Received = false}, 
            new Material{Id = 2, Name = "Material 2", Received = false}
        }},
        new PurchaseOrder{Date = new DateTime(2022,1,2), Id = 2, Number = "PO-2", Materials = new List<Material>
        {
            new Material{Id = 3, Name = "Material 3", Received = false}, 
            new Material{Id = 4, Name = "Material 4", Received = false}
        }},
        new PurchaseOrder{Date = new DateTime(2022,1,3), Id = 3, Number = "PO-3", Materials = new List<Material>
        {
            new Material{Id = 5, Name = "Material 5", Received = false}, 
            new Material{Id = 6, Name = "Material 6", Received = false}
        }},
        new PurchaseOrder{Date = new DateTime(2022,1,4), Id = 4, Number = "PO-4", Materials = new List<Material>
        {
            new Material{Id = 7, Name = "Material 7", Received = false}, 
            new Material{Id = 8, Name = "Material 8", Received = false}
        }},
        new PurchaseOrder{Date = new DateTime(2022,1,5), Id = 5, Number = "PO-5", Materials = new List<Material>
        {
            new Material{Id = 9, Name = "Material 9", Received = false}, 
            new Material{Id = 10, Name = "Material 10", Received = false}
        }},
     
    };
}