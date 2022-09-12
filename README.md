# Readme

## Project Overview
This project is used to demonstrate core CI/CD practices. It is set up the following way:

### .NET Core MVC Application
Simple application that can be deployed to show Continuous Deployment results. Main project is `MVCApp` that only focuses on the `Home` model, view, and controller for demonstration purposes.

### .NET Core Unit Tests
Simple standalone unit tests in the `MyUnitTests` project for demonstrative purposes only. These unit tests are unrelated to the main web application and are strictly to be run for CI purposes.

### GitHub Actions
Actions set up in the `.github/workflows` directory that define workflows for the CI/CD pipelines.

### Azure App Service
App service that hosts the deployed application. This platform is chosen strictly for demonstrative purposes and ease of use to see CD in action.