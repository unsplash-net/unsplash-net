<div align="center>
    <h1>Unsplash SDK for .Net</h1>
    <p>
        <b>A simple and easy to use client for the <a href="https://unsplash.com/documentation#getting-started">Unsplash API</a></b>
    </p>
</div>

![CI](https://github.com/unsplash-net/unsplash-net/workflows/CI/badge.svg)
![Release to Nuget](https://github.com/unsplash-net/unsplash-net/workflows/Release%20to%20Nuget/badge.svg)
![CodeQL](https://github.com/unsplash-net/unsplash-net/workflows/CodeQL/badge.svg)

![Nuget](https://img.shields.io/nuget/v/Unsplash.Net)
![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/Unsplash.Net)

## Installation

.Net CLI

```
dotnet add package Unsplash.Net
```

## Usage

> Before using the Unsplash API, [register as a developer](https://unsplash.com/developers) and read the [API Guidelines](https://help.unsplash.com/api-guidelines/unsplash-api-guidelines).

Import and initialize the client using the public authentication token created above.

```csharp
var client = new UnsplashClient(new ApiClientOptions
{
    AccessKey = "<Token>"
});
```

Make A request to any Endpoint. For example you can call below to fetch the list of photos.

```csharp
var photos = await client.Photos.ListAsync();
```

## Contribution Guideline

At the moment I haven't got any specific guidelines for the project. Everyone are welcome to contribute.
