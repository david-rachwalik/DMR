using DMR.WebApp.Areas.Game.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMR.WebApp.Areas.Game.Models.Templates
{
    public class CharacterTemplate : Character
    {
    }

    #region FluentAPI
    class CharacterTemplateConfiguration : IEntityTypeConfiguration<CharacterTemplate>
    {
        public void Configure(EntityTypeBuilder<CharacterTemplate> builder)
        {
            //builder
            //    .HasOne(p => p.SaveState_Player)
            //    .WithOne(b => b.Player)
            //    .HasForeignKey(s => s.SaveState_Player_FK);
            //builder
            //    .HasOne(p => p.SaveState_NPCs)
            //    .WithMany(b => b.NPCs)
            //    .HasForeignKey(s => s.SaveState_NPCs_FK);
            //builder
            //    .HasOne(p => p.SaveState_Followers)
            //    .WithMany(b => b.Followers)
            //    .HasForeignKey(s => s.SaveState_Followers_FK);
            //builder
            //    .HasOne(p => p.SaveState_Mounts)
            //    .WithMany(b => b.Mounts)
            //    .HasForeignKey(s => s.SaveState_Mounts_FK);

            builder.ToTable("CharacterTemplate");

            builder.HasData(CharacterTemplateData.Seed());
        }
    }
    #endregion
}
