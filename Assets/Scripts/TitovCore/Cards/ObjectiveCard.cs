using System;
using UnityEngine;

namespace TitovCore.Cards
{
    public class ObjectiveCard : TitovCard
    {        
        private void Start()
        {
            Type = CardType.Objective;
        }

        public void SetupCard(Card card)
        {
            if (card.type != CardType.Objective) return;
            Code = card.code;
            Title = card.title;
            FlavorText = card.flavorText ?? "";
        }
    }
}