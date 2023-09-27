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

    public virtual DbSet<InstanceList> InstanceLists { get; set; }

    public virtual DbSet<InstanceMaps> InstanceMaps { get; set; }

    public virtual DbSet<InstanceCharacters> InstanceCharacters { get; set; }

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
        var sql = File.ReadAllText(filePath);
        _ = Database.ExecuteSqlRaw(sql);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        _ = modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        _ = modelBuilder.Entity<Account>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("account", tb => tb.HasComment("Account System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Username, "idx_username").IsUnique();

            _ = entity.Property(e => e.Id)
                .HasComment("Identifier")
                .HasColumnName("id");
            _ = entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("email");
            _ = entity.Property(e => e.Expansion)
                .HasDefaultValueSql("'2'")
                .HasColumnName("expansion");
            _ = entity.Property(e => e.FailedLogins).HasColumnName("failed_logins");
            _ = entity.Property(e => e.Joindate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("joindate");
            _ = entity.Property(e => e.LastAttemptIp)
                .HasMaxLength(15)
                .HasDefaultValueSql("'127.0.0.1'")
                .HasColumnName("last_attempt_ip");
            _ = entity.Property(e => e.LastIp)
                .HasMaxLength(15)
                .HasDefaultValueSql("'127.0.0.1'")
                .HasColumnName("last_ip");
            _ = entity.Property(e => e.LastLogin)
                .HasColumnType("timestamp")
                .HasColumnName("last_login");
            _ = entity.Property(e => e.Locale).HasColumnName("locale");
            _ = entity.Property(e => e.LockCountry)
                .HasMaxLength(2)
                .HasDefaultValueSql("'00'")
                .HasColumnName("lock_country");
            _ = entity.Property(e => e.Locked).HasColumnName("locked");
            _ = entity.Property(e => e.Muteby)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("muteby");
            _ = entity.Property(e => e.Mutereason)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("mutereason");
            _ = entity.Property(e => e.Mutetime).HasColumnName("mutetime");
            _ = entity.Property(e => e.Online).HasColumnName("online");
            _ = entity.Property(e => e.Os)
                .HasMaxLength(3)
                .HasDefaultValueSql("''")
                .HasColumnName("os");
            _ = entity.Property(e => e.Recruiter).HasColumnName("recruiter");
            _ = entity.Property(e => e.RegMail)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("reg_mail");
            _ = entity.Property(e => e.Salt)
                .HasMaxLength(32)
                .IsFixedLength()
                .HasColumnName("salt");
            _ = entity.Property(e => e.SessionKeyAuth)
                .HasMaxLength(40)
                .IsFixedLength()
                .HasColumnName("session_key_auth");
            _ = entity.Property(e => e.SessionKeyBnet)
                .HasMaxLength(64)
                .HasColumnName("session_key_bnet");
            _ = entity.Property(e => e.TotpSecret)
                .HasMaxLength(128)
                .HasColumnName("totp_secret");
            _ = entity.Property(e => e.Username)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
            _ = entity.Property(e => e.Verifier)
                .HasMaxLength(32)
                .IsFixedLength()
                .HasColumnName("verifier");
        });

        _ = modelBuilder.Entity<AccountAccess>(entity =>
        {
            _ = entity.HasKey(e => new { e.AccountId, e.RealmId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("account_access")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.AccountId).HasColumnName("AccountID");
            _ = entity.Property(e => e.RealmId)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("RealmID");
            _ = entity.Property(e => e.Comment).HasMaxLength(255);
        });

        _ = modelBuilder.Entity<AccountBanned>(entity =>
        {
            _ = entity.HasKey(e => new { e.Id, e.Bandate })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("account_banned", tb => tb.HasComment("Ban List"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .HasComment("Account id")
                .HasColumnName("id");
            _ = entity.Property(e => e.Bandate).HasColumnName("bandate");
            _ = entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnName("active");
            _ = entity.Property(e => e.Bannedby)
                .HasMaxLength(50)
                .HasColumnName("bannedby");
            _ = entity.Property(e => e.Banreason)
                .HasMaxLength(255)
                .HasColumnName("banreason");
            _ = entity.Property(e => e.Unbandate).HasColumnName("unbandate");
        });

        _ = modelBuilder.Entity<AccountMuted>(entity =>
        {
            _ = entity.HasKey(e => new { e.Guid, e.Mutedate })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("account_muted", tb => tb.HasComment("mute List"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            _ = entity.Property(e => e.Mutedate).HasColumnName("mutedate");
            _ = entity.Property(e => e.Mutedby)
                .HasMaxLength(50)
                .HasColumnName("mutedby");
            _ = entity.Property(e => e.Mutereason)
                .HasMaxLength(255)
                .HasColumnName("mutereason");
            _ = entity.Property(e => e.Mutetime).HasColumnName("mutetime");
        });

        _ = modelBuilder.Entity<Autobroadcast>(entity =>
        {
            _ = entity.HasKey(e => new { e.Id, e.Realmid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("autobroadcast")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            _ = entity.Property(e => e.Realmid)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("realmid");
            _ = entity.Property(e => e.Text).HasColumnName("text");
            _ = entity.Property(e => e.Weight)
                .HasDefaultValueSql("'1'")
                .HasColumnName("weight");
        });

        _ = modelBuilder.Entity<BuildInfo>(entity =>
        {
            _ = entity.HasKey(e => e.Build).HasName("PRIMARY");

            _ = entity
                .ToTable("build_info")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Build)
                .ValueGeneratedNever()
                .HasColumnName("build");
            _ = entity.Property(e => e.BugfixVersion).HasColumnName("bugfixVersion");
            _ = entity.Property(e => e.HotfixVersion)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("hotfixVersion");
            _ = entity.Property(e => e.Mac64AuthSeed)
                .HasMaxLength(32)
                .HasColumnName("mac64AuthSeed");
            _ = entity.Property(e => e.MacChecksumSeed)
                .HasMaxLength(40)
                .HasColumnName("macChecksumSeed");
            _ = entity.Property(e => e.MajorVersion).HasColumnName("majorVersion");
            _ = entity.Property(e => e.MinorVersion).HasColumnName("minorVersion");
            _ = entity.Property(e => e.Win64AuthSeed)
                .HasMaxLength(32)
                .HasColumnName("win64AuthSeed");
            _ = entity.Property(e => e.WinAuthSeed)
                .HasMaxLength(32)
                .HasColumnName("winAuthSeed");
            _ = entity.Property(e => e.WinChecksumSeed)
                .HasMaxLength(40)
                .HasColumnName("winChecksumSeed");
        });

        _ = modelBuilder.Entity<InstanceList>(entity =>
        {
            _ = entity.HasKey(e => e.Id);
            _ = entity.HasIndex(e => e.Realm).HasDatabaseName("FK_instancelist_realmlist");
            _ = entity.HasOne(d => d.RealmList).WithMany(p => p.InstanceLists).HasForeignKey(d => d.Realm).HasConstraintName("FK_instancelist_realmlist");
            _ = entity.HasMany(d => d.InstanceMaps).WithOne(p => p.InstanceList).HasForeignKey(d => d.InstanceId);
            _ = entity.HasMany(d => d.InstanceCharacters).WithOne(p => p.InstanceList).HasForeignKey(d => d.InstanceId);
        });

        _ = modelBuilder.Entity<InstanceMaps>(entity =>
        {
            _ = entity.HasKey(e => new { e.InstanceId, e.MapId });
            _ = entity.HasOne(d => d.InstanceList).WithMany(p => p.InstanceMaps).HasForeignKey(d => d.InstanceId);
        });

        _ = modelBuilder.Entity<InstanceCharacters>(entity =>
        {
            _ = entity.HasKey(e => new { e.InstanceId, e.AccountId, e.CharacterId });
            _ = entity.HasOne(d => d.Account).WithMany(p => p.InstanceCharacters).HasForeignKey(d => d.AccountId);
            _ = entity.HasOne(d => d.InstanceList).WithMany(p => p.InstanceCharacters).HasForeignKey(d => d.InstanceId);
        });

        _ = modelBuilder.Entity<IpBanned>(entity =>
        {
            _ = entity.HasKey(e => new { e.Ip, e.Bandate })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("ip_banned", tb => tb.HasComment("Banned IPs"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Ip)
                .HasMaxLength(15)
                .HasDefaultValueSql("'127.0.0.1'")
                .HasColumnName("ip");
            _ = entity.Property(e => e.Bandate).HasColumnName("bandate");
            _ = entity.Property(e => e.Bannedby)
                .HasMaxLength(50)
                .HasDefaultValueSql("'[Console]'")
                .HasColumnName("bannedby");
            _ = entity.Property(e => e.Banreason)
                .HasMaxLength(255)
                .HasDefaultValueSql("'no reason'")
                .HasColumnName("banreason");
            _ = entity.Property(e => e.Unbandate).HasColumnName("unbandate");
        });

        _ = modelBuilder.Entity<Log>(entity =>
        {
            _ = entity
                .HasNoKey()
                .ToTable("logs")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Level).HasColumnName("level");
            _ = entity.Property(e => e.Realm).HasColumnName("realm");
            _ = entity.Property(e => e.String)
                .HasColumnType("text")
                .HasColumnName("string");
            _ = entity.Property(e => e.Time).HasColumnName("time");
            _ = entity.Property(e => e.Type)
                .HasMaxLength(250)
                .HasColumnName("type");
        });

        _ = modelBuilder.Entity<LogsIpAction>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("logs_ip_actions", tb => tb.HasComment("Used to log ips of individual actions"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .HasComment("Unique Identifier")
                .HasColumnName("id");
            _ = entity.Property(e => e.AccountId)
                .HasComment("Account ID")
                .HasColumnName("account_id");
            _ = entity.Property(e => e.CharacterGuid)
                .HasComment("Character Guid")
                .HasColumnName("character_guid");
            _ = entity.Property(e => e.Comment)
                .HasComment("Allows users to add a comment")
                .HasColumnType("text")
                .HasColumnName("comment");
            _ = entity.Property(e => e.Ip)
                .HasMaxLength(15)
                .HasDefaultValueSql("'127.0.0.1'")
                .HasColumnName("ip");
            _ = entity.Property(e => e.RealmId)
                .HasComment("Realm ID")
                .HasColumnName("realm_id");
            _ = entity.Property(e => e.Systemnote)
                .HasComment("Notes inserted by system")
                .HasColumnType("text")
                .HasColumnName("systemnote");
            _ = entity.Property(e => e.Time)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("Timestamp")
                .HasColumnType("timestamp")
                .HasColumnName("time");
            _ = entity.Property(e => e.Type).HasColumnName("type");
            _ = entity.Property(e => e.Unixtime)
                .HasComment("Unixtime")
                .HasColumnName("unixtime");
        });

        _ = modelBuilder.Entity<RbacAccountPermission>(entity =>
        {
            _ = entity.HasKey(e => new { e.AccountId, e.PermissionId, e.RealmId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            _ = entity
                .ToTable("rbac_account_permissions", tb => tb.HasComment("Account-Permission relation"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.PermissionId, "fk__rbac_account_roles__rbac_permissions");

            _ = entity.Property(e => e.AccountId)
                .HasComment("Account id")
                .HasColumnName("accountId");
            _ = entity.Property(e => e.PermissionId)
                .HasComment("Permission id")
                .HasColumnName("permissionId");
            _ = entity.Property(e => e.RealmId)
                .HasDefaultValueSql("'-1'")
                .HasComment("Realm Id, -1 means all")
                .HasColumnName("realmId");
            _ = entity.Property(e => e.Granted)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasComment("Granted = 1, Denied = 0")
                .HasColumnName("granted");

            _ = entity.HasOne(d => d.Account).WithMany(p => p.RbacAccountPermissions)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("fk__rbac_account_permissions__account");

            _ = entity.HasOne(d => d.Permission).WithMany(p => p.RbacAccountPermissions)
                .HasForeignKey(d => d.PermissionId)
                .HasConstraintName("fk__rbac_account_roles__rbac_permissions");
        });

        _ = modelBuilder.Entity<RbacDefaultPermission>(entity =>
        {
            _ = entity.HasKey(e => new { e.SecId, e.PermissionId, e.RealmId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            _ = entity
                .ToTable("rbac_default_permissions", tb => tb.HasComment("Default permission to assign to different account security levels"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.PermissionId, "fk__rbac_default_permissions__rbac_permissions");

            _ = entity.Property(e => e.SecId)
                .HasComment("Security Level id")
                .HasColumnName("secId");
            _ = entity.Property(e => e.PermissionId)
                .HasComment("permission id")
                .HasColumnName("permissionId");
            _ = entity.Property(e => e.RealmId)
                .HasDefaultValueSql("'-1'")
                .HasComment("Realm Id, -1 means all")
                .HasColumnName("realmId");

            _ = entity.HasOne(d => d.Permission).WithMany(p => p.RbacDefaultPermissions)
                .HasForeignKey(d => d.PermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk__rbac_default_permissions__rbac_permissions");
        });

        _ = modelBuilder.Entity<RbacPermission>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("rbac_permissions", tb => tb.HasComment("Permission List"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("Permission id")
                .HasColumnName("id");
            _ = entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasComment("Permission name")
                .HasColumnName("name");

            _ = entity.HasMany(d => d.Ids).WithMany(p => p.Linkeds)
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
                        _ = j.HasKey("Id", "LinkedId")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        _ = j
                            .ToTable("rbac_linked_permissions", tb => tb.HasComment("Permission - Linked Permission relation"))
                            .UseCollation("utf8mb4_unicode_ci");
                        _ = j.HasIndex(new[] { "Id" }, "fk__rbac_linked_permissions__rbac_permissions1");
                        _ = j.HasIndex(new[] { "LinkedId" }, "fk__rbac_linked_permissions__rbac_permissions2");
                        _ = j.IndexerProperty<uint>("Id")
                            .HasComment("Permission id")
                            .HasColumnName("id");
                        _ = j.IndexerProperty<uint>("LinkedId")
                            .HasComment("Linked Permission id")
                            .HasColumnName("linkedId");
                    });

            _ = entity.HasMany(d => d.Linkeds).WithMany(p => p.Ids)
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
                        _ = j.HasKey("Id", "LinkedId")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        _ = j
                            .ToTable("rbac_linked_permissions", tb => tb.HasComment("Permission - Linked Permission relation"))
                            .UseCollation("utf8mb4_unicode_ci");
                        _ = j.HasIndex(new[] { "Id" }, "fk__rbac_linked_permissions__rbac_permissions1");
                        _ = j.HasIndex(new[] { "LinkedId" }, "fk__rbac_linked_permissions__rbac_permissions2");
                        _ = j.IndexerProperty<uint>("Id")
                            .HasComment("Permission id")
                            .HasColumnName("id");
                        _ = j.IndexerProperty<uint>("LinkedId")
                            .HasComment("Linked Permission id")
                            .HasColumnName("linkedId");
                    });
        });

        _ = modelBuilder.Entity<Realmcharacter>(entity =>
        {
            _ = entity.HasKey(e => new { e.Realmid, e.Acctid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("realmcharacters", tb => tb.HasComment("Realm Character Tracker"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Acctid, "acctid");

            _ = entity.Property(e => e.Realmid).HasColumnName("realmid");
            _ = entity.Property(e => e.Acctid).HasColumnName("acctid");
            _ = entity.Property(e => e.Numchars).HasColumnName("numchars");
        });

        _ = modelBuilder.Entity<Realmlist>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("realmlist", tb => tb.HasComment("Realm System"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.HasIndex(e => e.Name, "idx_name").IsUnique();

            _ = entity.Property(e => e.Id).HasColumnName("id");
            _ = entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasDefaultValueSql("'127.0.0.1'")
                .HasColumnName("address");
            _ = entity.Property(e => e.AllowedSecurityLevel).HasColumnName("allowedSecurityLevel");
            _ = entity.Property(e => e.Flag)
                .HasDefaultValueSql("'2'")
                .HasColumnName("flag");
            _ = entity.Property(e => e.Gamebuild)
                .HasDefaultValueSql("'12340'")
                .HasColumnName("gamebuild");
            _ = entity.Property(e => e.Icon).HasColumnName("icon");
            _ = entity.Property(e => e.LocalAddress)
                .HasMaxLength(255)
                .HasDefaultValueSql("'127.0.0.1'")
                .HasColumnName("localAddress");
            _ = entity.Property(e => e.LocalSubnetMask)
                .HasMaxLength(255)
                .HasDefaultValueSql("'255.255.255.0'")
                .HasColumnName("localSubnetMask");
            _ = entity.Property(e => e.Name)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            _ = entity.Property(e => e.Population)
                .HasColumnType("float unsigned")
                .HasColumnName("population");
            _ = entity.Property(e => e.Port)
                .HasDefaultValueSql("'8085'")
                .HasColumnName("port");
            _ = entity.Property(e => e.Timezone).HasColumnName("timezone");
        });

        _ = modelBuilder.Entity<SecretDigest>(entity =>
        {
            _ = entity.HasKey(e => e.Id).HasName("PRIMARY");

            _ = entity
                .ToTable("secret_digest")
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            _ = entity.Property(e => e.Digest)
                .HasMaxLength(100)
                .HasColumnName("digest");
        });

        _ = modelBuilder.Entity<Update>(entity =>
        {
            _ = entity.HasKey(e => e.Name).HasName("PRIMARY");

            _ = entity
                .ToTable("updates", tb => tb.HasComment("List of all applied updates in this database."))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasComment("filename with extension of the update.")
                .HasColumnName("name");
            _ = entity.Property(e => e.Hash)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasComment("sha1 hash of the sql file.")
                .HasColumnName("hash");
            _ = entity.Property(e => e.Speed)
                .HasComment("time the query takes to apply in ms.")
                .HasColumnName("speed");
            _ = entity.Property(e => e.State)
                .HasDefaultValueSql("'RELEASED'")
                .HasComment("defines if an update is released or archived.")
                .HasColumnType("enum('RELEASED','ARCHIVED')")
                .HasColumnName("state");
            _ = entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("timestamp when the query was applied.")
                .HasColumnType("timestamp")
                .HasColumnName("timestamp");
        });

        _ = modelBuilder.Entity<UpdatesInclude>(entity =>
        {
            _ = entity.HasKey(e => e.Path).HasName("PRIMARY");

            _ = entity
                .ToTable("updates_include", tb => tb.HasComment("List of directories where we want to include sql updates."))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Path)
                .HasMaxLength(200)
                .HasComment("directory to include. $ means relative to the source directory.")
                .HasColumnName("path");
            _ = entity.Property(e => e.State)
                .HasDefaultValueSql("'RELEASED'")
                .HasComment("defines if the directory contains released or archived updates.")
                .HasColumnType("enum('RELEASED','ARCHIVED')")
                .HasColumnName("state");
        });

        _ = modelBuilder.Entity<Uptime>(entity =>
        {
            _ = entity.HasKey(e => new { e.Realmid, e.Starttime })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            _ = entity
                .ToTable("uptime", tb => tb.HasComment("Uptime system"))
                .UseCollation("utf8mb4_unicode_ci");

            _ = entity.Property(e => e.Realmid).HasColumnName("realmid");
            _ = entity.Property(e => e.Starttime).HasColumnName("starttime");
            _ = entity.Property(e => e.Maxplayers).HasColumnName("maxplayers");
            _ = entity.Property(e => e.Revision)
                .HasMaxLength(255)
                .HasDefaultValueSql("'Trinitycore'")
                .HasColumnName("revision");
            _ = entity.Property(e => e.Uptime1).HasColumnName("uptime");
        });

        _ = modelBuilder.Entity<VwLogHistory>(entity =>
        {
            _ = entity
                .HasNoKey()
                .ToView("vw_log_history");

            _ = entity.Property(e => e.FirstLogged)
                .HasColumnType("datetime")
                .HasColumnName("First Logged");
            _ = entity.Property(e => e.LastLogged)
                .HasColumnType("datetime")
                .HasColumnName("Last Logged");
            _ = entity.Property(e => e.Level).HasColumnName("level");
            _ = entity.Property(e => e.Realm)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .UseCollation("utf8mb4_unicode_ci");
            _ = entity.Property(e => e.String)
                .HasColumnType("text")
                .HasColumnName("string")
                .UseCollation("utf8mb4_unicode_ci");
            _ = entity.Property(e => e.Type)
                .HasMaxLength(250)
                .HasColumnName("type")
                .UseCollation("utf8mb4_unicode_ci");
        });

        _ = modelBuilder.Entity<VwRbac>(entity =>
        {
            _ = entity
                .HasNoKey()
                .ToView("vw_rbac");

            _ = entity.Property(e => e.Permission)
                .HasMaxLength(100)
                .HasComment("Permission name")
                .UseCollation("utf8mb4_unicode_ci");
            _ = entity.Property(e => e.PermissionGroup)
                .HasComment("Permission id")
                .HasColumnName("Permission Group");
            _ = entity.Property(e => e.PermissionId)
                .HasComment("Linked Permission id")
                .HasColumnName("Permission ID");
            _ = entity.Property(e => e.SecurityLevel)
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
