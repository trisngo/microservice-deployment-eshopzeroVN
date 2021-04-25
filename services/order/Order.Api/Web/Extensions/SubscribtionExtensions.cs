﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Zero.EventBus.Abstractions;

namespace Order.Api.Web.Extensions
{
    public static class SubscribtionExtensions
    {
        public static void UseSubscribes(this IApplicationBuilder builder)
        {
            var bus = builder.ApplicationServices.GetService<IEventBus>();

        }
    }
}
