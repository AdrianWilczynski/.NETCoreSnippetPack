# ASP.NET Core Snippet Pack

## C\# (csharp)
| Prefix                          | Renders                                                                |
| ------------------------------- | ---------------------------------------------------------------------- |
| class-namespace                 | Class and Namespace with some common Usings                            |
| interface-namespace             | Interface and Namespace with some common Usings                        |
| namespace-guess                 | Namespace based on directory structure*                                |
| method                          | Method                                                                 |
| field                           | Field                                                                  |
| _                               | Underscored field name based on preceding type**                       |

\* For namespace guessing to work your project's root folder must be in one of the following directories: repos, src, test, projects, desktop. Folder name matching is case insensitive.\
\*\* It's not going to work for any "crazy" type like tuple or class nested inside other generic class 

### ASP.NET Core
| Prefix                          | Renders                                                                |
| ------------------------------- | ---------------------------------------------------------------------- |
| asp-mvc-controller              | MVC Controller                                                         |
| asp-api-controller              | API Controller                                                         |
| asp-page-model                  | Razor Page Model                                                       |
| asp-view-component              | View Component Class                                                   |
| asp-action                      | MVC Action                                                             |

### Entity Framework Core
| Prefix                          | Renders                                                                |
| ------------------------------- | ---------------------------------------------------------------------- |
| ef-db-context                   | DbContext                                                              |


## Razor (aspnetcorerazor, razor) 
| Prefix                          | Renders                                                                |
| ------------------------------- | ---------------------------------------------------------------------- |
| asp-view                        | View Template                                                          |
| asp-razor-page                  | Page Template                                                          |
| asp-form-group                  | Form Group - input field, label and validation span                    |
| asp-form-group-bootstrap        | Form Group with Bootstrap's classes                                    |

### Tag Helpers
| Prefix                          | Renders                                                                |
| ------------------------------- | ---------------------------------------------------------------------- |
| asp-for                         | asp-for Tag Helper                                                     |
| asp-action                      | asp-action Tag Helper                                                  |
| asp-controller                  | asp-controller Tag Helper                                              |
| asp-area                        | asp-area Tag Helper                                                    |
| asp-route                       | asp-route Tag Helper                                                   |
| asp-page                        | asp-page Tag Helper                                                    |
| asp-page-handler                | asp-page-handler Tag Helper                                            |
| asp-validation-for              | asp-validation-for Tag Helper                                          |
| asp-validation-summary          | asp-validation-summary Tag Helper                                      |
| asp-route-...                   | asp-route-... Tag Helper                                               |
| asp-all-route-data              | asp-all-route-data Tag Helper                                          |
| asp-fragment                    | asp-fragment Tag Helper                                                |
| asp-protocol                    | asp-protocol Tag Helper                                                |
| asp-items                       | asp-items Tag Helper                                                   |
| asp-partial                     | Partial View Tag Helper                                                |
| asp-view-component              | View Component Tag Helper                                              |
| asp-cache                       | Cache Tag Helper                                                       |
| asp-environment                 | Environment Tag Helper                                                 |

## csproj (xml, msbuild) 
| Prefix                           | Renders                                                               |
| -------------------------------- | --------------------------------------------------------------------- |
| csproj-user-secrets              | UserSecretsId Element                                                 |


## appsettings (json) 
| Prefix                          | Renders                                                                |
| --------------------------------| ---------------------------------------------------------------------- |
| as-mssql-connection-string      | MS SQL LocalDB Connection String                                       |
| as-sqlite-connection-string     | SQLite Connection String                                               |