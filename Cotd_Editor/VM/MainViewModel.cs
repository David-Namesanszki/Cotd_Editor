using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Cotd_Editor.BL;
using Cotd_Editor.Models;
using Cotd_Editor.Models.Cards;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cotd_Editor.VM;

public class MainViewModel : ObservableRecipient
{
	private ICardService _cardService;
	private CardModel _selectedCard;

	public ObservableCollection<CardModel> Cards { get; private set; } = new ObservableCollection<CardModel>();

	public CardModel SelectedCard
	{
		get => _selectedCard;
		set => SetProperty(ref _selectedCard, value);
	}

    public ICommand AddCmd { get; set; }
    public ICommand ModCmd { get; set; }
    public ICommand DelCmd { get; set; }

    public MainViewModel()
    {
        
    }
    public MainViewModel(ICardService cardService)
	{
		_cardService = cardService;

		Cards = new ObservableCollection<CardModel>(_cardService.GetAllCards());

		AddCmd = new RelayCommand(() => _cardService.AddCard(Cards));
		ModCmd = new RelayCommand(() => _cardService.ModCard(SelectedCard));
		DelCmd = new RelayCommand(() => _cardService.DelCard(Cards, SelectedCard));
	}
}
