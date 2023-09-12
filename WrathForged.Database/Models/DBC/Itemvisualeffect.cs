using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Itemvisualeffect
{
    public int Id { get; set; }

    public string? Model { get; set; }

    public virtual ICollection<Itemvisual> ItemvisualSlot1Navigations { get; set; } = new List<Itemvisual>();

    public virtual ICollection<Itemvisual> ItemvisualSlot2Navigations { get; set; } = new List<Itemvisual>();

    public virtual ICollection<Itemvisual> ItemvisualSlot3Navigations { get; set; } = new List<Itemvisual>();

    public virtual ICollection<Itemvisual> ItemvisualSlot4Navigations { get; set; } = new List<Itemvisual>();

    public virtual ICollection<Itemvisual> ItemvisualSlot5Navigations { get; set; } = new List<Itemvisual>();
}
