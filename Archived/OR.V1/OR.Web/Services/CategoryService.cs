using OR.Web.Models;
using OR.Web.Services.Interfaces;
using System.Text.Json;

namespace OR.Web.Services;
public class CategoryService : ICategoryService {

    private readonly IHttpClientFactory _clientFactory;
    private readonly JsonSerializerOptions _options;
    private const string apiEndpoint = "/api/categories/";

    public CategoryService(IHttpClientFactory clientFactory) {
        _clientFactory = clientFactory;
        _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }

    public async Task<IEnumerable<CategoryViewModel>> GetAllCategories() {
        var client = _clientFactory.CreateClient("ProductApi");
        IEnumerable<CategoryViewModel> categories;

        var response = await client.GetAsync(apiEndpoint);

        if (response.IsSuccessStatusCode) {
            var apiResponse = await response.Content.ReadAsStreamAsync();
            categories = await JsonSerializer
                .DeserializeAsync<IEnumerable<CategoryViewModel>>(apiResponse);
        } else {
            return null;
        }
        return categories;
    }
}
