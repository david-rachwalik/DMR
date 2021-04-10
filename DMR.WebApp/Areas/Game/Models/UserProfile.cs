using DMR.WebApp.Areas.Game.Data;
using DMR.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DMR.WebApp.Areas.Game.Models
{
    // Saves profile information that unlocks account-wide
    public class UserProfile : GameAsset
    {
        [StringLength(16, MinimumLength = 3, ErrorMessage = "Display Name must be between 3 and 16 characters.")]
        public string DisplayName { get; set; }
        // Profile Settings
        [StringLength(50, ErrorMessage = "E-Mail cannot be longer than 50 characters.")]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }
        public bool EmailVerified { get; set; } // Required for content creators
        public bool EmailPublic { get; set; }   // Required for content creators
        public Setting_Theme Theme { get; set; }
        [Display(Name = "Hide Tutorial Tips")]
        public DateTime LoginPrevious { get; set; }
        public bool HideTutorialTips { get; set; }
        public bool ShowAdvancedTooltips { get; set; }
        public Setting_TimeNotation FormatTime { get; set; }
        public Setting_TemperatureDegree FormatTemperature { get; set; }

        public SaveState SaveCurrent { get; set; }
        public IEnumerable<SaveState> Saves { get; set; }

        public IEnumerable<Tag> FetishOptIn { get; set; }
        public IEnumerable<Tag> FetishOptOut { get; set; }

        //public ApplicationUser User { get; set; }
        //public ApplicationRole Role { get; set; }
    }

    #region FluentAPI
    class UserProfileConfiguration : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.ToTable("UserProfile");

            builder.HasData(UserProfileData.Seed());
        }
    }
    #endregion

    #region Enumerators
    public enum Setting_Theme
    {
        Classic,
        [Display(Name = "Day Mode, Light")]
        Light,
        [Display(Name = "Night Mode, Dark")]
        Dark
    }

    public enum Setting_TimeNotation
    {
        ISO8601     // 2019-02-09T21:41:55Z
    }

    // https://en.wikipedia.org/wiki/Degree_(temperature)
    public enum Setting_TemperatureDegree
    {
        Celsius,    // (°C)
        Fahrenheit, // (°F)
        Kelvin      // (K)
    }
    #endregion
}
