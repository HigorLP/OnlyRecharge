namespace OR.Application.Interfaces;
using OR.Domain.Models.Paypal;

//Essa interface definirá os métodos para interagir com a API do PayPal,
//como criar uma ordem de pagamento e capturar uma ordem de pagamento.

internal interface IPaypalService {
    internal Task<object> CreateOrder(string value, string currency, string reference);
    internal Task<object> CaptureOrder(string orderId);
}
