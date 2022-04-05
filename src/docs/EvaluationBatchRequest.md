# Flagr.Api.Model.EvaluationBatchRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entities** | [**List&lt;EvaluationEntity&gt;**](EvaluationEntity.md) |  | 
**EnableDebug** | **bool?** |  | [optional] 
**FlagIDs** | **List&lt;long?&gt;** | flagIDs | [optional] 
**FlagKeys** | **List&lt;string&gt;** | flagKeys. Either flagIDs, flagKeys or flagTags works. If pass in multiples, Flagr may return duplicate results. | [optional] 
**FlagTags** | **List&lt;string&gt;** | flagTags. Either flagIDs, flagKeys or flagTags works. If pass in multiples, Flagr may return duplicate results. | [optional] 
**FlagTagsOperator** | **string** | determine how flagTags is used to filter flags to be evaluated. OR extends the evaluation to those which contains at least one of the provided flagTags or AND limit the evaluation to those which contains all the flagTags. | [optional] [default to FlagTagsOperatorEnum.ANY]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

