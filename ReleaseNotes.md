## New in 0.2.7 (Released 2017-03-18)
* Fixed bug with data in grid columns not corresponding to headers
* Fixed bug with not working "go back" link on details and edit pages

## New in 0.2.6 (Released 2016-09-05)
* Fixed globalization, date format, datepicker for search in jqGrid
* CrudOperationResult as universal result of ICrudServiceBaseMethods
* Ability to define columns linking to any controller action

## New in 0.2.5 (Released 2016-04-18)
* jQgrid replaced with free jQgrid

## New in 0.2.4 (Released 2016-04-17)
* Datepicker fixed
* All dependent packages updated

## New in 0.2.3 (Released 2016-04-11)
* All UI related texts stored in resources files. Resources for default and pl-PL culture created.
* Validation messages (RequiredAttribute) localized. 
* Pizza.Utils assembly created.
* ValueInjection namespace as top-level in Framework.
* Useless ObjectInjectionExtensions.InjectFrom removed.
* Pizza.Mvc don't have reference to Pizza.Framework
* NHibernate configuration for IoC improved

## New in 0.2.2 (Released 2016-03-21)
* GridServiceBase renamed to CrudServiceBase
* GridControllerBase renamed to CrudControllerBase
* Some namespaces adjustation

## New in 0.2.1 (Released 2016/03/13)
* Fixed sorting by nullable enums in grid.
* Audit works also with not authenticated users.
* JS and CSS files moved to framework. 

## New in 0.2 (Released 2016/02/12)
* UserContext is no longer mocked, current logged user Id is really used for database audit.
* Additional user information can be stored in cookies and retrieved in frontend or backend side (as in sample project).
* Default implementations provides only Id (in addition to standard ASP.NET username) value in custom Principal model.
* Default security related actions (login, change password, logoff) moved to framework (controller, service).
* ASP.NET MembershipProvider is NO longer used.
* Pizza.Contracts splitted into two projects: Pizza.Contracts.Persistence and Pizza.Contracts.Presentation.
* General cleanup in references and NuGet packages.

## New in 0.1 (Released 2015/09/28)
* Initial release with base functionalities from old version.
