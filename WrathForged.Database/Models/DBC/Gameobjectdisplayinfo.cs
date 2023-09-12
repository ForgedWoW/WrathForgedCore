using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Gameobjectdisplayinfo
{
    public int Id { get; set; }

    public string? ModelName { get; set; }

    public int? Sound1 { get; set; }

    public int? Sound2 { get; set; }

    public int? Sound3 { get; set; }

    public int? Sound4 { get; set; }

    public int? Sound5 { get; set; }

    public int? Sound6 { get; set; }

    public int? Sound7 { get; set; }

    public int? Sound8 { get; set; }

    public int? Sound9 { get; set; }

    public int? Sound10 { get; set; }

    public float GeoBoxMinX { get; set; }

    public float GeoBoxMinY { get; set; }

    public float GeoBoxMinZ { get; set; }

    public float GeoBoxMaxX { get; set; }

    public float GeoBoxMaxY { get; set; }

    public float GeoBoxMaxZ { get; set; }

    public int? ObjectEffectPackageId { get; set; }

    public virtual Objecteffectpackage? ObjectEffectPackage { get; set; }

    public virtual Soundentry? Sound10Navigation { get; set; }

    public virtual Soundentry? Sound1Navigation { get; set; }

    public virtual Soundentry? Sound2Navigation { get; set; }

    public virtual Soundentry? Sound3Navigation { get; set; }

    public virtual Soundentry? Sound4Navigation { get; set; }

    public virtual Soundentry? Sound5Navigation { get; set; }

    public virtual Soundentry? Sound6Navigation { get; set; }

    public virtual Soundentry? Sound7Navigation { get; set; }

    public virtual Soundentry? Sound8Navigation { get; set; }

    public virtual Soundentry? Sound9Navigation { get; set; }
}
