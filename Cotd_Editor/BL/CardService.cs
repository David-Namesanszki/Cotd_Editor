//using CommunityToolkit.Mvvm.Messaging;
//using Cotd_Editor.Models.Cards;
//using Cotd_Logic.DataAccessors.Interfaces;
//using Cotd_Logic.DataStorage.Interfaces;
//using Cotd_Logic.Models.Cards;

//namespace Cotd_Editor.BL;

//public class CardService : ICardService
//{
//	private IEditorService _service;
//	private IMessenger _messenger;
//	private ICommandCardStorage _cardStorage;
//	private IDataAccessor<Card> _cardAccessor;

//	public CardService(IEditorService service, IMessenger messenger, ICommandCardStorage cardStorage, IDataAccessor<Card> cardAccessor)
//	{
//		_service = service;
//		_messenger = messenger;
//		_cardStorage = cardStorage;
//		_cardAccessor = cardAccessor;
//	}

//	public void AddCard(IList<CardModel> list)
//	{
//		CardModel newCard = new CardModel();

//		if (_service.EditCard(newCard))
//		{
//			list.Add(newCard);
//			//_cardStorage.AddCard(newCard);
//			_messenger.Send("Add OK", "LogicResult");
//		}
//		else
//		{
//			_messenger.Send("Add CANCEL", "LogicResult");
//		}
//	}

//	public void DelCard(IList<CardModel> list, CardModel card)
//	{
//		if (card != null && list.Remove(card))
//		{
//			//_cardStorage.RemoveCard(card);
//			_messenger.Send("Delete OK", "LogicResult");
//		}
//		else
//		{
//			_messenger.Send("Delete FAIL", "LogicResult");
//		}
//	}

//	public IList<CardModel> GetAllCards()
//	{
//		return _cardAccessor.GetAll().Select(card => new CardModel(card)).ToList();
//	}

//	public void ModCard(CardModel cardToMod)
//	{
//		if (cardToMod == null)
//		{
//			_messenger.Send("Mod FAIL", "LogicResult");
//			return;
//		}
//		CardModel clone = new CardModel();
//		clone.CopyFrom(cardToMod);

//		if(_service.EditCard(clone))
//		{
//			cardToMod.CopyFrom(clone);

//			//_cardStorage.UpdateCard(cardToMod);
//			_messenger.Send("Mod OK", "LogicResult");
//		}
//        else
//        {
//			_messenger.Send("Mod CANCEL", "LogicResult");
//		}
//    }
//}
