using UnityEngine;

namespace TitovCore.Cards.Milestones
{
    public class M3TheTurnOfTheWheel : MilestoneCard
    {
        private void Start()
        {
            Type = CardType.Milestone;
        }

        public void AssembleMightyHost()
        {
            Debug.Log("M3TheTurnOfTheWheel::AssembleMightyHost -- Executed");
        }
        
        public void GatherACoalition()
        {
            Debug.Log("M3TheTurnOfTheWheel::GatherACoalition -- Executed");
        }
        
        public override void ResolveCard()
        {
            Debug.Log("M3TheTurnOfTheWheel::ResolveCard -- Card Resolved.");
        }
        
    }
}