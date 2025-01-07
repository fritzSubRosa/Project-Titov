using Unity.VisualScripting;
using UnityEngine;

namespace TitovCore.Cards.Milestones
{
    public class M4TheSiegeOfEshEdu : MilestoneCard
    {
        public int totalSteps;
        public int currentStep;

        public void GoForward()
        {
            if (GameState.Instance.might.Value >= 1)
            {
                GameState.Instance.might.SpendValue(1);
                currentStep++;
                if (currentStep > totalSteps)
                    WonBattle();
            }
        }

        private void LostBattle()
        {
            //Gain “Seditious Conspiracy.” Reset to 1
            // Find card in the whole set 
            // Add it to the 
        }

        private void WonBattle()
        {
            //Replace 1 active Objective with “Dynasty Triumphant.”
            //Proceed to M5.
        }
        
        public override void ResolveCard()
        {
            currentStep -= 1;
            if (currentStep < 0)
                LostBattle();
            Debug.Log("M4TheSiegeOfEshEdu::ResolveCard -- Card Resolved.");
        }

        private void CardEffect()
        {
            currentStep -= 3;
            if (currentStep < 0)
            {
                LostBattle();
            }
        }
    }
}