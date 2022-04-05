# Flagr.Api.Model.Flag
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long?** |  | [optional] 
**Key** | **string** | unique key representation of the flag | [optional] 
**Description** | **string** |  | 
**Enabled** | **bool?** |  | 
**Tags** | [**List&lt;Tag&gt;**](Tag.md) |  | [optional] 
**Segments** | [**List&lt;Segment&gt;**](Segment.md) |  | [optional] 
**Variants** | [**List&lt;Variant&gt;**](Variant.md) |  | [optional] 
**DataRecordsEnabled** | **bool?** | enabled data records will get data logging in the metrics pipeline, for example, kafka. | 
**EntityType** | **string** | it will override the entityType in the evaluation logs if it&#39;s not empty | [optional] 
**Notes** | **string** | flag usage details in markdown format | [optional] 
**CreatedBy** | **string** |  | [optional] 
**UpdatedBy** | **string** |  | [optional] 
**UpdatedAt** | **DateTime?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

