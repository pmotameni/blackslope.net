using System;

namespace BlackSlope.Api.Common.Middleware.Corellation
{
    public interface ICurrentCorrelationIdService
    {
        CorrelationId Current();
        void Set(Guid correlationId);
    }
}
