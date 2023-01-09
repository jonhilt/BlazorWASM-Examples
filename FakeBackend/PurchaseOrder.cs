using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorExamples.WASM.FakeBackend;

public class PurchaseOrder
{
    public int Id { get; set; }
    public string Number { get; set; }
    public DateTime Date { get; set; }

    public List<Material> Materials { get; set; } = new List<Material>();

    public void ReceiveMaterial(int materialId)
    {
        var material = Materials.SingleOrDefault(x => x.Id == materialId);
        material.Received = true;
    }
}

public class Material
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Received { get; set; }
}