using UnityEngine;

namespace TitovCore.Cards.Actions
{
    public class C1TaxCollection : ActionCard
    {
        private int cost = 1; 
        private ResourceType costType = ResourceType.Stability;
        private static int timesPlayed = 0; // if this is a general thing, move to a superclass. 
        
        public void PlayCard()
        {
            if (GameState.Instance.SpendResource(costType, cost))
            {
                timesPlayed++;
                if (timesPlayed == 3)
                {
                    GameState.Instance.objectives.Add(new Card("O2"));
                    timesPlayed = 0;
                }
            }
            
        }
    }
}