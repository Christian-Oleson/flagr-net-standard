# Flagr.Api.Model.EvalContext
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityID** | **string** | entityID is used to deterministically at random to evaluate the flag result. If it&#39;s empty, flagr will randomly generate one. | [optional] 
**EntityType** | **string** |  | [optional] 
**EntityContext** | **Object** |  | [optional] 
**EnableDebug** | **bool?** |  | [optional] 
**FlagID** | **long?** | flagID | [optional] 
**FlagKey** | **string** | flagKey. flagID or flagKey will resolve to the same flag. Either works. | [optional] 
**FlagTags** | **List&lt;string&gt;** | flagTags. flagTags looks up flags by tag. Either works. | [optional] 
**FlagTagsOperator** | **string** | determine how flagTags is used to filter flags to be evaluated. OR extends the evaluation to those which contains at least one of the provided flagTags or AND limit the evaluation to those which contains all the flagTags. | [optional] [default to FlagTagsOperatorEnum.ANY]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

