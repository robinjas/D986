using Inventory_Management_System.Models;
using System.ComponentModel;

public class Product
{
    public int ProductID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int InStock { get; set; }
    public int Min { get; set; }
    public int Max { get; set; }
    public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();

    public void addAssociatedPart(Part part) => AssociatedParts.Add(part);
    public bool removeAssociatedPart(int partID)
    {
        var part = lookupAssociatedPart(partID);
        if (part != null)
        {
            return AssociatedParts.Remove(part);
        }
        return false;
    }

    public Part? lookupAssociatedPart(int partID) => AssociatedParts.FirstOrDefault(p => p.PartID == partID);
}
