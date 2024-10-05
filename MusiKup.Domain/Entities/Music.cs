namespace MusiKup.Domain.Entities;

public class Music : BaseEntity
{
    public Enum Genre { get; set; }
    
    public string Title { get; set; }
    
    public Authors Autor { get; set; }
    
    public Guid AutorId { get; set; }
    
    public Playlists Playlist { get; set; }
    
    public Guid PlaylistId { get; set; }
}