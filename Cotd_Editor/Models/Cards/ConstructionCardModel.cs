using Cotd_Logic.Models.Cards;

namespace Cotd_Editor.Models.Cards;

public class ConstructionCardModel : CardModel
{
	private int _turnsToBuild;
	private int _armor;
	private int _power;

    public ConstructionCardModel()
    {
        
    }
    public ConstructionCardModel(ConstructionCard card) : base(card)
	{
		_turnsToBuild = card.TurnsToBuild;
		_armor = card.Armor;
		_power = card.Power;
	}

	public int TurnsToBuild
	{
		get => _turnsToBuild;
		set => SetProperty(ref _turnsToBuild, value);
	}

	public int Armor
	{
		get => _armor;
		set => SetProperty(ref _armor, value);
	}

	public int Power
	{
		get => _power;
		set => SetProperty(ref _power, value);
	}
}
