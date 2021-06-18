﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.DependencyInjection;
using TreeList.Module.Blazor.Helpers;

namespace TreeList.Module.Blazor.Extensions {
    public static class StartupExtensions {
        public static IServiceCollection AddTreeListBlazorModule(this IServiceCollection services) {
            services.AddTransient<ITagHelperComponent, LinkTagHelperComponent>();
            return services;
        }
    }
}
