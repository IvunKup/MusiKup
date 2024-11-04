namespace MusiKup.Domain.Entities.Files;

public class UserFile : BaseFile
{
    public User User { get; set; }
}