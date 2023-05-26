namespace OR.Domain.Models.Paypal;
internal class SellerProtection {
    public string status { get; set; }
    public List<string> dispute_categories { get; set; }
}
