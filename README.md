# Dime.Newtonsoft.Json.Extensions

![Build status](https://dev.azure.com/dimenicsbe/Utilities/_apis/build/status/dimenics.dime-newtonsoft-json-extensions?branchName=master) ![Package](https://feeds.dev.azure.com/dimenicsbe/_apis/public/Packaging/Feeds/a7b896fd-9cd8-4291-afe1-f223483d87f0/Packages/dfedbfcf-d4c8-46b7-b091-db5ef6245565/Badge)

This is a simple utility library that uses the capabilities of Newtonsoft.Json.

## Getting Started

- You must have Visual Studio 2019 Community or higher.
- The dotnet cli is also highly recommended.

## About this project

This is a simple utility library that uses the capabilities of Newtonsoft.Json. Particularly, the `Copier` class exposes a `DeepClone` method which allows to do perform deep cloning.

## Build and Test

- Run dotnet restore
- Run dotnet build
- Run dotnet test

## Installation

Use the package manager NuGet to install Dime.Rules:

- dotnet cli: `dotnet add package Dime.Newtonsoft.Json.Extensions`
- Package manager: `Install-Package Dime.Newtonsoft.Json.Extensions`

## Usage

``` csharp
    using Newtonsoft.Json.Extensions;
    
    public bool Copy(Customer originalCustomer)
    {
        Customer copiedCustomer = originalCustomer.DeepClone();
        return copiedCustomer == originalCustomer; // returns false
    }
```

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.
Please make sure to update tests as appropriate.

## License

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)