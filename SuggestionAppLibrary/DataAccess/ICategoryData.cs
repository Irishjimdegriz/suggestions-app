namespace SuggestionAppLibrary.DataAccess;

public interface ICategoryData
{
    Task<List<CategoryModel>> GetAllCategory();
    Task CreateCategory(CategoryModel category);
}