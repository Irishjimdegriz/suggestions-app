namespace SuggestionAppLibrary.DataAccess;

public interface IStatusData
{
    Task<List<StatusModel>> GetAllCategory();
    Task CreateCategory(StatusModel status);
}