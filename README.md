dotnet_webservice_stub
======================

Simple stub for ordinary web service with well defined layers (infrastructure, domain, application services, controllers/view models), declarative transactions and mapper aboard

This project is based on 
 * NHIbernate
 * ASP MVC 3
 * Spring.NET


The app is just built around hypothetic User entity and its very simple management. 
It consists basically of four layers: controllers, application, domain and infrastructure.

In this example domain logic is divided from Controller part by special UserService, which in fact is edge of Bounded Context and might be used from anywhere (not just Controller). That is why I made it transactional. So there you can find declarative transactions. All transaction settings are placed outside the code inside xml settings, it allows the developer to keep it uniform in one place for whole application.

Declarative transaction management has the following benefits:
-Uniform control for all transactions.
-Allowing to customize transaction injections with attributes like read-only or propagation.
-Developer is able to add transaction support selectively for methods depending on needs.
-Simplified maintenance and project evolving.
-Simplified reusability of such services with transactional support.

No doubts that declarative transaction is not a silver bullet but for many domains endeed it simplifies development.
