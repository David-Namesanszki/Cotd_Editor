using CommunityToolkit.Mvvm.ComponentModel;
using Cotd_Editor.Models.Cards;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace Cotd_Editor.VM;

public class CardEditorViewModel : ObservableRecipient
{
	private CardModel _selectedCard;
	private bool _isUnitCardSelected = true;

	public Visibility TurnsToFormationVisibility
	{
		get
		{
			return SelectedCard is UnitCardModel unitCard && unitCard.TurnsToFormation != null
				? Visibility.Visible
				: Visibility.Collapsed;
		}
	}

	public bool IsUnitCardSelected
	{
		get => _isUnitCardSelected;
		set
		{
			SetProperty(ref _isUnitCardSelected, SelectedCard is UnitCardModel);
		}
	}

    public ObservableCollection<CardModel> Cards { get; private set; } = new ObservableCollection<CardModel>();
	public CardModel SelectedCard
	{
		get => _selectedCard;
		set
		{
			SetProperty(ref _selectedCard, value);
		}
	}

	public Array CardTypes
	{
		get { return Enum.GetValues(typeof(CardTypes)); }
	}

    public CardEditorViewModel()
    {
		Cards.Add(new CommandCardModel() { Name = "Command", Description = "Attack with a unit"});
		Cards.Add(new ConstructionCardModel() { Name = "Construction", Armor = 2, TurnsToBuild = 1 });
		Cards.Add(new DreamCardModel() { Name = "Dream" });
		Cards.Add(new FireCardModel() { Name = "Fire", FireCost = 1 });
		Cards.Add(new UnitCardModel() { Name = "Unit", TurnsToFormation = 0 });
		Cards.Add(new WeatherCardModel() { Name = "Weather"});
		SelectedCard = Cards[0];
	}
}
