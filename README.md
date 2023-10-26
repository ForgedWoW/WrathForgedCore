# WrathForgedCore
![logo](Forged_Logo.png)
3.3.5 Emu Server written in C# using modern .NET Technologies and standards. Uses Trinity core Database and AuthServer.

Actively accepts Pull Requests.

#### Contributing
When contributing, please enable code cleanup on save. Options > Text Editor > Code Cleanup and select Run Code Cleanup profile on save.

To configure code cleanup to use the editorconfig within the project, go to Analyze > Code Cleanup > Configure Code Cleanup. Under Included Fixers only have  “Fix all warnings and errors set in EditorConfig” and “Fix analyzers warning and errors set in EditorConfig enabled.

## Architecture
![Architecture](Architecture.png)


### Technologies
- .NET 8.0
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

## Setup
### Requirements
- .NET 7.0 installed
- [Trinity Core Database: Create](https://github.com/TrinityCore/TrinityCore/blob/3.3.5/sql/create/create_mysql.sql)
    - [world](https://trinitycore.info/install/Database-Installation)
    - [Auth & Character](https://github.com/TrinityCore/TrinityCore/tree/3.3.5/sql/base)

## Server Commands
See [Command Line Commands](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/Help/CommandLine.md) for available available commands.


### Importing Existing DBC
This process is required for entity framework to work with the DBC files. This is a one time process. After all data is manipulated in the database. dbcs can be exported using the realm server command line.
Use your existing DBC files from your TrinityCore installation and import them into the database.

1. Create a new database in your MySQL server called `dbc`
2. Use [WDBX Editor](https://github.com/robinsch/WDBXEditor) to run the following command:

NOTE: change the paths to match your environment
Quicky convert all dbc files to sql files using a batch file.
```bash
cd "C:\WoWData\3.3.5 AC\dbc"
for %%F in (*.dbc) do (
    "C:\WoWTools\WDBX.Editor\WDBX Editor.exe" -export -f "C:\WoWData\3.3.5 AC\dbc\%%F" -b 12340 -o "C:\WoWData\3.3.5 AC\sql\%%~nF.sql"
)
```

3. Import the SQL files into your `dbc` database, [HeidiSQL](https://www.heidisql.com/) is a good tool for this.
4. Run the following SQL in this order to perpare the dbc database
    1. https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Database/sql/base/dbc/zzzAllowFK.sql - This allows foreign keys to be created by setting fields to allow null. These fields have default 0 or -1 and dont have valid mappings. in SQL with FK, these need to be null.
    2. https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Database/sql/base/dbc/zzzCleanupInvaiMappings.sql - This cleans up invalid mappings, there is invalid mappings and dead data in 3.3.5 dbc files. these are non existing mappings from over versions.
    3. https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Database/sql/base/dbc/zzzUpdateDefaultValues.sql - fields that have foreign keys and have a default value such as 0 or -1, these need to be null to denote to the foreign key that there is no mapping as the value is default.
    4. https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Database/sql/base/dbc/zzzzAlterTables.sql - Sets the FK on the tables.


## Extendability
Impliment the interface `IRegisterDependancyInjection` to be passed the DI container, logger and configuraiton. You can also impliment any scripting interface and it will automatically be loaded into the DI container (interfaces with base type of `IForgedScript`).

See [Scripts for more help](https://github.com/ForgedWoW/WrathForgedCore/blob/main/Help/Scripts.md) NOTE: all scripts have `IForgedScript` as the base script and are loaded into the DI container automatically as a singleton. Use `IRegisterDependancyInjection` to manually register if you require a different pattern. 