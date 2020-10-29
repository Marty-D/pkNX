﻿namespace pkNX.Structures
{
    public enum EvolutionType : byte
    {
        None,
        LevelUpFriendship,
        LevelUpFriendshipMorning,
        LevelUpFriendshipNight,
        LevelUp,
        Trade,
        TradeHeldItem,
        TradeSpecies,
        UseItem,
        LevelUpATK,
        LevelUpDEF,
        LevelUpAeqD,
        LevelUpECl5,
        LevelUpECgeq5,
        LevelUpNinjask,
        LevelUpShedinja,
        LevelUpBeauty,
        UseItemMale,
        UseItemFemale,
        LevelUpHeldItemDay,
        LevelUpHeldItemNight,
        LevelUpKnowMove,
        LevelUpWithTeammate,
        LevelUpMale,
        LevelUpFemale,
        LevelUpElectric,
        LevelUpForest,
        LevelUpCold,
        LevelUpInverted,
        LevelUpAffection50MoveType,
        LevelUpDarkTeammate,
        LevelUpWeather,
        LevelUpMorning,
        LevelUpNight,
        LevelUpFormFemale1,
        UNUSED,
        LevelUpVersion,
        LevelUpVersionDay,
        LevelUpVersionNight,
        LevelUpSummit,
        LevelUpDusk,
        LevelUpWormhole,
        UseItemWormhole,
        CriticalHitsInBattle,
        HitPointsLostInBattle,
        Spin,
        LevelUpNatureAmped,
        LevelUpNatureLowKey,
        TowerOfDarkness,
        TowerOfWaters,
    }

    public enum EvolutionTypeArgumentType
    {
        NoArg,
        Level,
        Items,
        Moves,
        Species,
        Stat,
        Type,
        Version,
    }
}
