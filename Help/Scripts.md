## Interfaces
### CoreEvents
| Interface | Description |
| --------- | ----------- |
| [IOnServerInitialize](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/Scripting/Interfaces/CoreEvents/IOnServerInitialize.cs)|Called after dependancies are injected and resolved and is the initialization of the server starting.|
| [IRegisterDependancyInjection](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/Scripting/Interfaces/CoreEvents/IRegisterDependancyInjection.cs)|Manually add your dependants to the [Grace](https://github.com/ipjohnson/Grace) DI container. These will be available for you to use via your constructor or the [ClassFactory](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/ClassFactory.cs).|
| [IUpdateLoopScript](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/Scripting/Interfaces/CoreEvents/IUpdateLoopScript.cs)|This is of type [ForgedScript](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/Scripting/Interfaces/IForgedScript.cs) and [IUpdateLoop](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/Scripting/Interfaces/CoreEvents/IUpdateLoop.cs). This will automatically register the script to the update loop as a singleton. These will live for the lifetime of the server. If you need a shorter lifetime, use [IUpdateLoop](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/Scripting/Interfaces/CoreEvents/IUpdateLoop.cs) and manage the Registration manually with [ServerUpdateLoop](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/Threading/ServerUpdateLoop.cs)|
| [IUpdateLoop](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/Scripting/Interfaces/CoreEvents/IUpdateLoop.cs)|Inherit this interface to get access to the update loop. You must register the implementation of this interface manually to [ServerUpdateLoop](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/Threading/ServerUpdateLoop.cs) You can use the scripting interface [IUpdateLoopScript](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/Scripting/Interfaces/CoreEvents/IUpdateLoopScript.cs) to automatically register the script as a singleton or you can manually register the implementation of this interface with [IOnServerInitialize](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/Scripting/Interfaces/CoreEvents/IOnServerInitialize.cs) or any point in time. If your instance is not static and not around for the entire lifetime of the server you must unregister it with [ServerUpdateLoop](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/Threading/ServerUpdateLoop.cs) you can do this through several methods including when a player disconnects with [SessionNetwork.ClientSocket.OnDisconnect](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/Networking/ClientSocket.cs#L51)|

### Command Line
Use to add addtional commands to the servers command line window.
All commands are also localized using [Localizer](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/Localization/Localizer.cs), has base class of [ClientLocalizer](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/Localization/ClientLocalizer.cs) and [Localization SQL](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Database/sql/updates/world/Locale.sql)

See [Command Line Commands](https://github.com/ForgedWoW/WrathForgedCore/blob/main/Help/CommandLine.md) for available IRootCommandAdded names.

| Interface | Description |
| --------- | ----------- |
| [ICommandLineArgumentHandler](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/CommandLine/ICommandLineArgumentHandler.cs)|Registers a new command line for the server to use. Automatically adds it to --help. [Example Impl](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/CommandLine/Commands/ProgramExitCommand.cs)|
| [IRootCommandAdded](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/CommandLine/IRootCommandAdded.cs)|Called when the root command is added to the command line. For example --account is added, create might be a subcommand of --account. You would add the sub commands in this call. You could also alter the existing root command.|

### Configuration
| Interface | Description |
| --------- | ----------- |
| [IConvertConfigValue](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/IConvertConfigValue.cs)|Used for converting custom types from a config string value. To use impliment the Interface and use `IConfiguration.GetDefaultValueWithConverter<WrathEnumConverter, ConsoleColor>("Console:HighlightColor", ConsoleColor.DarkRed);` See [Configuration Extention Methods](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/ConfigExtensionMethods.cs)|

### Serialization
You can also extend serialization to support additional types. This is useful for sending data between instance and realm server or receving data from the client.

| Interface | Description |
| --------- | ----------- |
| [IForgedTypeSerialization](https://github.com/ForgedWoW/WrathForgedCore/blob/main/WrathForged.Common/Serialization/Serializers/IForgedTypeSerialization.cs)|Used for deserializing specific properties.  See a [Full list of implimentations here.](https://github.com/ForgedWoW/WrathForgedCore/tree/main/WrathForged.Common/Serialization/Serializers)