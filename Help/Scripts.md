## Interfaces
### CoreEvents
| Interface | Description |
| --------- | ----------- |
| [IOnServerInitialize](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/Scripting/Interfaces/CoreEvents/IOnServerInitialize.cs)|Called after dependancies are injected and resolved and is the initialization of the server starting.|
| [IRegisterDependancyInjection](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/Scripting/Interfaces/CoreEvents/IRegisterDependancyInjection.cs)|Manually add your dependants to the [Grace](https://github.com/ipjohnson/Grace) DI container. These will be available for you to use via your constructor or the [ClassFactory](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/ClassFactory.cs).|

### Command Line
Use to add addtional commands to the servers command line window.

| Interface | Description |
| --------- | ----------- |
| [ICommandLineArgumentHandler](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/CommandLine/ICommandLineArgumentHandler.cs)|Registers a new command line for the server to use. Automatically adds it to -help. [Example Impl](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/CommandLine/Commands/ProgramExitCommand.cs)|

### Configuration
| Interface | Description |
| --------- | ----------- |
| [IConvertConfigValue](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/IConvertConfigValue.cs)|Used for converting custom types from a config string value. To use impliment the Interface and use `IConfiguration.GetDefaultValueWithConverter<WrathEnumConverter, ConsoleColor>("Console:HighlightColor", ConsoleColor.DarkRed);` See [Configuration Extention Methods](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/ConfigExtensionMethods.cs)|
