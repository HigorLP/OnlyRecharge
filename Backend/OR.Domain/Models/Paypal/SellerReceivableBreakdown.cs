namespace OR.Domain.Models.Paypal; 
internal class SellerReceivableBreakdown {
    public Amount gross_amount { get; set; }
    public PaypalFee paypal_fee { get; set; }
    public Amount net_amount { get; set; }
}
