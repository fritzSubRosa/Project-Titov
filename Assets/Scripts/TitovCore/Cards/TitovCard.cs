using UnityEngine;

namespace TitovCore.Cards
{
    public class TitovCard : MonoBehaviour
    {
        public CardType Type { get; protected set; }
        public string Code { get; protected set; }
        public string Title { get; protected set; }
        public string FlavorText { get; protected set; }
        
        public void SetupCard(Card card)
        {
            if (card.type != Type) return;
            Code = card.code;
            Title = card.title;
            FlavorText = card.flavorText ?? "";
        }
    }
}