<div align="center">
  <h1>ASP Globalization Sample Project</h1>
  <br />
  <br />
  <a href="https://github.com/HamidMolareza/ASP-Globalization-Sample/issues/new?assignees=&labels=bug&template=BUG_REPORT.md&title=bug%3A+">Report a Bug</a>
  ·
  <a href="https://github.com/HamidMolareza/ASP-Globalization-Sample/issues/new?assignees=&labels=enhancement&template=FEATURE_REQUEST.md&title=feat%3A+">Request a Feature</a>
  .
  <a href="https://github.com/HamidMolareza/ASP-Globalization-Sample/issues/new?assignees=&labels=question&template=SUPPORT_QUESTION.md&title=support%3A+">Ask a Question</a>
</div>

<div align="center">
<br />

![Build Status](https://github.com/HamidMolareza/ASP-Globalization-Sample/actions/workflows/build.yml/badge.svg?branch=main)
![GitHub](https://img.shields.io/github/license/HamidMolareza/ASP-Globalization-Sample)
[![Pull Requests welcome](https://img.shields.io/badge/PRs-welcome-ff69b4.svg?style=flat-square)](https://github.com/HamidMolareza/ASP-Globalization-Sample/issues?q=is%3Aissue+is%3Aopen+label%3A%22help+wanted%22)

[![code with love by HamidMolareza](https://img.shields.io/badge/%3C%2F%3E%20with%20%E2%99%A5%20by-HamidMolareza-ff1414.svg?style=flat-square)](https://github.com/HamidMolareza)

</div>

## About

The ASP Globalization Sample Project is designed to demonstrate the implementation of globalization and localization in ASP.NET applications. This project showcases how to create web applications that can support multiple languages and cultures, enhancing user experience and accessibility for a global audience.

### Project Purpose and Goals

**Problem Solved:** In a world where businesses operate on a global scale, having a web application that supports multiple languages is crucial. This project addresses the challenge of creating ASP.NET applications that can easily adapt to different languages and regional settings without requiring significant changes to the codebase.

**Purpose:** The primary purpose of this project is to provide a practical example of how to implement globalization and localization in an ASP.NET web application. It aims to serve as a reference for developers looking to create applications that cater to a diverse user base.

**Objective:** The project demonstrates the following key aspects:
- How to configure ASP.NET for globalization and localization.
- How to use resource files for storing localized strings.
- How to dynamically switch languages based on user preferences or browser settings.

### Sample Supported Languages:

- en (default)
- fa

### Built With

- .NET 8

## Getting Started

### Prerequisites

- Clone project
- Install dotnet 8 or docker

### How to run?

#### Approach 1: Use dotnet

```bash
dotnet restore src
dotnet build src
dotnet run --project src/Globalization.csproj 
```

#### Approach 2: Use docker

```bash
docker build -t globalization:latest .
docker run globalization:latest
```

### How to use?

After the project is executed, you can use swagger or [Globalization.http](src/Globalization.http) file.

## Project Structure

```txt
├── appsettings.Development.json
├── appsettings.json
├── Controllers
│   └── HelloController.cs
├── Globalization.csproj
├── Globalization.http
├── Globalization.sln
├── Models
│   └── FullName.cs
├── Program.cs
├── Properties
│   └── launchSettings.json
├── Resources
│   ├── Controllers.HelloController.en.resx
│   ├── Controllers.HelloController.fa.Designer.cs
│   ├── Controllers.HelloController.fa.resx
│   └── Models
│       ├── FullName.en.resx
│       ├── FullName.fa.Designer.cs
│       ├── FullName.fa.resx
│       └── FullName.resx
└── Swagger
    └── AddHeaderOperationFilter.cs
```

## Roadmap

See the [open issues](https://github.com/HamidMolareza/ASP-Globalization-Sample/issues) for a list of proposed features (and known
issues).

- [Top Feature Requests](https://github.com/HamidMolareza/ASP-Globalization-Sample/issues?q=label%3Aenhancement+is%3Aopen+sort%3Areactions-%2B1-desc) (
  Add your votes using the 👍 reaction)
- [Top Bugs](https://github.com/HamidMolareza/ASP-Globalization-Sample/issues?q=is%3Aissue+is%3Aopen+label%3Abug+sort%3Areactions-%2B1-desc) (
  Add your votes using the 👍 reaction)
- [Newest Bugs](https://github.com/HamidMolareza/ASP-Globalization-Sample/issues?q=is%3Aopen+is%3Aissue+label%3Abug)

## Support

Reach out to the maintainer at one of the following places:

- [GitHub issues](https://github.com/HamidMolareza/ASP-Globalization-Sample/issues/new?assignees=&labels=question&template=SUPPORT_QUESTION.md&title=support%3A+)
- Contact options listed on [this GitHub profile](https://github.com/HamidMolareza)

## Contributing

First off, thanks for taking the time to contribute! Contributions are what make the free/open-source community such an
amazing place to learn, inspire, and create. Any contributions you make will benefit everybody else and are **greatly
appreciated**.

Please read [our contribution guidelines](docs/CONTRIBUTING.md), and thank you for being involved!

## Authors & contributors

The original setup of this repository is by [HamidMolareza](https://github.com/HamidMolareza).

For a full list of all authors and contributors,
see [the contributors page](https://github.com/HamidMolareza/ASP-Globalization-Sample/contributors).

## Security

This project follows good practices of security, but 100% security cannot be assured. This project is provided **"as
is"** without any **warranty**.

_For more information and to report security issues, please refer to our [security documentation](docs/SECURITY.md)._

## License

This project is licensed under the **GPLv3**.

See [LICENSE](LICENSE) for more information.

## Related

- [Globalization and localization in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/localization?view=aspnetcore-8.0)
