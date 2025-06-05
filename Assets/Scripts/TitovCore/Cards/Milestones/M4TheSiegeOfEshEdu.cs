using Unity.VisualScripting;
using UnityEngine;

namespace TitovCore.Cards.Milestones
{
    public class M4TheSiegeOfEshEdu : MilestoneCard
    {
        
        public BattleMeterHandler battleMeter;

        public void GoForward()
        {
            battleMeter.MoveForward();
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
            battleMeter.MoveBackwards();
            Debug.Log("M4TheSiegeOfEshEdu::ResolveCard -- Card Resolved.");
        }

        private void CardEffect()
        {
        }
    }
}