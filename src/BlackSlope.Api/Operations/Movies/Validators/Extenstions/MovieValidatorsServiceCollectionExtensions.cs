﻿using BlackSlope.Api.Operations.Movies.Validators;
using BlackSlope.Api.Operations.Movies.Validators.Interfaces;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class MovieValidatorServiceCollectionExtensions
    {
        public static IServiceCollection AddMovieValidators(this IServiceCollection services)
        {
            services.TryAddTransient<IUpdateMovieRequestValidatorCollection, UpdateMovieRequestValidatorCollection>();
            services.TryAddTransient<ICreateMovieRequestValidatorCollection, CreateMovieRequestValidatorCollection>();
            return services;
        }
    }
}
