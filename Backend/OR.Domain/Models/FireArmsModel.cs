namespace OR.Domain.Models;
public class FireArmModel : ProductModel {
    public string SerialNumber { get; private set; }
    public string Model { get; set; }
    public string TypeOperation { get; set; }
    public string Caliber { get; set; }
    public string Finishing { get; set; }
    public int NumberPipes { get; set; }
    public string SoulType { get; set; }
    public int LoadingCapacity { get; set; }
    public Guid BrandId { get; private set; }
    public List<BrandModel> Brands { get; set; }
    public string Species { get; set; }
    public string Manufacturing { get; set; }
    public string PipeLength { get; set; }
    public int LanesNumber { get; set; }
    public string LaneDirection { get; set; }

    public FireArmModel(Guid id, string name, string description, long sku, decimal price, int stock, Guid categoryId, CategoryModel category, string serialNumber)
        : base(id, name, description, sku, price, stock, categoryId, category) {
        SerialNumber = serialNumber;
    }
}
