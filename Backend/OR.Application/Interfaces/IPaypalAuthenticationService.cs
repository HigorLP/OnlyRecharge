using OR.Domain.Models.Paypal;
namespace OR.Application.Interfaces;

// Essa interface definirá o método para autenticar com a API do PayPal e obter um token de acesso.

public interface IPaypalAuthenticationService {
    internal Task<AuthResponse> Authenticate();
}
