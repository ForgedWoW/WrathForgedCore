﻿using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Auth;

public partial class VwRbac
{
    /// <summary>
    /// Linked Permission id
    /// </summary>
    public uint PermissionId { get; set; }

    /// <summary>
    /// Permission id
    /// </summary>
    public uint PermissionGroup { get; set; }

    public string SecurityLevel { get; set; } = null!;

    /// <summary>
    /// Permission name
    /// </summary>
    public string? Permission { get; set; }
}
