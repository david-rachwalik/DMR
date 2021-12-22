using DMR.WebApp.Models;
using DMR.WebApp.Areas.Game.Data;
using DMR.WebApp.Areas.Game.Data.CharacterBodyParts;
using DMR.WebApp.Areas.Game.Models;
using DMR.WebApp.Areas.Game.Models.CharacterBodyParts;
using Microsoft.EntityFrameworkCore;
using Attribute = DMR.WebApp.Areas.Game.Models.Attribute;
using DMR.WebApp.Areas.Game.Models.Templates;

namespace DMR.WebApp.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        // -------- Game Core Assets --------
        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Effect> Effects { get; set; }

        // -------- Game True Assets --------
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<SaveState> SaveStates { get; set; }
        public DbSet<Character> Characters { get; set; }
        //public DbSet<Relationship> Relationships { get; set; }

        // -------- Game Template Assets --------
        public DbSet<SaveStateTemplate> SaveStateTemplates { get; set; }
        public DbSet<CharacterTemplate> CharacterTemplates { get; set; }
        //public DbSet<RelationshipTemplate> RelationshipTemplates { get; set; }
        public DbSet<ItemTemplate> ItemTemplates { get; set; }
        public DbSet<LocationTemplate> LocationTemplates { get; set; }
        public DbSet<MomentTemplate> MomentTemplates { get; set; }
        public DbSet<SkillTemplate> SkillTemplates { get; set; }
        public DbSet<StoryTemplate> StoryTemplates { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // -------- Game Core Configurations --------
            modelBuilder.ApplyConfiguration(new AttributeConfiguration());
            modelBuilder.ApplyConfiguration(new TagConfiguration());
            modelBuilder.ApplyConfiguration(new EffectConfiguration());

            // -------- Game True Configurations --------
            modelBuilder.ApplyConfiguration(new UserProfileConfiguration());
            modelBuilder.ApplyConfiguration(new SaveStateConfiguration());
            modelBuilder.ApplyConfiguration(new CharacterConfiguration());
            //modelBuilder.ApplyConfiguration(new RelationshipConfiguration());

            // -------- Game Template Configurations --------
            modelBuilder.ApplyConfiguration(new SaveStateTemplateConfiguration());
            modelBuilder.ApplyConfiguration(new CharacterTemplateConfiguration());
            //modelBuilder.ApplyConfiguration(new RelationshipTemplateConfiguration());
            modelBuilder.ApplyConfiguration(new ItemTemplateConfiguration());
            modelBuilder.ApplyConfiguration(new LocationTemplateConfiguration());
            modelBuilder.ApplyConfiguration(new MomentTemplateConfiguration());
            modelBuilder.ApplyConfiguration(new SkillTemplateConfiguration());
            modelBuilder.ApplyConfiguration(new StoryTemplateConfiguration());

            // Flow of model relationships:
            // UserProfile => SaveState => Character => Item => Attribute
        }
    }
}