using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WrathForged.Database.Models.Auth;

public partial class AuthDatabase : DbContext
{
    public AuthDatabase()
    {
    }

    public AuthDatabase(DbContextOptions<AuthDatabase> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<AccountAccess> AccountAccesses { get; set; }

    public virtual DbSet<AccountBanned> AccountBanneds { get; set; }

    public virtual DbSet<AccountMuted> AccountMuteds { get; set; }

    public virtual DbSet<Autobroadcast> Autobroadcasts { get; set; }

    public virtual DbSet<BuildInfo> BuildInfos { get; set; }

    public virtual DbSet<IpBanned> IpBanneds { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<LogsIpAction> LogsIpActions { get; set; }

    public virtual DbSet<RbacAccountPermission> RbacAccountPermissions { get; set; }

    public virtual DbSet<RbacDefaultPermission> RbacDefaultPermissions { get; set; }

    public virtual DbSet<RbacPermission> RbacPermissions { get; set; }

    public virtual DbSet<Realmcharacter> Realmcharacters { get; set; }

    public virtual DbSet<Realmlist> Realmlists { get; set; }

    public virtual DbSet<SecretDigest> SecretDigests { get; set; }

    public virtual DbSet<Update> Updates { get; set; }

    public virtual DbSet<UpdatesInclude> UpdatesIncludes { get; set; }

    public virtual DbSet<Uptime> Uptimes { get; set; }

    public virtual DbSet<VwLogHistory> VwLogHistories { get; set; }

    public virtual DbSet<VwRbac> VwRbacs { get; set; }

    public void RunSqlFile(string filePath)
    {
        string sql = File.ReadAllText(filePath);
        Database.ExecuteSqlRaw(sql);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("account", tb => tb.HasComment("Account System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Username, "idx_username").IsUnique();

            entity.Property(e => e.Id)
                .HasComment("Identifier")
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("email");
            entity.Property(e => e.Expansion)
                .HasDefaultValueSql("'2'")
                .HasColumnName("expansion");
            entity.Property(e => e.FailedLogins).HasColumnName("failed_logins");
            entity.Property(e => e.Joindate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("joindate");
            entity.Property(e => e.LastAttemptIp)
                .HasMaxLength(15)
                .HasDefaultValueSql("'127.0.0.1'")
                .HasColumnName("last_attempt_ip");
            entity.Property(e => e.LastIp)
                .HasMaxLength(15)
                .HasDefaultValueSql("'127.0.0.1'")
                .HasColumnName("last_ip");
            entity.Property(e => e.LastLogin)
                .HasColumnType("timestamp")
                .HasColumnName("last_login");
            entity.Property(e => e.Locale).HasColumnName("locale");
            entity.Property(e => e.LockCountry)
                .HasMaxLength(2)
                .HasDefaultValueSql("'00'")
                .HasColumnName("lock_country");
            entity.Property(e => e.Locked).HasColumnName("locked");
            entity.Property(e => e.Muteby)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("muteby");
            entity.Property(e => e.Mutereason)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("mutereason");
            entity.Property(e => e.Mutetime).HasColumnName("mutetime");
            entity.Property(e => e.Online).HasColumnName("online");
            entity.Property(e => e.Os)
                .HasMaxLength(3)
                .HasDefaultValueSql("''")
                .HasColumnName("os");
            entity.Property(e => e.Recruiter).HasColumnName("recruiter");
            entity.Property(e => e.RegMail)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("reg_mail");
            entity.Property(e => e.Salt)
                .HasMaxLength(32)
                .IsFixedLength()
                .HasColumnName("salt");
            entity.Property(e => e.SessionKeyAuth)
                .HasMaxLength(40)
                .IsFixedLength()
                .HasColumnName("session_key_auth");
            entity.Property(e => e.SessionKeyBnet)
                .HasMaxLength(64)
                .HasColumnName("session_key_bnet");
            entity.Property(e => e.TotpSecret)
                .HasMaxLength(128)
                .HasColumnName("totp_secret");
            entity.Property(e => e.Username)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
            entity.Property(e => e.Verifier)
                .HasMaxLength(32)
                .IsFixedLength()
                .HasColumnName("verifier");
        });

        modelBuilder.Entity<AccountAccess>(entity =>
        {
            entity.HasKey(e => new { e.AccountId, e.RealmId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("account_access")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.AccountId).HasColumnName("AccountID");
            entity.Property(e => e.RealmId)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("RealmID");
            entity.Property(e => e.Comment).HasMaxLength(255);
        });

        modelBuilder.Entity<AccountBanned>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Bandate })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("account_banned", tb => tb.HasComment("Ban List"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .HasComment("Account id")
                .HasColumnName("id");
            entity.Property(e => e.Bandate).HasColumnName("bandate");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnName("active");
            entity.Property(e => e.Bannedby)
                .HasMaxLength(50)
                .HasColumnName("bannedby");
            entity.Property(e => e.Banreason)
                .HasMaxLength(255)
                .HasColumnName("banreason");
            entity.Property(e => e.Unbandate).HasColumnName("unbandate");
        });

        modelBuilder.Entity<AccountMuted>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Mutedate })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("account_muted", tb => tb.HasComment("mute List"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Mutedate).HasColumnName("mutedate");
            entity.Property(e => e.Mutedby)
                .HasMaxLength(50)
                .HasColumnName("mutedby");
            entity.Property(e => e.Mutereason)
                .HasMaxLength(255)
                .HasColumnName("mutereason");
            entity.Property(e => e.Mutetime).HasColumnName("mutetime");
        });

        modelBuilder.Entity<Autobroadcast>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Realmid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("autobroadcast")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Realmid)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("realmid");
            entity.Property(e => e.Text).HasColumnName("text");
            entity.Property(e => e.Weight)
                .HasDefaultValueSql("'1'")
                .HasColumnName("weight");
        });

        modelBuilder.Entity<BuildInfo>(entity =>
        {
            entity.HasKey(e => e.Build).HasName("PRIMARY");

            entity
                .ToTable("build_info")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Build)
                .ValueGeneratedNever()
                .HasColumnName("build");
            entity.Property(e => e.BugfixVersion).HasColumnName("bugfixVersion");
            entity.Property(e => e.HotfixVersion)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("hotfixVersion");
            entity.Property(e => e.Mac64AuthSeed)
                .HasMaxLength(32)
                .HasColumnName("mac64AuthSeed");
            entity.Property(e => e.MacChecksumSeed)
                .HasMaxLength(40)
                .HasColumnName("macChecksumSeed");
            entity.Property(e => e.MajorVersion).HasColumnName("majorVersion");
            entity.Property(e => e.MinorVersion).HasColumnName("minorVersion");
            entity.Property(e => e.Win64AuthSeed)
                .HasMaxLength(32)
                .HasColumnName("win64AuthSeed");
            entity.Property(e => e.WinAuthSeed)
                .HasMaxLength(32)
                .HasColumnName("winAuthSeed");
            entity.Property(e => e.WinChecksumSeed)
                .HasMaxLength(40)
                .HasColumnName("winChecksumSeed");
        });

        modelBuilder.Entity<IpBanned>(entity =>
        {
            entity.HasKey(e => new { e.Ip, e.Bandate })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("ip_banned", tb => tb.HasComment("Banned IPs"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Ip)
                .HasMaxLength(15)
                .HasDefaultValueSql("'127.0.0.1'")
                .HasColumnName("ip");
            entity.Property(e => e.Bandate).HasColumnName("bandate");
            entity.Property(e => e.Bannedby)
                .HasMaxLength(50)
                .HasDefaultValueSql("'[Console]'")
                .HasColumnName("bannedby");
            entity.Property(e => e.Banreason)
                .HasMaxLength(255)
                .HasDefaultValueSql("'no reason'")
                .HasColumnName("banreason");
            entity.Property(e => e.Unbandate).HasColumnName("unbandate");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("logs")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Realm).HasColumnName("realm");
            entity.Property(e => e.String)
                .HasColumnType("text")
                .HasColumnName("string");
            entity.Property(e => e.Time).HasColumnName("time");
            entity.Property(e => e.Type)
                .HasMaxLength(250)
                .HasColumnName("type");
        });

        modelBuilder.Entity<LogsIpAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logs_ip_actions", tb => tb.HasComment("Used to log ips of individual actions"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .HasComment("Unique Identifier")
                .HasColumnName("id");
            entity.Property(e => e.AccountId)
                .HasComment("Account ID")
                .HasColumnName("account_id");
            entity.Property(e => e.CharacterGuid)
                .HasComment("Character Guid")
                .HasColumnName("character_guid");
            entity.Property(e => e.Comment)
                .HasComment("Allows users to add a comment")
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.Ip)
                .HasMaxLength(15)
                .HasDefaultValueSql("'127.0.0.1'")
                .HasColumnName("ip");
            entity.Property(e => e.RealmId)
                .HasComment("Realm ID")
                .HasColumnName("realm_id");
            entity.Property(e => e.Systemnote)
                .HasComment("Notes inserted by system")
                .HasColumnType("text")
                .HasColumnName("systemnote");
            entity.Property(e => e.Time)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("Timestamp")
                .HasColumnType("timestamp")
                .HasColumnName("time");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Unixtime)
                .HasComment("Unixtime")
                .HasColumnName("unixtime");
        });

        modelBuilder.Entity<RbacAccountPermission>(entity =>
        {
            entity.HasKey(e => new { e.AccountId, e.PermissionId, e.RealmId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("rbac_account_permissions", tb => tb.HasComment("Account-Permission relation"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.PermissionId, "fk__rbac_account_roles__rbac_permissions");

            entity.Property(e => e.AccountId)
                .HasComment("Account id")
                .HasColumnName("accountId");
            entity.Property(e => e.PermissionId)
                .HasComment("Permission id")
                .HasColumnName("permissionId");
            entity.Property(e => e.RealmId)
                .HasDefaultValueSql("'-1'")
                .HasComment("Realm Id, -1 means all")
                .HasColumnName("realmId");
            entity.Property(e => e.Granted)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasComment("Granted = 1, Denied = 0")
                .HasColumnName("granted");

            entity.HasOne(d => d.Account).WithMany(p => p.RbacAccountPermissions)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("fk__rbac_account_permissions__account");

            entity.HasOne(d => d.Permission).WithMany(p => p.RbacAccountPermissions)
                .HasForeignKey(d => d.PermissionId)
                .HasConstraintName("fk__rbac_account_roles__rbac_permissions");
        });

        modelBuilder.Entity<RbacDefaultPermission>(entity =>
        {
            entity.HasKey(e => new { e.SecId, e.PermissionId, e.RealmId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("rbac_default_permissions", tb => tb.HasComment("Default permission to assign to different account security levels"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.PermissionId, "fk__rbac_default_permissions__rbac_permissions");

            entity.Property(e => e.SecId)
                .HasComment("Security Level id")
                .HasColumnName("secId");
            entity.Property(e => e.PermissionId)
                .HasComment("permission id")
                .HasColumnName("permissionId");
            entity.Property(e => e.RealmId)
                .HasDefaultValueSql("'-1'")
                .HasComment("Realm Id, -1 means all")
                .HasColumnName("realmId");

            entity.HasOne(d => d.Permission).WithMany(p => p.RbacDefaultPermissions)
                .HasForeignKey(d => d.PermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk__rbac_default_permissions__rbac_permissions");
        });

        modelBuilder.Entity<RbacPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("rbac_permissions", tb => tb.HasComment("Permission List"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("Permission id")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasComment("Permission name")
                .HasColumnName("name");

            entity.HasMany(d => d.Ids).WithMany(p => p.Linkeds)
                .UsingEntity<Dictionary<string, object>>(
                    "RbacLinkedPermission",
                    r => r.HasOne<RbacPermission>().WithMany()
                        .HasForeignKey("Id")
                        .HasConstraintName("fk__rbac_linked_permissions__rbac_permissions1"),
                    l => l.HasOne<RbacPermission>().WithMany()
                        .HasForeignKey("LinkedId")
                        .HasConstraintName("fk__rbac_linked_permissions__rbac_permissions2"),
                    j =>
                    {
                        j.HasKey("Id", "LinkedId")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("rbac_linked_permissions", tb => tb.HasComment("Permission - Linked Permission relation"))
                            .UseCollation("utf8mb4_unicode_ci");
                        j.HasIndex(new[] { "Id" }, "fk__rbac_linked_permissions__rbac_permissions1");
                        j.HasIndex(new[] { "LinkedId" }, "fk__rbac_linked_permissions__rbac_permissions2");
                        j.IndexerProperty<uint>("Id")
                            .HasComment("Permission id")
                            .HasColumnName("id");
                        j.IndexerProperty<uint>("LinkedId")
                            .HasComment("Linked Permission id")
                            .HasColumnName("linkedId");
                    });

            entity.HasMany(d => d.Linkeds).WithMany(p => p.Ids)
                .UsingEntity<Dictionary<string, object>>(
                    "RbacLinkedPermission",
                    r => r.HasOne<RbacPermission>().WithMany()
                        .HasForeignKey("LinkedId")
                        .HasConstraintName("fk__rbac_linked_permissions__rbac_permissions2"),
                    l => l.HasOne<RbacPermission>().WithMany()
                        .HasForeignKey("Id")
                        .HasConstraintName("fk__rbac_linked_permissions__rbac_permissions1"),
                    j =>
                    {
                        j.HasKey("Id", "LinkedId")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("rbac_linked_permissions", tb => tb.HasComment("Permission - Linked Permission relation"))
                            .UseCollation("utf8mb4_unicode_ci");
                        j.HasIndex(new[] { "Id" }, "fk__rbac_linked_permissions__rbac_permissions1");
                        j.HasIndex(new[] { "LinkedId" }, "fk__rbac_linked_permissions__rbac_permissions2");
                        j.IndexerProperty<uint>("Id")
                            .HasComment("Permission id")
                            .HasColumnName("id");
                        j.IndexerProperty<uint>("LinkedId")
                            .HasComment("Linked Permission id")
                            .HasColumnName("linkedId");
                    });
        });

        modelBuilder.Entity<Realmcharacter>(entity =>
        {
            entity.HasKey(e => new { e.Realmid, e.Acctid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("realmcharacters", tb => tb.HasComment("Realm Character Tracker"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Acctid, "acctid");

            entity.Property(e => e.Realmid).HasColumnName("realmid");
            entity.Property(e => e.Acctid).HasColumnName("acctid");
            entity.Property(e => e.Numchars).HasColumnName("numchars");
        });

        modelBuilder.Entity<Realmlist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("realmlist", tb => tb.HasComment("Realm System"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Name, "idx_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasDefaultValueSql("'127.0.0.1'")
                .HasColumnName("address");
            entity.Property(e => e.AllowedSecurityLevel).HasColumnName("allowedSecurityLevel");
            entity.Property(e => e.Flag)
                .HasDefaultValueSql("'2'")
                .HasColumnName("flag");
            entity.Property(e => e.Gamebuild)
                .HasDefaultValueSql("'12340'")
                .HasColumnName("gamebuild");
            entity.Property(e => e.Icon).HasColumnName("icon");
            entity.Property(e => e.LocalAddress)
                .HasMaxLength(255)
                .HasDefaultValueSql("'127.0.0.1'")
                .HasColumnName("localAddress");
            entity.Property(e => e.LocalSubnetMask)
                .HasMaxLength(255)
                .HasDefaultValueSql("'255.255.255.0'")
                .HasColumnName("localSubnetMask");
            entity.Property(e => e.Name)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Population)
                .HasColumnType("float unsigned")
                .HasColumnName("population");
            entity.Property(e => e.Port)
                .HasDefaultValueSql("'8085'")
                .HasColumnName("port");
            entity.Property(e => e.Timezone).HasColumnName("timezone");
        });

        modelBuilder.Entity<SecretDigest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("secret_digest")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Digest)
                .HasMaxLength(100)
                .HasColumnName("digest");
        });

        modelBuilder.Entity<Update>(entity =>
        {
            entity.HasKey(e => e.Name).HasName("PRIMARY");

            entity
                .ToTable("updates", tb => tb.HasComment("List of all applied updates in this database."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasComment("filename with extension of the update.")
                .HasColumnName("name");
            entity.Property(e => e.Hash)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasComment("sha1 hash of the sql file.")
                .HasColumnName("hash");
            entity.Property(e => e.Speed)
                .HasComment("time the query takes to apply in ms.")
                .HasColumnName("speed");
            entity.Property(e => e.State)
                .HasDefaultValueSql("'RELEASED'")
                .HasComment("defines if an update is released or archived.")
                .HasColumnType("enum('RELEASED','ARCHIVED')")
                .HasColumnName("state");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("timestamp when the query was applied.")
                .HasColumnType("timestamp")
                .HasColumnName("timestamp");
        });

        modelBuilder.Entity<UpdatesInclude>(entity =>
        {
            entity.HasKey(e => e.Path).HasName("PRIMARY");

            entity
                .ToTable("updates_include", tb => tb.HasComment("List of directories where we want to include sql updates."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Path)
                .HasMaxLength(200)
                .HasComment("directory to include. $ means relative to the source directory.")
                .HasColumnName("path");
            entity.Property(e => e.State)
                .HasDefaultValueSql("'RELEASED'")
                .HasComment("defines if the directory contains released or archived updates.")
                .HasColumnType("enum('RELEASED','ARCHIVED')")
                .HasColumnName("state");
        });

        modelBuilder.Entity<Uptime>(entity =>
        {
            entity.HasKey(e => new { e.Realmid, e.Starttime })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("uptime", tb => tb.HasComment("Uptime system"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Realmid).HasColumnName("realmid");
            entity.Property(e => e.Starttime).HasColumnName("starttime");
            entity.Property(e => e.Maxplayers).HasColumnName("maxplayers");
            entity.Property(e => e.Revision)
                .HasMaxLength(255)
                .HasDefaultValueSql("'Trinitycore'")
                .HasColumnName("revision");
            entity.Property(e => e.Uptime1).HasColumnName("uptime");
        });

        modelBuilder.Entity<VwLogHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_log_history");

            entity.Property(e => e.FirstLogged)
                .HasColumnType("datetime")
                .HasColumnName("First Logged");
            entity.Property(e => e.LastLogged)
                .HasColumnType("datetime")
                .HasColumnName("Last Logged");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Realm)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .UseCollation("utf8mb4_unicode_ci");
            entity.Property(e => e.String)
                .HasColumnType("text")
                .HasColumnName("string")
                .UseCollation("utf8mb4_unicode_ci");
            entity.Property(e => e.Type)
                .HasMaxLength(250)
                .HasColumnName("type")
                .UseCollation("utf8mb4_unicode_ci");
        });

        modelBuilder.Entity<VwRbac>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_rbac");

            entity.Property(e => e.Permission)
                .HasMaxLength(100)
                .HasComment("Permission name")
                .UseCollation("utf8mb4_unicode_ci");
            entity.Property(e => e.PermissionGroup)
                .HasComment("Permission id")
                .HasColumnName("Permission Group");
            entity.Property(e => e.PermissionId)
                .HasComment("Linked Permission id")
                .HasColumnName("Permission ID");
            entity.Property(e => e.SecurityLevel)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .HasColumnName("Security Level")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
