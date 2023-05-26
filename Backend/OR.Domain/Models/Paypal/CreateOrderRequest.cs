namespace OR.Domain.Models.Paypal;
internal class CreateOrderRequest {
    public string intent { get; set; }
    public List<PurchaseUnit> purchase_units { get; set; } = new();
}
