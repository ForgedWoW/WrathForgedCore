// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.CommandLine;
using Serilog;
using WrathForged.Common.Cryptography;
using WrathForged.Database.Models.Auth;

namespace WrathForged.Common.CommandLine.Commands;

public class AccountCommands(ClassFactory classFactory, ILogger logger) : ICommandLineArgumentHandler
{
    private readonly ClassFactory _classFactory = classFactory;
    private readonly ILogger _logger = logger;

    public string CommandName { get; } = "account";

    public Command AddCommand()
    {
        var accountCommands = new Command("--account", "Commands for account management");

        accountCommands.AddCommand(CreateAccountCommand());
        accountCommands.AddCommand(DeleteAccountCommand());
        accountCommands.AddCommand(ChangePasswordCommand());

        return accountCommands;
    }

    private Command ChangePasswordCommand()
    {
        var accountCommand = new Command("changePassword", "Changes a users password");
        accountCommand.AddAlias("cp");
        accountCommand.AddAlias("changepass");
        accountCommand.AddAlias("changepassword");

        var usernameArg = new Argument<string>("user", "username or email")
        {
            Arity = ArgumentArity.ExactlyOne
        };
        var passwordArg = new Argument<string>("password", "New password")
        {
            Arity = ArgumentArity.ExactlyOne
        };
        accountCommand.AddArgument(usernameArg);
        accountCommand.AddArgument(passwordArg);
        accountCommand.SetHandler((user, password) =>
        {
            user = user.ToUpper();
            password = password.ToUpper();
            using var authDb = _classFactory.Locate<AuthDatabase>();

            if (!authDb.Accounts.Any(x => x.Username == user || x.Email == user || x.RegMail == user))
            {
                _logger.Error("User account {User} does not exist.", user);
                return;
            }

            var (Salt, Verifier) = SRP6.MakeRegistrationData(user, password);
            var account = authDb.Accounts.First(x => x.Username == user || x.Email == user || x.RegMail == user);
            account.Verifier = Verifier;
            account.Salt = Salt;
            _ = authDb.SaveChanges();
            _logger.Information("User account {User} successfully updated", user);
        }, usernameArg, passwordArg);
        return accountCommand;
    }

    private Command DeleteAccountCommand()
    {
        var accountCommand = new Command("delete", "Deletes a new account");
        accountCommand.AddAlias("remove");
        accountCommand.AddAlias("del");
        accountCommand.AddAlias("d");
        var usernameArg = new Argument<string>("user", "username or email")
        {
            Arity = ArgumentArity.ExactlyOne
        };

        accountCommand.AddArgument(usernameArg);
        accountCommand.SetHandler((user) =>
        {
            user = user.ToUpper();
            using var authDb = _classFactory.Locate<AuthDatabase>();

            if (!authDb.Accounts.Any(x => x.Username == user || x.Email == user || x.RegMail == user))
            {
                _logger.Error("User account {User} does not exist.", user);
                return;
            }

            authDb.Accounts.RemoveRange(authDb.Accounts.Where(x => x.Username == user || x.Email == user || x.RegMail == user));
            _ = authDb.SaveChanges();
            _logger.Information("User account {User} successfully deleted", user);
        }, usernameArg);
        return accountCommand;
    }

    private Command CreateAccountCommand()
    {
        var accountCommand = new Command("create", "Creates a new account");
        accountCommand.AddAlias("add");
        accountCommand.AddAlias("new");
        accountCommand.AddAlias("register");
        accountCommand.AddAlias("c");
        accountCommand.AddAlias("reg");

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

        accountCommand.AddArgument(emailArg);
        accountCommand.AddArgument(usernameArg);
        accountCommand.AddArgument(passwordArg);
        accountCommand.SetHandler((email, user, password) =>
        {
            user = user.ToUpper();
            password = password.ToUpper();
            email = email.ToUpper();
            var (Salt, Verifier) = SRP6.MakeRegistrationData(user, password);

            using var authDb = _classFactory.Locate<AuthDatabase>();

            if (authDb.Accounts.Any(x => x.Username == user || x.Email == email || x.RegMail == email))
            {
                _logger.Error("User account {User} under email {Email} already exists.", user, email);
                return;
            }

            var retVal = authDb.Accounts.Add(new Account()
            {
                Email = email,
                Joindate = DateTime.UtcNow,
                RegMail = email,
                Username = user,
                Verifier = Verifier,
                Salt = Salt
            });

            _ = authDb.SaveChanges();
            _logger.Information("User account {User} under email {Email} successfully created", user, email);
        }, emailArg, usernameArg, passwordArg);
        return accountCommand;
    }
}