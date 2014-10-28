using System.Collections.Generic;
using VSOServiceIntegration.Entities.VSO;

namespace VSOServiceIntegration.Services.Rest.Interfaces
{
    public interface IVSOService
    {
        List<Subscription> GetSubscriptions();
    }
}
