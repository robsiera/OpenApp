# OpenApp  - Alpha

The Goal is to Create a optiniated base framework for creating web applcations.

It will be composed of a number of a other open source prjects :

1. Asp.Net Boilerplate [https://aspnetboilerplate.com/]
* Layered Architecture
* Modular Design
* Domain Driven Design
* Well Documented
* Multi Tenancy
* User and role management

2. Vuejs [https://vuejs.org/]
* Progressive JavaScript Framework
* Approachable
* Versatile
* Performant

3. CoreUI [http://coreui.io/]
* Bootstrap 4 Admin Template

From Asp.Net Boilerplate we chose for dotnetcore, entity frameworkcore, sql server, mvc.

We replaced the BSB Admin with the CoreUI Admin Template.

We rewrite the UI of User management, Role Management and Tenant Management with generic autogenerated ui based on the Application service layer of Asp.net Boiler plate enhanced with some annotations on the Dtos.

This autogenerated UI framework included in OpenApp is made with vuejs and use the javascript proxies generated by Abp + Json schemas generated for the Application services and Dtos. This UI framework let you also rapidelly create custom crud UI for your entities.

Based on the Asp.net Bolerplate standard template, we create standard reusable modules for most of web applications including user, role and tenant managment that are available as nuget packages. And also a Mvc Starter Project for rapidely start a new application develoment.

![screenshot](https://raw.githubusercontent.com/sachatrauwaen/OpenApp/develop/screenshot-openapp.JPG)
