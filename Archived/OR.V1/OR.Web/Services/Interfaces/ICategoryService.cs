using OR.Web.Models;

namespace OR.Web.Services.Interfaces; 
public interface ICategoryService {
    Task<IEnumerable<CategoryViewModel>> GetAllCategories();
}
