# ShipEngineSDK.Model.LabelStatus
The possible statuses that a [shipping label](https://www.shipengine.com/docs/labels/create-a-label/) can be in.  |Status       |Description |:- -- -- -- -- -- -|:- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- |`processing` |When labels are created in a [batch](https://www.shipengine.com/docs/labels/bulk/), it may take a few minutes for all of the labels in the batch to be created.  During this period, they will be in `processing` status. |`completed`  |The label was successfully created |`error`      |The label could not be created due to an error, such as an invalid delivery address |`voided`     |The label has been [voided](https://www.shipengine.com/docs/labels/voiding/) 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

