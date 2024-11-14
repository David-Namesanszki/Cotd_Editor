using Cotd_Logic.Models.Cards;

namespace Cotd_Editor.Models.Cards;

public enum UnitTypes
{
	Melee,
	Ranged,
	Support
}
public class UnitCardModel : CardModel
{
	private int _turnsToFormation;
	private int _armor;
	private int _health;
	private int _power;
	private UnitTypes _type;

    public UnitCardModel()
    {
        
    }
    public UnitCardModel(UnitCard card) : base(card)
	{
		_turnsToFormation = card.TurnsToFormation;
		_armor = card.Armor;
		_health = card.Health;
		_power = card.Power;
		_type = (UnitTypes)card.Type;
	}

	public int TurnsToFormation
	{
		get => _turnsToFormation;
		set => SetProperty(ref _turnsToFormation, value);
	}

	public int Armor
	{
		get => _armor;
		set => SetProperty(ref _armor, value);
	}

	public int Health
	{
		get => _health;
		set => SetProperty(ref _health, value);
	}

	public int Power
	{
		get => _power;
		set => SetProperty(ref _power, value);
	}

	public UnitTypes Type
	{
		get => _type;
		set => SetProperty(ref _type, value);
	}
}
