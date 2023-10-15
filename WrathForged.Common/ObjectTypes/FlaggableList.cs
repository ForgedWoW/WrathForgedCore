// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using ObservableCollections;

namespace WrathForged.Common.ObjectTypes;

public class FlaggableList<T>
{
    public ObservableList<T> Items { get; set; } = [];

    public bool IsDirty { get; set; }

    public FlaggableList() => Items.CollectionChanged += (in NotifyCollectionChangedEventArgs<T> e) => IsDirty = true;
}
