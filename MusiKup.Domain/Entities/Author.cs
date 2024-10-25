using MusiKup.Domain.Entities.Files;

namespace MusiKup.Domain.Entities;

public class Author : BaseEntity
{
    public ICollection<Track> Tracks { get; set; }
    
    public string NickName { get; set; }
    
    public object FullName { get; set; }
    
    public ICollection<AuthorFile> AuthorFiles { get; set; }
}