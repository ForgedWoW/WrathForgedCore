// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Linq.Expressions;

namespace WrathForged.Models;

public class ModelInfo
{
    public Type Type { get; set; }
    public List<PropertyMeta> Properties { get; set; } = [];
    public int EstimatedSize { get; set; }
    public Func<object> CreateObj { get; }

    public ModelInfo(Type type, List<PropertyMeta> properties, int size)
    {
        Type = type;
        Properties = properties;
        EstimatedSize = size;

        var newExp = Expression.New(type);
        LambdaExpression lambda = Expression.Lambda<Func<object>>(newExp);
        CreateObj = (Func<object>)lambda.Compile();
    }
}
