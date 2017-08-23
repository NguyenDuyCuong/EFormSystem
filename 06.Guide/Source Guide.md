# E-FormSystem : Source Guide
## Structure
1. UI
    1.1. Admin 
2. API
3. Core

## Technical
### 1. Frontend: nodejs + angularjs + masterial
### 2. Backend: asp.net core + drapper

## Error handle:
### 1. Codein: EFS.Common.Exceptions
- Implement: BussinessException, DataAccessException, ServiceException, APIException
- Contain: 
    InputData as JsonString, 
    FuncName as string,
### 2. UseWhen: 
Force use try catch at BussinessLayer to handle all exception internner
In each layer only throw corresponding exception if it is logic error.
### 3. UnhandleException:
Try catch by global

## Authentication
### 1. Use: Token store in database and in client

### 2. Codein: 
* Server: 
    * **API/BaseControler**: hold AuthenService + AuthenBL
    * **API/TokenAttribute**: combie with **[TokenValidation]** will be call before any function have called. Will be call to AuthenService + AuthenBL to check token. Special, call back to controller to use AuthenBL.
    * **BL/AuthenBL**: 
    * **Common/Credential**: hold token + username + passs + id + ...
    * **Common/TOkenService**: tranfer to BaseBL in start.cs
    * **Model/AppUser**:
* Client: 
    * **Auth.guard.ts**:
    * 

### 3. Workflow:
* **Client**: token store in localstorage and Auth.Service.ts
If client cannot find token key -> redirect to login form
If client find token key -> alow view and send request to server with token
    ...
* **Server**: token store in TokenAuthenService and BaseController
Only get request from client, 
If token is empty return Unauthenication
else Check expired of clientToken
if pass then 

## Services
### 1. Codein: Common/Service

## How to:
### 1. Create Controller
