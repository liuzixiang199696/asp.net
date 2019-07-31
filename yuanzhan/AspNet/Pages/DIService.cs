using BLL;
using BLL.entity;
using BLL.entity.Articled;
using BLL.repoistory;
using Microsoft.Extensions.DependencyInjection;
using SRV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Pages.Shared;

namespace AspNet.Pages
{
    public static class DIService
    {
        public static void AddDIService(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddTransient<IUserService, UserService>();
            services.AddScoped<SuggestService,SuggestService>();
            services.AddScoped<_LayoutModel, _LayoutModel>();
            services.AddScoped<SuggestModel, SuggestModel>();
            services.AddScoped<UserService, UserService>();
            services.AddScoped<UserModel, UserModel>();
            services.AddScoped<RegisterService, RegisterService>();
            services.AddScoped<BaseService, BaseService>();


        }
        public static void AddDIRepoistory(this IServiceCollection services)
        {
            services.AddScoped<UserRepoistory, UserRepoistory>();
            services.AddScoped<EmailRepoistory, EmailRepoistory>();
            services.AddScoped<SuggestRepoistory, SuggestRepoistory>();
            services.AddScoped<Suggest, Suggest>();
            services.AddScoped<Blog, Blog>();
            services.AddScoped<Keyword, Keyword>();
            services.AddScoped<Email, Email>();
            services.AddScoped<MYUser, MYUser>();
            services.AddScoped<Entity, Entity>();

        }

    }
}
