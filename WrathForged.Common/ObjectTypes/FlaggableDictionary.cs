// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using ObservableCollections;

namespace WrathForged.Common.ObjectTypes;

public class FlaggableDictionary<TKey, TValue> where TKey : notnull
{
    public ObservableDictionary<TKey, TValue> Items { get; set; } = [];

    public bool IsDirty { get; set; }

    public FlaggableDictionary() => Items.CollectionChanged += (in NotifyCollectionChangedEventArgs<KeyValuePair<TKey, TValue>> e) => IsDirty = true;

}
