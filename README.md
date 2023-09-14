# WrathForgedCore
![logo](Forged_Logo.png)
3.3.5 Emu Server written in C# using modern .NET Technologies and standards. Uses Trinity core Database and AuthServer.

Actively accepts Pull Requests.

## Architecture
![Architecture](Architecture.png)


### Technologies
- .NET 7.0
- OpenTelemetry
    - Zipkin and OpenTelemetryProtocol supported
- Entity Framework Core
- Serilog
- JSON configuration

## Features
- [X] DBC Database for team focused development
    - [ ] DBCs are exported from the database with a simple command or configured to be exported on startup
- [ ] Instance Servers that are scalable, no need for monolithic servers
    - A note on this, all traffic is still routed through the Realm Server so you want the Instance servers to be on the same network as the Realm Server
- [ ] Web API for server management, and front end UIs such as Account management, armory or wiki.

## Requirements
- .NET 7.0 installed
- [Trinity Core Database](https://trinitycore.info/install/Database-Installation)
- [Trinity Core AuthServer](https://github.com/TrinityCore/TrinityCore/tree/3.3.5)
