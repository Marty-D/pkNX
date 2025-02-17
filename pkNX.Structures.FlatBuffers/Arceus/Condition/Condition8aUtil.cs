﻿using System;
using System.Linq;

namespace pkNX.Structures.FlatBuffers;

public static class Condition8aUtil
{
    public static string GetConditionTypeSummary(this IHasCondition8a cond)
    {
        if (!Enum.IsDefined(typeof(ConditionType8a), cond.ConditionTypeID))
            return $"0x{(ulong)cond.ConditionTypeID:X16}";
        //throw new ArgumentOutOfRangeException(nameof(cond.ConditionTypeID), cond.ConditionTypeID, "Unknown.");
        return $"{cond.ConditionTypeID}";
    }

    public static string GetConditionArgsSummary(this IHasCondition8a cond)
    {
        var args = new[] { cond.ConditionArg1, cond.ConditionArg2, cond.ConditionArg3, cond.ConditionArg4, cond.ConditionArg5 };
        var firstEmpty = -1;
        for (var i = 0; i < args.Length; i++)
        {
            if (firstEmpty >= 0 && !string.IsNullOrEmpty(args[i]))
                throw new ArgumentException($"Invalid ConditionArg at index {i}!");
            else if (firstEmpty < 0 && string.IsNullOrEmpty(args[i]))
                firstEmpty = i;
        }

        return string.Join(", ", args.Select(s => $"\"{s}\"").Take(firstEmpty >= 0 ? firstEmpty : args.Length));
    }

    public static string GetConditionSummary(this IHasCondition8a cond)
    {
        if (!Enum.IsDefined(typeof(Condition8a), cond.ConditionID))
            throw new ArgumentOutOfRangeException(nameof(cond.ConditionID), cond.ConditionID, "Unknown.");
        return $"{cond.ConditionID}({GetConditionArgsSummary(cond)})";
    }
}
