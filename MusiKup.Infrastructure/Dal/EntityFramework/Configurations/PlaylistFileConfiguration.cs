using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Infrusructure.Dal.EntityFramework.Configurations;

public class PlaylistFileConfiguration : IEntityTypeConfiguration<PlaylistFile>
{
    public void Configure(EntityTypeBuilder<PlaylistFile> builder)
    {
        builder.HasOne(pf => pf.Playlist)
            .WithMany(pf => pf.PlaylistFiles)
            .HasForeignKey(pf => pf.PlaylistId);
    }
}