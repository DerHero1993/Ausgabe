# Ausgabe

A .NET 10 application named "Ausgabe". This repository contains the source code, build configuration, and basic documentation needed to build, run, and contribute to the project.

## Features
- Targets .NET 10
- Cross-platform with dotnet CLI and Visual Studio support
- Modular structure suitable for extension

## Requirements
- .NET 10 SDK (install from https://dotnet.microsoft.com)
- Visual Studio 2022/2026 or any editor that supports .NET development (optional)
- Git (for cloning the repository)

## Getting started

1. Clone the repository
   git clone https://github.com/DerHero1993/Ausgabe.git
2. Open the solution in Visual Studio:
   - Double-click `Ausgabe.slnx` or open it from Visual Studio.
   Or use the command line:
   - cd Ausgabe
   - dotnet restore
   - dotnet build

## Run

- From Visual Studio: Set the desired project as startup project and press F5 (Debug) or Ctrl+F5 (Run).
- From the command line:
  dotnet run --project ./<path-to-project>/<project>.csproj

Replace `<path-to-project>/<project>.csproj` with the actual project file path.

## Tests

- To discover and run tests via the dotnet CLI:
  dotnet test

## Configuration

- App settings and environment-specific configuration can be stored in appsettings.json and environment overrides (appsettings.Development.json). Use environment variables for secrets in CI/CD.

## Contributing

- Fork the repository and create feature branches.
- Follow repository coding style and run tests locally before submitting PRs.
- Create descriptive PRs and link related issues.

## Issues & Support

- Create issues in the GitHub repository for bugs or feature requests.
- Include reproduction steps, expected behaviour, and environment details.

## License

- Add a LICENSE file in the repository root. If unsure, consider the MIT License for permissive use.

## Contact

- Repository: https://github.com/DerHero1993/Ausgabe
