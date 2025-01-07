using System;
using UnityEngine;

namespace TitovCore.Cards
{
    public class ActionCard : MonoBehaviour
    {
        public CardType Type { get; protected set; }
        public string Code { get; protected set; }
        public string Title { get; protected set; }
        public string FlavorText { get; protected set; }

        private void Start()
        {
            Type = CardType.Action;
        }
        public void SetupCard(Card card)
        {
            if (card.type != CardType.Action) return;
            Code = card.code;
            Title = card.title;
            FlavorText = card.flavorText ?? "";
        }
    }
}