namespace OR.PayPal.Models {
    public class PaypalModel {
        public string? Mode { get; set; }
        public string? ClientId { get; set; }
        public string? ClientServer { get; set; }

        public string BaseUrl => Mode == "Live"
            ? "https://api-m.paypal.com"
            : "https://api-m.sandbox.paypal.com";
    }
}
