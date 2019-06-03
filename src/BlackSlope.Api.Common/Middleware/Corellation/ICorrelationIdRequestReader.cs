using System;
using Microsoft.AspNetCore.Http;

namespace BlackSlope.Api.Common.Middleware.Corellation
{
    public interface ICorrelationIdRequestReader
    {
        Guid? Read(HttpContext context);
    }
}
