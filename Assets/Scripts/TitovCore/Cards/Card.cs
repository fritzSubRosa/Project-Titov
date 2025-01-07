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
        
       // Since this is the universal    

        public Card(string _title, string _code, string _flavorText=null)
        {
            if (_code[0] == 'M') type = CardType.Milestone;
            else if (_code[0] == 'C') type = CardType.Action;
            else if (_code[0] == 'O') type = CardType.Objective;
            
            title = _title;
            code = _code;
            flavorText = _flavorText;
        }
    }
}