# interview

## PROBLEM 1:
I want the ApiController.GetInventory to return ApiController.Models.InventoryCountApiResult.


## PROBLEM 2:
I want to prepare for dependency injection so I can control the implementation of the Service at runtime
(no need to actually try to setup any real DI framework - just get ready)


## PROBLEM 3:
I want the ServiceLayer.InventoryService.GetCount to call StoreResponse with the response from the ApiController.
I don't want the ServiceLayer to "know" about the Model (InventoryCountApiResult).