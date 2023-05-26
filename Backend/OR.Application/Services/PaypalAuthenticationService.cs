using OR.Application.Interfaces;
using OR.Domain.Models.Paypal;
using System.Text.Json;
using System.Text;

namespace OR.Application.Services;

// Essa classe implementará a interface IPaypalAuthenticationService
// e será responsável por autenticar com a API do PayPal e obter o token de acesso.

internal class PaypalAuthenticationService : IPaypalAuthenticationService {
    Task<AuthResponse> IPaypalAuthenticationService.Authenticate() {
        var auth = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{ClientId}:{ClientSecret}"));

        var content = new List<KeyValuePair<string, string>>
        {
                new("grant_type", "client_credentials")
            };

        var request = new HttpRequestMessage {
            RequestUri = new Uri($"{BaseUrl}/v1/oauth2/token"),
            Method = HttpMethod.Post,
            Headers =
            {
                    { "Authorization", $"Basic {auth}" }
                },
            Content = new FormUrlEncodedContent(content)
        };

        var httpClient = new HttpClient();
        var httpResponse = await httpClient.SendAsync(request);
        var jsonResponse = await httpResponse.Content.ReadAsStringAsync();
        var response = JsonSerializer.Deserialize<AuthResponse>(jsonResponse);

        return response;
    }
}
