namespace MusiKup.Domain.Entities;

public class User : BaseEntity
{
    public int TelegramId { get; set; }
    public string TelegramName { get; set; }

    public User(Guid id, DateTime createOn, DateTime modifiedOn, int telegramId, string telegramName)
    {
        Id = id;
        CreatedOn = createOn;
        ModifiedOn = modifiedOn;
        TelegramId = telegramId;
        TelegramName = telegramName;
    }
}