# Requirements specification

This section describes functional and non-functional requirements spec for the project.

Requirements are broken into use-case roles.

## Functional requirements

- Client role
  
  - Sign up, sign in, logout
  - Update credentials
  - Create support requests

    - choose category
    - add additional message
    - attach files
    - choose how manager can contact client
  
  - View support requests
  - Update support request
  - Cancel (not delete) support request
  - Restore canceled request

  - Submit feedback after request served

- Manager role

  - Sign in, logout
  - View assigned support requests
  - Change request status to fullfilled (but not to pending, if it was fullfilled)
  - View personal stats

- Admin role

  - CRUD managers
  - View manager personal stats
  - View assigned support requests to manager, including client's feedback

- Root admin role

  - CRUD admins
  
- Auth service role

  - inner functionality
    - Validate user credentials
    - CRUD users
    - Generate auth token
    - Validate auth token

  - provided functionality
    - Provide validation functionality for other services
    - Provide sign up only for clients
    - Provide addition of admin accounts for root admin
    - Provide addition of manager accounts for admins
    - Provide sign in
    - Provide user data update
    - Provide user data removal

- Support service role

  - inner functionality
    - Validate support request category
    - Validate attachments
    - Validate auth token in auth service

    - CRU support requests

    - Read managers from Auth service
    - Auto-assign support request to first available manager
    - Re-assign support request to next available manager, if it's not served some time

    - CR client feedbacks

  - provided functionality

    - Provide support request create/view/update/cancel
    - Provide support request fullfillment action
    - Provide manager personal stats
    - Provide manager's assigned support requests

      - pagination
      - sorting
      - filtering

## Non-functional requirements

- Platform specification

  |Component|Technology|
  |---------|----------|
  |Database instance|MSSQL Express|
  |API Services|ASP.Net|
  |API-DB communication|Entity Framework Core|
  |Frontend application|Webpack|

- Database strategy

  Code-first approach

- Toolset

  - Visual Studio 2022
  - VS Code
  - dotnet CLI
  - Swagger
  - Docker Desktop
  - Figma
  - C#, JavaScript, SASS, SVG

- Authentication spec

  - JWT token
  - claims: `email`, `phone` (if present)
  - roles: `user role`
  - password: hashed + salted, resalted at each login

- Authorization priority

  - valid token
  - user role

- Domain constraints

  |User roles|
  |:--------:|
  |Client|
  |Manager|
  |Admin|
  |Root admin|

  |User credentials|
  |:--------------:|
  |First name|
  |Last name<br />(optional for Client role)|
  |Email|
  |Phone number<br />(optional for Client role)|
  |Password|

  |Support request categories|
  |:------------------------:|
  |Application related issue|
  |Application improvement proposal|
  |Advice|
  |User account removal|

  |Support request state|
  |:-------------------:|
  |Pending|
  |Fullfilled|
  |Canceled by client|

  Constraints based on **Support request state**:

  - Client can't cancel already fullfilled request.
  - Client can update only pending requests without assigned manager.
  - Client can submit feedback only after request is fullfilled.
  - Manager can't fullfill canceled request.

  |Support request state listing|Constraint|
  |-----------------------------|----------|
  |Pagination|5 per page|
  |Sorting|By one of states / By date|
  |Filtering|By additional message (fuzzy search), by categories|

  |File attachment extension|File content-type|
  |-------------------------|-----------------|
  |`.jpg`, `.jpeg`, `.png`, `.heic`, `.heif`|`image/jpeg`, `image/png`, `image/heic`, `image/heif`|
  |`.pdf`|`application/pdf`|
  |`.doc`, `.docx`, `.odt`|`application/msword`, `application/vnd.openxmlformats-officedocument.wordprocessingml.document`, `application/vnd.oasis.opendocument.text`|
  |`.xls`, `.xlsx`, `.ods`|`application/vnd.ms-excel`, `application/vnd.openxmlformats-officedocument.spreadsheetml.sheet`, `application/vnd.oasis.opendocument.spreadsheet`|
  
  |File|Constraint|
  |----|----------|
  |Image|2048px largest side, 10MB max|
  |PDF|20MB max|
  |Documents|10MB max|
  |Spreadsheets|2MB max|

  |Events|
  |:----:|
  |Support request created|

  |Jobs|
  |:--:|
  |Assign support request to manager|
  |Search for non-active managers|

  Manager working time: 8:00 - 18:00
