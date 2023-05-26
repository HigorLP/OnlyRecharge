namespace OR.Domain.Models.Paypal;
internal class CaptureOrderResponse {
    public string id { get; set; }
    public string status { get; set; }
    public PaymentSource payment_source { get; set; }
    public List<PurchaseUnit> purchase_units { get; set; }
    public Payer payer { get; set; }
    public List<Link> links { get; set; }
}
