using System;
using System.Collections.Generic;
using System.Linq;
using BlazorExamples.WASM.FakeBackend;

namespace BlazorExamples.WASM.Pages.PurchaseOrderDashboard.Models;

public class FakeApi
{
    private readonly FakeDB _fakeDb;

    public FakeApi(FakeDB fakeDb)
    {
        _fakeDb = fakeDb;
    }

    public PurchaseOrderDetails GetPurchaseOrders(int purchaseOrderId)
    {
        var po = _fakeDb.Orders.SingleOrDefault(x => x.Id == purchaseOrderId);

        if (po == null)
            throw new KeyNotFoundException("Could not locate PO");

        var purchaseOrderDetails = new PurchaseOrderDetails
        {
            Date = po.Date,
            Number = po.Number,
        };

        foreach (var poMaterial in po.Materials)
        {
            purchaseOrderDetails.Materials.Add(new PurchaseOrderDetails.Material
            {
                Id = poMaterial.Id,
                Name = poMaterial.Name,
                Received = poMaterial.Received
            });
        }
        
        return purchaseOrderDetails;
    }

    public void ReceiveMaterial(int poId, int materialId)
    {
        var po = _fakeDb.Orders.SingleOrDefault(x => x.Id == poId);
        po.ReceiveMaterial(materialId);
    }
}