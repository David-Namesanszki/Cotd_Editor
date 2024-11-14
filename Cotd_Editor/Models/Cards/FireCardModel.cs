using Cotd_Logic.Models.Cards;

namespace Cotd_Editor.Models.Cards;

public class FireCardModel : CardModel
{
	private int _fireCost;

    public FireCardModel()
    {
        
    }
    public FireCardModel(FireCard card) : base(card)
	{
		_fireCost = card.FireCost;
	}

	public int FireCost
	{
		get => _fireCost;
		set => SetProperty(ref _fireCost, value);
	}
}
