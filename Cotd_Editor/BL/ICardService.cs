using Cotd_Editor.Models.Cards;

namespace Cotd_Editor.BL;

public interface ICardService
{
	void AddCard(IList<CardModel> list);
	void ModCard(CardModel cardToMod);
	void DelCard(IList<CardModel> list, CardModel card);
	IList<CardModel> GetAllCards();
}
