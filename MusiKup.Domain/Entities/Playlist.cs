namespace MusiKup.Domain.Entities;

public class Playlist : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }

    public Playlist(Guid id, DateTime createOn, DateTime modifiedOn, DateTime date, string title, string description)
    {
        Id = id;
        CreatedOn = createOn;
        ModifiedOn = modifiedOn;
        Title = title;
        Description = description;
    }
}