# .NET Core Job Scheduling Application

This application demonstrates a simple job scheduling system in .NET Core. It uses dependency injection and background services to execute scheduled tasks, including an API call job.

## Features

- Scheduling system to run jobs periodically.
- Integration with `IHttpClientFactory` for efficient HTTP requests.
- Example job (`ApiCallJobService`) that fetches data from a public API.
- Use of .NET Core's dependency injection and hosted services.

## Prerequisites

- .NET Core 3.1 SDK

## Project Structure

- `Program.cs`: The entry point of the application.
- `ServiceConfiguration.cs`: Configuration class for registering services and settings.
- `Services` folder:
- `IJobService.cs`: Interface for job services.
- `JobsService.cs`: Background service to execute jobs.
- `SampleJobService.cs`: Sample job implementation.
- `AnotherJobService.cs`: Another sample job implementation.
- `ApiCallJobService.cs`: Job service to perform an API call.

## Usage

Once the application is running, it will execute registered jobs periodically. The `JobsService` orchestrates the execution of these jobs, including the `ApiCallJobService`, which makes a GET request to the JSONPlaceholder API and logs the response length.

## Customization

To add more jobs, implement the `IJobService` interface and register the new job service in `ServiceConfiguration.Configure`.

## .csproj Configuration

Ensure the `.csproj` file includes necessary dependencies, particularly `Microsoft.Extensions.Http` for `IHttpClientFactory`.
