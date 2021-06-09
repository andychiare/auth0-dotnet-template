# Auth0 Templates for .NET
The Auth0 Templates for .NET package allows you to quickly bootstrap a .NET application secured with Auth0. You can use the Auth0 Templates with the .NET CLI and Visual Studio.

## Getting started

### Requirements

* An Auth0 account. You can [sign up for a free one](https://auth0.com/signup) right now.
* .NET Core 3.1 SDK or higher.

### Installation

You can install the Auth0 Templates from the NuGet repository or from the source code.

> :warning: The current version of Auth0.Templates are not published on NuGet yet.

To work locally with the Auth0 Templates, i.e., using the templates coming from the source code, execute the following steps:

1. Clone this repository

2. Create a local NuGet package by running the following command in the root folder of the project:

   ```bash
   dotnet pack
   ```

   Your NuGet package will be generated in the `./bin/Debug/` folder.

3. Install the templates by running the following command:

   ```bash
   dotnet new -i ./bin/Debug/Auth0.Templates.2.0.0-alpha.nupkg
   ```

> :warning: **NOTE**: Currently, to make project templates available also for Visual Studio, you need to apply some additional configuration steps. Please, [take a look at this blog post](https://devblogs.microsoft.com/dotnet/net-cli-templates-in-visual-studio/).



:information_source: If you have Node.js installed on your machine, you can create and install a local NuGet package by using the following command in the root folder of the project:

```bash
npm run reinstall
```

That command also works for updating a current installed package.

## Usage

Currently, the following .NET templates are implemented:

- [Auth0 MVC Application](#Auth0-MVC-Application)
- [Auth0 Web API Application](#Auth0-Web-API-Application)
- [Auth0 Blazor Server Application](#Auth0-Blazor-Server-Application)
- [Auth0 Blazor WebAssembly Application](#Auth0-Blazor-WebAssembly-Application)



### Auth0 MVC Application

For more information about creating and securing an ASP.NET MVC application with Auth0, check out the [Auth0 ASP.NET MVC Quickstart](https://auth0.com/docs/quickstart/webapp/aspnet-core/01-login).

#### Using the .NET CLI

To create a new MVC application with the .NET CLI, you can run the following command:

```
dotnet new auth0webapp [options]
```

This will create a new MVC application in the current folder. The following template-specific options are available:

- `--domain`<br>
  The Auth0 domain associated with your tenant. The default value is `yourdomain.auth0.com`.
- `--client-id`<br>
  The client id associated with your application. The default value is `your-client-id`.
- `--client-secret`<br>
  The secret associated with your application. The default value is `your-client-secret`.
- `-f` or `--framework`<br>
  Defines the target framework to use for the .NET project. The possible values are `netcoreapp3.1` and `net5.0`. The default value is `net5.0`.



#### Using Visual Studio

To create a new MVC application with Visual Studio, select the *Auth0 ASP.NET Core App* from the *Web and Console* application group:

![Auth0 MVC Application from Visual Studio](assets/auth0-mvc-app-vs.png)

Then, provide the required options:

![Auth0 MVC Application options from Visual Studio](assets/auth0-mvc-app-vs-options.png)

### Auth0 Web API Application

For more information about creating and securing an ASP.NET Web API application with Auth0, check out the [Auth0 ASP.NET Web API Quickstart](https://auth0.com/docs/quickstart/backend/aspnet-core-webapi).

#### Using the .NET CLI

To create a new Web API application, you can run the following command:

```
dotnet new auth0webapi [options]
```

This will create a new Web API application in the current folder. The following template-specific options are available:

- `--domain`<br>
  The Auth0 domain associated with your tenant. The default value is `yourdomain.auth0.com`.
- `--api-id`<br>
  The API identifier as defined in your Auth0 dashboard. The default value is `https://your-api-id.com`
- `-f` or `--framework`<br>
  Defines the target framework to use for the .NET project. The possible values are `netcoreapp3.1` and `net5.0`. The default value is `net5.0`.
- `--no-openaPI`<br>
  It prevents OpenAPI documentation generation (`true`). The default value is `false`.



#### Using Visual Studio

To create a new Web API application with Visual Studio, select the *Auth0 ASP.NET Core Web API* from the *Web and Console* application group:

![Auth0 MVC Application from Visual Studio](assets/auth0-webapi-app-vs.png)

Then, provide the required options:

![Auth0 MVC Application options from Visual Studio](assets/auth0-webapi-app-vs-options.png)

### Auth0 Blazor Server Application

For more information about creating and securing a Blazor Server application with Auth0, check out the [Auth0 Blazor Server Tutorial](https://auth0.com/blog/what-is-blazor-tutorial-on-building-webapp-with-authentication).

#### Using the .NET CLI

To create a new Blazor Server application with the .NET CLI, you can run the following command:

```
dotnet new auth0blazorserver [options]
```

This will create a new Blazor Server application in the current folder. The following template-specific options are available:

- `--domain`<br>
  The Auth0 domain associated with your tenant. The default value is `yourdomain.auth0.com`.
- `--client-id`<br>
  The client id associated with your application. The default value is `your-client-id`.
- `--client-secret`<br>
  The secret associated with your application. The default value is `your-client-secret`.
- `-f` or `--framework`<br>
  Defines the target framework to use for the .NET project. The possible values are `netcoreapp3.1` and `net5.0`. The default value is `net5.0`.



#### Using Visual Studio

To create a new Blazor Server application with Visual Studio, select the *Auth0 Blazor Server App* from the *Web and Console* application group:

![Auth0 Blazor Server Application from Visual Studio](assets/auth0-blazorserver-app-vs.png)

Then, provide the required options:

![Auth0 Blazor Server Application options from Visual Studio](assets/auth0-blazorserver-app-vs-options.png)

### Auth0 Blazor WebAssembly Application

For more information about creating and securing a Blazor WebAssembly application with Auth0, check out the [Auth0 Blazor WebAssembly Tutorial](https://auth0.com/blog/securing-blazor-webassembly-apps/).

#### Using the .NET CLI

To create a new Blazor WebAssembly ([ASP.NET Core  hosted](https://docs.microsoft.com/en-us/aspnet/core/blazor/hosting-models)) application with the .NET CLI, you can run the following command:

```
dotnet new auth0blazorwasm [options]
```

This will create a new Blazor WebAssembly application in the current folder. The following template-specific options are available:

- `--domain`<br>
  The Auth0 domain associated with your tenant. The default value is `yourdomain.auth0.com`.
- `--client-id`<br>
  The client id associated with your application. The default value is `your-client-id`.
- `--api-id`<br>
  The API identifier as defined in your Auth0 dashboard. The default value is `https://your-api-id.com`.
- `-f` or `--framework`<br>
  Defines the target framework to use for the .NET project. The possible values are `netcoreapp3.1` and `net5.0`. The default value is `net5.0`.



#### Using Visual Studio

To create a new Blazor WebAssembly application with Visual Studio, select the *Auth0 Blazor WebAssembly App* from the *Web and Console* application group:

![Auth0 Blazor Server Application from Visual Studio](assets/auth0-blazorwasm-app-vs.png)

Then, provide the required options:

![Auth0 Blazor Server Application options from Visual Studio](assets/auth0-blazorwasm-app-vs-options.png)



## License

This project is licensed under the MIT license. See the [LICENSE](LICENSE) file for more info.

