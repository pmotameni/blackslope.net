﻿using System;
using Microsoft.AspNetCore.Http;

namespace BlackSlope.Api.Common.Middleware.Corellation
{
    public interface ICorrelationIdResponseWriter
    {
        void Write(HttpContext context, Guid correlationId);
    }
}
