namespace SuggestionAppLibrary.Models;
public class BasicUserModel
{
    [BsonId]
    public string Id { get; set; }
    public string DisplayName { get; set; }

    public BasicUserModel()
    {

    }

    public BasicUserModel(UserModel user)
    {
        Id = user.Id;
        DisplayName = user.DisplayName;
    }
}
