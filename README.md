# Dotnet Web API Deploy

This project demonstrates deploying a .NET 8 Web API to Render and AWS Elastic Beanstalk with CI/CD.

## Features
- Minimal API with `/api/Weather` endpoint
- Swagger / OpenAPI enabled for testing the API
- Deployment using Docker on Render
- Deployment on AWS Elastic Beanstalk
- GitHub Actions workflow for build and Render deploy hook (CI/CD)

## Screenshots

### Render Deployment
![Render deployment](screenshots/render_success.png)

### AWS Elastic Beanstalk Deployment
![AWS deployment](screenshots/aws_elasticbeanstalk_success.png)

## Notes
- No unit tests; API is verified via endpoint calls
- Free-tier resources used
