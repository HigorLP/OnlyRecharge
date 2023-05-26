namespace OR.Domain.Models.Paypal;
internal class CreateOrderResponse {
    public string id { get; set; }
    public string status { get; set; }
    public List<Link> links { get; set; }
}
