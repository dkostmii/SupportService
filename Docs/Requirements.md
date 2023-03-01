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

```JS
// TODO: Write non-functional requirements here
```
