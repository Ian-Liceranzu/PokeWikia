using PokeApiNet;

namespace PokeWikia.Utils.Models;

/// <summary>
/// Enum with all the different encounter types
/// </summary>
public enum EncounterTypes
{
    Land,
    LandMorning,
    LandNight,
    BugContest,
    Water,
    WaterNight,
    OldRod,
    GoodRod,
    SuperRod,
    Cave,
    CaveNight,
    HeadbuttLow,
    HeadbuttHigh,
    RockSmash,
}

/// <summary>
/// Encounter information for the routes
/// </summary>
public class Encounters
{
    public string RouteId { get; set; }
    public string RouteName { get; set; }  // Add this property
    public List<WildEncounter> WildEncounters { get; set; } = [];
}

/// <summary>
/// Wild encounter information
/// </summary>
public class WildEncounter
{
    /// <summary>
    /// Frequency in which the wild encounter is triggered
    /// </summary>
    public int Frequency { get; set; }

    /// <summary>
    /// Encounter type
    /// </summary>
    public EncounterTypes EncounterType { get; set; }

    /// <summary>
    /// List with the encounter ratios for the pokemon
    /// </summary>
    public List<EncounterRatio> EncounterRatios { get; set; }
}

/// <summary>
/// Encounter information for each pokemon
/// </summary>
public class EncounterRatio
{
    /// <summary>
    /// Rate in which the pokemon may appear
    /// </summary>
    public int Rate { get; set; }

    /// <summary>
    /// Pokemon information
    /// </summary>
    public Pokemon Pokemon { get; set; }

    /// <summary>
    /// Level interval in which the pokemon appear
    /// </summary>
    public List<int> Levels { get; set; }
}