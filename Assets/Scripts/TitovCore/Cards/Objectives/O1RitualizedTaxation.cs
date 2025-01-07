using UnityEngine;

namespace TitovCore.Cards.Objectives
{
    public class O1RitualizedTaxation : MonoBehaviour
    {
        private int timer = 3; 
        int timerElapsed = 0;
        
        public void Resolution()
        {
            bool conditions = true; // check here if 2 food and 1 stability was gained during the action phase. 
            if (conditions)
            {
                // choose  or Volunteers 
                
                // add Moon God's blessings directly.
                GameState.Instance.objectives.Add(new Card("O6"));
                
            }
            else
            {
                timerElapsed++;
                if (timerElapsed >= timer)
                {
                    GameState.Instance.actions.Add(new Card("C9"));
                    //return the card to the deck. 
                }
            }
        }
    }
}