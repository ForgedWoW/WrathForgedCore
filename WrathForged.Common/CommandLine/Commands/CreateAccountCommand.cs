// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.CommandLine;
using Serilog;
using WrathForged.Common.Cryptography;
using WrathForged.Database.Models.Auth;

namespace WrathForged.Common.CommandLine.Commands;

public class CreateAccountCommand(ClassFactory classFactory, ILogger logger) : ICommandLineArgumentHandler
{
    private readonly ClassFactory _classFactory = classFactory;
    private readonly ILogger _logger = logger;

    public Command AddCommand()
    {
        var command = new Command("--createAccount", "Creates a new account");
        var emailArg = new Argument<string>("email", "The accounts email address")
        {
            Arity = ArgumentArity.ExactlyOne
        };
        var usernameArg = new Argument<string>("username", "username is publicly displayed")
        {
            Arity = ArgumentArity.ExactlyOne
        };
        var passwordArg = new Argument<string>("password")
        {
            Arity = ArgumentArity.ExactlyOne
        };

        command.AddArgument(emailArg);
        command.AddArgument(usernameArg);
        command.AddArgument(passwordArg);
        command.SetHandler((email, user, password) =>
        {
            user = user.ToUpper();
            password = password.ToUpper();
            var srp = new SRP6(user, password);

            using var authDb = _classFactory.Resolve<AuthDatabase>();

            var retVal = authDb.Accounts.Add(new Account()
            {
                Email = email,
                Joindate = DateTime.UtcNow,
                RegMail = email,
                Username = user,
                Verifier = srp.Verifier.ToProperByteArray(),
                Salt = srp.Salt.ToProperByteArray()
            });

            _logger.Information("User account {User} under email {Email} successfully created", user, email);
        }, emailArg, usernameArg, passwordArg);

        return command;
    }
}