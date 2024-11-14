using CommunityToolkit.Mvvm.ComponentModel;
using Cotd_Logic.Models.Cards;

namespace Cotd_Editor.Models.Cards;

public enum CardTypes
{
	CommandCard,
	ConstructionCard,
	DreamCard,
	FireCard,
	UnitCard,
	WeatherCard,
	Undefined,
}

public class CardModel : ObservableObject
{
	private string _name = string.Empty;
	private string _description = string.Empty;
	private CardTypes _cardType = CardTypes.Undefined;
	private string _image = string.Empty;
	private int _envoyCost = 0;

    public CardModel()
    {
        
    }
    public CardModel(Card card)
    {
        _name = card.Name;
		_description = card.Description;
		_image = card.Image;
		_cardType = (CardTypes)card.CardType;
		_envoyCost = card.EnvoyCost;
    }

    public string Name
	{
		get => _name;
		set => SetProperty(ref _name, value);
	}

	public string Description
	{
		get => _description;
		set => SetProperty(ref _description, value);
	}

	public CardTypes CardType
	{
		get => _cardType;
		set => SetProperty(ref _cardType, value);
	}

	public string Image
	{
		get => _image;
		set => SetProperty(ref _image, value);
	}

	public int EnvoyCost
	{
		get => _envoyCost;
		set => SetProperty(ref _envoyCost, value);
	}

	public void CopyFrom(CardModel source)
	{
		if (source == null)
		{
			throw new ArgumentNullException(nameof(source));
		}

		// Copy properties from the source to the current instance
		Name = source.Name;
		Description = source.Description;
		CardType = source.CardType;
		Image = source.Image;
		EnvoyCost = source.EnvoyCost;
	}

	public string CardTypeDisplayName => CardType.ToString();
}