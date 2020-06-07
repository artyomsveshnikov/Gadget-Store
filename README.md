## Gadget Store

### Description

ASP NET MVC Core application for simple gadget store which implies CRUD operations.

### Functionalities

- User
  - Display list of available gadgets
  - Add gadget to user's cart
  - Display list of gadgets in user cart
  - Edit items in user's cart
  - Delete items in user's cart
- Administrator
  - Manage user's roles
  - Add new gadget to store
  - Display list of all users
  - Edit user
  - Delete user
  
### To do list

- Comment on code
- Seed orders
- Implement gadget detaiils page
- Implement Edit in user cart
- Implement add new gadget with image
- Move cart to upper menu
- Do not specify mapper in controller, instead get it from services

### Architecture

The application divided by the following layers

- Controllers
- Views
- DAL
- Repositories (encapsulates database operations)
- Services (encasulates business logics from controllers)
- Models
- ViewModels

### Technologies used

- ASP NET MVC Core
- Entity Framework Core
- Identity Core
- PostgreSQL Database
- Automapper

### Screenshots