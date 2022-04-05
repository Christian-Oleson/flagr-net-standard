using Flagr.Api.Api;

namespace Flagr.Api
{
    public interface IFlagrApiClientFactory
    {
        /// <summary>
        /// Initialize the API factory with a BasePath (Web API URL) and an API token
        /// </summary>
        /// <param name="basePath"></param>
        void Initialize(string basePath);

        /// <summary>
        /// An API Client to manage the IConstraintApi
        /// </summary>
        /// <returns>IConstraintApi</returns>
        IConstraintApi CreateConstraintApi();

        /// <summary>
        /// An API Client to manage the IDistributionApi
        /// </summary>
        /// <returns>IDistributionApi</returns>
        IDistributionApi CreateDistributionApi();

        /// <summary>
        /// An API Client to manage the IEvaluationApi
        /// </summary>
        /// <returns>IEvaluationApi</returns>
        IEvaluationApi CreateEvaluationApi();

        /// <summary>
        /// An API Client to manage the IExportApi
        /// </summary>
        /// <returns>IExportApi</returns>
        IExportApi CreateExportApi();

        /// <summary>
        /// An API Client to manage the IFlagApi
        /// </summary>
        /// <returns>IFlagApi</returns>
        IFlagApi CreateFlagApi();

        /// <summary>
        /// An API Client to manage the IHealthApi
        /// </summary>
        /// <returns>IHealthApi</returns>
        IHealthApi CreateHealthApi();

        /// <summary>
        /// An API Client to manage the ISegmentApi
        /// </summary>
        /// <returns>ISegmentApi</returns>
        ISegmentApi CreateSegmentApi();

        /// <summary>
        /// An API Client to manage the ITagApi
        /// </summary>
        /// <returns>ITagApi</returns>
        ITagApi CreateTagApi();

        /// <summary>
        /// An API Client to manage the IVariantApi
        /// </summary>
        /// <returns>IVariantApi</returns>
        IVariantApi CreateVariantApi();
    }
}
