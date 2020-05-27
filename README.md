# Full Stack Example

Example full stack solution to learn more about and demonstrate the integrations between layers.

## Tech stack

- RESTful .NET API with mocked async data response using DI
- Angular 9 front-end

## Room for improvement

- Didn't batch register my services and repos, since there were only two.
- No validation on setting the HelloWorldModel
- Very minimal testing (unit and e2e) on Angular app, and no testing for API
- Needs error-handling for if the API isn't running or available

## Startup

### [API](./FullStackExample.API)

Run locally with Visual Studio or dotnet CLI.

### [Front-end](./Presentation)

Install dependencies

`
npm install
`

Compile and run the project

`
ng serve
`

Test the project

`
ng test
`
