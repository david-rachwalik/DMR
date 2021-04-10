using Microsoft.AspNetCore.Authentication;
//using Microsoft.AspNetCore.Authentication.AzureAD.UI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using DMR.WebApp.Areas.Game.Services;
//using DMR.WebApp.Areas.Game.Services.CharacterAsset;

namespace DMR.WebApp.Extensions
{
    public static class ServiceExtension
    {
        public static void AddDataServices(this IServiceCollection services)
        {
            //services.AddDbContext<MainContext>(options =>
            //  options.UseSqlite(Configuration.GetConnectionString("DevConnection")));

            //services.AddScoped<IAttributeService, AttributeService>();
            //services.AddScoped<ITagService, TagService>();
            //// --------------------------------------------------------
            //services.AddScoped<ICharacterService, CharacterService>();
            //services.AddScoped<IItemService, ItemService>();
            //services.AddScoped<ILocationService, LocationService>();
            //// --------------------------------------------------------
            //services.AddScoped<ICharacterBodyPartService, CharacterBodyPartService>();
            //// --------------------------------------------------------
            ////services.AddScoped<IAuditService, AuditService>();
            //services.AddScoped<ISaveStateService, SaveStateService>();
            //services.AddScoped<IUserProfileService, UserProfileService>();
        }
    }
}
