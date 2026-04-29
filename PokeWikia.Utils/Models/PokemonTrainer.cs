using PokeApiNet;

namespace PokeWikia.Utils.Models;

/// <summary>
/// Enum with all the trainer types
/// </summary>
public enum TrainerTypes
{
    CAMPER,
    LEADER_Brock,
    TEAMROCKET_M,
    TEAMROCKET_F,
    RIVAL1,
    CHAMPION,
    SWIMMER2_F,
    POKEMONTRAINER_May,
    COOLCOUPLE,
    LASS,
    BEAUTY,
    FISHERMAN,
    HIKER,
    PICNICKER,
    YOUNGSTER
}

/// <summary>
/// All the trainer information
/// </summary>
public class PokemonTrainer
{
    public string Name { get; set; }
    public TrainerTypes TrainerType { get; set; }
    public int? Variant { get; set; }
    public string LoseText { get; set; }
    public List<string> Items { get; set; } = new();
    public List<PokemonTeamMember> Team { get; set; } = new();

    public string DisplayName => Variant.HasValue ? $"{Name} ({Variant})" : Name;
    public string FullTitle => $"{TrainerType} {DisplayName}".Trim();

    public string TrainerSprite => GetTrainerSprite(TrainerType.ToString());

    private string GetTrainerSprite(string trainerType)
    {
        return trainerType switch
        {
            _ => "images/trainers/default.png"
        };
    }
}

public class PokemonTeamMember
{
    public string Name { get; set; }
    public int Level { get; set; }
    public string Nickname { get; set; }
    public bool IsShiny { get; set; }
    public bool IsShadow { get; set; }
    public string Item { get; set; }
    public string Ball { get; set; }
    public string Gender { get; set; }
    public int AbilityIndex { get; set; }
    public List<string> Moves { get; set; } = new();
    public List<int> IVs { get; set; } = new();
    public Pokemon PokemonData { get; set; }
    public string Sprite => PokemonData?.Sprites?.FrontDefault;
}