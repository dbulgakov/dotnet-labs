namespace lab04.Domain.Builders;

public sealed class CharacterBuilder
{
    private readonly Character _char = new();

    public CharacterBuilder SetStrength(int value) { _char.Strength = value; return this; }
    public CharacterBuilder SetAgility(int value) { _char.Agility = value; return this; }
    public CharacterBuilder SetIntelligence(int value) { _char.Intelligence = value; return this; }

    public Character Build() => _char;
}