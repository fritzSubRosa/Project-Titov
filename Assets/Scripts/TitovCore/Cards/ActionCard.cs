using System;
using UnityEngine;

namespace TitovCore.Cards
{
    public class ActionCard : TitovCard
    {

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