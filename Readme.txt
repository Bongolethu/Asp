Author : Bongolethu Fumbatha


NB: The comment types
    // TODO : this class would also include async generic calls,
	/// over a scope
	No real error handling, just try and catch
	No Unit testing both for the api and app

1. This is a web api to use with the Angular 4 app, accompanied by 2 DLLs(DAL,CORE)
   DAL is the Data Access Layer, and Core is the Entity and Common data 
2. This is a Repository pattern approach with Dependency Injection(using StructureMap.WebApi2). 
3. On the top of a class there is a summary comment if needed /// over a scope

4. The DAL is Entity Framework Code First
  4.1 The connection String point to [WIN-IVSX0SEW4J\SQLSERVERDEV] make a change on the App Config 
      to point it to your local. both Api WebConfig and DAL
  4.2  The get GetByParentIdAsync is soley for demo perposes
5. The Core is the Common Data, Constants, Entity ExtentionMethods etc.
   5.1 We have a Base Class that the gets inherited by other Classes