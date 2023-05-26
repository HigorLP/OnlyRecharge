using OR.Application.Interfaces;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace OR.Application.Services;

// Essa classe implementará a interface IPaypalService
// e será responsável por enviar as requisições para a API do PayPal e lidar com as respostas.

internal class PaypalService : IPaypalService {
    Task<object> IPaypalService.CaptureOrder(string orderId) {
        var auth = await Authenticate();

        var httpClient = new HttpClient();

        httpClient.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse($"Bearer {auth.access_token}");

        var httpContent = new StringContent("", Encoding.Default, "application/json");

        var httpResponse = await httpClient.PostAsync($"{BaseUrl}/v2/checkout/orders/{orderId}/capture", httpContent);

        var jsonResponse = await httpResponse.Content.ReadAsStringAsync();
        var response = JsonSerializer.Deserialize<CaptureOrderResponse>(jsonResponse);

        return response;
    }

    Task<object> IPaypalService.CreateOrder(string value, string currency, string reference) {
        var auth = await Authenticate();

        var request = new CreateOrderRequest {
            intent = "CAPTURE",
            purchase_units = new List<PurchaseUnit>
            {
                    new()
                    {
                        reference_id = reference,
                        amount = new Amount
                        {
                            currency_code = currency,
                            value = value
                        }
                    }
                }
        };

        var httpClient = new HttpClient();

        httpClient.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse($"Bearer {auth.access_token}");

        var httpResponse = await httpClient.PostAsJsonAsync($"{BaseUrl}/v2/checkout/orders", request);

        var jsonResponse = await httpResponse.Content.ReadAsStringAsync();
        var response = JsonSerializer.Deserialize<CreateOrderResponse>(jsonResponse);

        return response;
    }
}
