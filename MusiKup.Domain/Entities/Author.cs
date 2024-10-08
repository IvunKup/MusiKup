namespace MusiKup.Domain.Entities;

public class Author : BaseEntity
{
    public ICollection<Music> Tracks { get; set; }
    
    public string NickName { get; set; }
    
    public object FullName { get; set; }
}