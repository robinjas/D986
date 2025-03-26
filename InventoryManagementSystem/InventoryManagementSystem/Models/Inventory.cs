using Inventory_Management_System.Models;
using System.ComponentModel;

public static class Inventory
{
    public static BindingList<Product> Products { get; set; } = new BindingList<Product>();
    public static BindingList<Part> AllParts { get; set; } = new BindingList<Part>();

    public static void addProduct(Product product) => Products.Add(product);
    public static bool removeProduct(int productID)
    {
        var product = lookupProduct(productID);
        if (product != null)
        {
            return Products.Remove(product);
        }
        return false;
    }

    public static Product? lookupProduct(int productID) => Products.FirstOrDefault(p => p.ProductID == productID);
    public static void updateProduct(int index, Product product) => Products[index] = product;

    public static void addPart(Part part) => AllParts.Add(part);
    public static bool deletePart(Part part) => AllParts.Remove(part);
    public static Part? lookupPart(int partID) => AllParts.FirstOrDefault(p => p.PartID == partID);
    public static void updatePart(int index, Part part) => AllParts[index] = part;
}
