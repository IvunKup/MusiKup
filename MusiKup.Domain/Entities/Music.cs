namespace MusiKup.Domain.Entities;

public class Music : BaseEntity
{
    public Enum Genre { get; set; }
    
    public string Title { get; set; }
    
    public Author Autor { get; set; }
    
    public Guid AutorId { get; set; }
    
    public Performer Performer { get; set; }
    
    public Guid PerformerId { get; set; }
    
    public ICollection<Playlist> Playlists { get; set; }
}