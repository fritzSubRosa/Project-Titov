using System;
using UnityEngine;
using TMPro;


namespace TitovCore.Cards
{
    public class Card
    {
        public string title;
        public string code;
        public CardType type;
        public string flavorText;
        public Type cardScript; //reference to the Monobehavior script for this card. 
        public GameObject cardPrefab; //reference to the gameobject template for this card. 
        
       // Since this is the universal    

        public Card(string _title, string _code, string _flavorText=null, Type _cardScript=null, GameObject _cardPrefab=null)
        {
            if (_code[0] == 'M') type = CardType.Milestone;
            else if (_code[0] == 'C') type = CardType.Action;
            else if (_code[0] == 'O') type = CardType.Objective;
            
            title = _title;
            code = _code;
            flavorText = _flavorText;
            cardScript = _cardScript;
            cardPrefab = _cardPrefab;
        }

        
        //Deep copies

        public Card(Card _card)
        {
            type = _card.type;
            title = _card.title;
            code = _card.code;
            flavorText = _card.flavorText ?? "";
            cardScript = _card.cardScript;
            cardPrefab = _card.cardPrefab;
        }

        public Card(string cardCode)
        {
            try
            {
                int pos = Deck.deckLookup[cardCode];
                Card _card = null;

                if (cardCode[0] == 'M') _card = Deck.AllMilestones[pos];
                else if (cardCode[0] == 'C') _card = Deck.AllActions[pos];
                else if (cardCode[0] == 'O') _card = Deck.AllObjectives[pos];

                if (_card != null)
                {
                    type = _card.type;
                    title = _card.title;
                    code = _card.code;
                    flavorText = _card.flavorText ?? "";
                    cardScript = _card.cardScript;
                    cardPrefab = _card.cardPrefab;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new ArgumentException("Card::Card -- Copy construction failed. Code not found in Global deck.", nameof(cardCode));
            }
        }
    }
}