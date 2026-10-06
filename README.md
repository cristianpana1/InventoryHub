# InventoryHub

InventoryHub is a full-stack inventory management application built using Blazor WebAssembly and ASP.NET Core Minimal API.

## Technologies

* C#
* .NET
* Blazor WebAssembly
* ASP.NET Core Minimal API
* JSON
* HttpClient
* Microsoft Copilot

## Project Structure

The project contains two applications:

* `ClientApp` – the Blazor WebAssembly front-end
* `ServerApp` – the ASP.NET Core Minimal API back-end

## API Endpoint

The back-end provides product information through:

`GET /api/productlist`

The API returns product information including:

* ID
* Name
* Price
* Stock
* Category

Each category contains its own ID and name.

## Front-End Integration

The Blazor front-end uses `HttpClient` to request product information from the back-end API.

The `FetchProducts.razor` component:

1. Sends a request to `/api/productlist`.
2. Receives the JSON response.
3. Deserializes the response into C# objects.
4. Displays the products in the browser.

## Error Handling

The application handles:

* HTTP request errors
* Invalid JSON responses
* Request timeouts
* Unexpected exceptions

## CORS

The back-end allows the Blazor front-end to access the API using CORS configuration.

## Performance Optimization

The back-end uses in-memory caching to reduce unnecessary processing for repeated requests.

Product data is cached for five minutes.

The front-end also loads the product data once when the `FetchProducts` component is initialized, avoiding unnecessary API calls during normal component rendering.

## Microsoft Copilot

Microsoft Copilot was used throughout development to help generate integration code, identify errors, improve error handling, structure JSON responses, and suggest performance improvements.
