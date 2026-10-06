# Reflection on Using Microsoft Copilot

## Introduction

During the development of InventoryHub, Microsoft Copilot was used as a development assistant throughout the full-stack development process. The project involved creating communication between a Blazor WebAssembly front-end and an ASP.NET Core Minimal API back-end.

## Integration Code

Copilot helped generate the initial integration logic for communicating between the Blazor application and the back-end API. The front-end uses `HttpClient` to send a request to the `/api/productlist` endpoint and deserialize the returned JSON into C# objects.

Using Copilot made it easier to understand how a Blazor application can consume data from a Minimal API.

## Debugging

During the debugging stage, several potential integration problems were addressed. These included an incorrect API route, CORS restrictions, and invalid JSON responses.

Copilot helped identify the required changes and suggested error-handling techniques. The final application handles HTTP errors, invalid JSON, timeouts, and unexpected exceptions.

## JSON Structure

Copilot was also useful when creating the JSON structure returned by the API. The product objects were extended with a nested `Category` object containing an ID and name.

This helped demonstrate how structured and nested JSON data can be transferred between a back-end API and a front-end application.

## Performance Optimization

For performance optimization, in-memory caching was added to the back-end. Product data is cached for five minutes, reducing the amount of repeated processing required for subsequent API requests.

The front-end was also structured so that product data is loaded when the component is initialized rather than repeatedly requesting the same data during rendering.

## Challenges

One of the main challenges was ensuring that the front-end and back-end used the correct API route and communicated across different local ports. CORS configuration was required to allow the browser to make requests between the two applications.

Another challenge was ensuring that the C# classes correctly matched the JSON structure returned by the API.

## What I Learned

This project helped me understand how a full-stack application communicates between a front-end and back-end. I learned how to create a Minimal API, consume an API using `HttpClient`, work with JSON serialization and deserialization, configure CORS, handle API errors, and apply basic caching.

I also learned that Microsoft Copilot is most useful when its suggestions are reviewed, tested, and adapted to the specific requirements of a project rather than copied without verification.

## Conclusion

Microsoft Copilot helped speed up development and provided useful suggestions during integration, debugging, JSON structuring, and optimization. However, testing and understanding the generated code were still necessary to ensure that the final application worked correctly.
