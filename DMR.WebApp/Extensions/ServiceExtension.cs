using DMR.WebApp.Areas.Game.Services;
using Microsoft.AspNetCore.Authentication;
//using Microsoft.AspNetCore.Authentication.AzureAD.UI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using DMR.WebApp.Areas.Game.Services;
//using DMR.WebApp.Areas.Game.Services.CharacterBodyParts;

namespace DMR.WebApp.Extensions
{
    public static class ServiceExtension
    {
        public static void AddDataServices(this IServiceCollection services)
        {
            // -------- Register Game Core Services --------
            services.AddScoped<IAttributeService, AttributeService>();
            services.AddScoped<ITagService, TagService>();
            // --------------------------------------------------------
            services.AddScoped<ICharacterTemplateService, CharacterTemplateService>();
            services.AddScoped<IItemTemplateService, ItemTemplateService>();
            services.AddScoped<ILocationTemplateService, LocationTemplateService>();
            //// --------------------------------------------------------
            services.AddScoped<IUserProfileService, UserProfileService>();


            //services.AddScoped<ICharacterBodyPartService, CharacterBodyPartService>();
            //// --------------------------------------------------------
            ////services.AddScoped<IAuditService, AuditService>();
            //services.AddScoped<ISaveStateService, SaveStateService>();
        }
    }
}
