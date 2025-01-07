using UnityEngine;

namespace TitovCore.Cards.Milestones
{
    public class M2WaysOfWar : MilestoneCard
    {
        private void Start()
        {
            Type = CardType.Milestone;
        }

        public void EmbraceChariots()
        {
            Debug.Log("M2WaysOfWar::EmbraceChariots -- Executed");
        }
        
        public void PreserveTheOldWays()
        {
            Debug.Log("M2WaysOfWar::PreserveTheOldWays -- Executed");
        }
        
        public override void ResolveCard()
        {
            Debug.Log("M2WaysOfWar::ResolveCard -- Card Resolved.");
        }
    }
}