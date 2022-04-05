using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Exceptions;

namespace Flagr.Api
{
    /// <summary>
    /// A factory method class which initializes any of the Flagr APIs.
    /// </summary>
    public class FlagrApiClientFactory
    {
        private Client.Configuration _apiConfiguration;

        public FlagrApiClientFactory()
        {
        }

        /// <summary>
        /// Initialize the API factory with a BasePath (Web API URL) and an API token
        /// </summary>
        /// <param name="basePath"></param>
        public void Initialize(string basePath)
        {
            _apiConfiguration = new Configuration
            {
                BasePath = basePath,
            };
        }

        /// <summary>
        /// An API Client to manage the IConstraintApi
        /// </summary>
        /// <returns>IConstraintApi</returns>
        public IConstraintApi CreateConstraintApi()
        {
            return _apiConfiguration == null ? throw new FlagrApiInitializationException() : new ConstraintApi(_apiConfiguration);
        }

        /// <summary>
        /// An API Client to manage the IDistributionApi
        /// </summary>
        /// <returns>IDistributionApi</returns>
        public IDistributionApi CreateDistributionApi()
        {
            return _apiConfiguration == null ? throw new FlagrApiInitializationException() : new DistributionApi(_apiConfiguration);
        }

        /// <summary>
        /// An API Client to manage the IEvaluationApi
        /// </summary>
        /// <returns>IEvaluationApi</returns>
        public IEvaluationApi CreateEvaluationApi()
        {
            return _apiConfiguration == null ? throw new FlagrApiInitializationException() : new EvaluationApi(_apiConfiguration);
        }

        /// <summary>
        /// An API Client to manage the IExportApi
        /// </summary>
        /// <returns>IExportApi</returns>
        public IExportApi CreateExportApi()
        {
            return _apiConfiguration == null ? throw new FlagrApiInitializationException() : new ExportApi(_apiConfiguration);
        }

        /// <summary>
        /// An API Client to manage the IFlagApi
        /// </summary>
        /// <returns>IFlagApi</returns>
        public IFlagApi CreateFlagApi()
        {
            return _apiConfiguration == null ? throw new FlagrApiInitializationException() : new FlagApi(_apiConfiguration);
        }

        /// <summary>
        /// An API Client to manage the IHealthApi
        /// </summary>
        /// <returns>IHealthApi</returns>
        public IHealthApi CreateHealthApi()
        {
            return _apiConfiguration == null ? throw new FlagrApiInitializationException() : new HealthApi(_apiConfiguration);
        }

        /// <summary>
        /// An API Client to manage the ISegmentApi
        /// </summary>
        /// <returns>ISegmentApi</returns>
        public ISegmentApi CreateSegmentApi()
        {
            return _apiConfiguration == null ? throw new FlagrApiInitializationException() : new SegmentApi(_apiConfiguration);
        }

        /// <summary>
        /// An API Client to manage the ITagApi
        /// </summary>
        /// <returns>ITagApi</returns>
        public ITagApi CreateTagApi()
        {
            return _apiConfiguration == null ? throw new FlagrApiInitializationException() : new TagApi(_apiConfiguration);
        }

        /// <summary>
        /// An API Client to manage the IVariantApi
        /// </summary>
        /// <returns>IVariantApi</returns>
        public IVariantApi CreateVariantApi()
        {
            return _apiConfiguration == null ? throw new FlagrApiInitializationException() : new VariantApi(_apiConfiguration);
        }
    }
}
