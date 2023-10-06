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

    public string CommandName { get; } = "account";

    public Command AddCommand()
    {
        var accountCommands = new Command("--account", "Commands for account management");

        var newAccountCommand = new Command("create", "Creates a new account");
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

        newAccountCommand.AddArgument(emailArg);
        newAccountCommand.AddArgument(usernameArg);
        newAccountCommand.AddArgument(passwordArg);
        newAccountCommand.SetHandler((email, user, password) =>
        {
            user = user.ToUpper();
            password = password.ToUpper();
            email = email.ToUpper();
            var srp = new PasswordHasher(user, password);

            using var authDb = _classFactory.Resolve<AuthDatabase>();

            var retVal = authDb.Accounts.Add(new Account()
            {
                Email = email,
                Joindate = DateTime.UtcNow,
                RegMail = email,
                Username = user,
                Verifier = srp.V.ToProperByteArray(),
                Salt = srp.S
            });

            authDb.SaveChanges();
            _logger.Information("User account {User} under email {Email} successfully created", user, email);
        }, emailArg, usernameArg, passwordArg);

        accountCommands.AddCommand(newAccountCommand);

        return accountCommands;
    }
}