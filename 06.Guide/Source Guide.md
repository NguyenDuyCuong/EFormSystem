# E-FormSystem : Source Guide
Structure

    + UI
       - Admin
    API
    Core

Technical

    Frontend: nodejs + angularjs + masterial
    Backend: asp.net core + drapper

Error handle:

    Codein: EFS.Common.Exceptions
        - Implement: BussinessException, DataAccessException, ServiceException, APIException
        - Contain: 
            InputData as JsonString, 
            FuncName as string,
    UseWhen: 
        Force use try catch at BussinessLayer to handle all exception internner
        In each layer only throw corresponding exception if it is logic error.
    UnhandleException:
        Try catch by global

Authentication

    Use: token
    Codein: API/BaseControler + Common/TokenAuthorizationService
    In client: token store in localstorage and Auth.Service.ts
        If client cannot find token key -> redirect to login form
        If client find token key -> alow view and send request to server with token
        ...
    InServer: token store in TokenAuthenService and BaseController
        Only get request from client, 
        If token is empty return Unauthenication
        else Check expired of clientToken
        if pass then 

Services
    Codein: Common/Service

How to:
    Create Controller
