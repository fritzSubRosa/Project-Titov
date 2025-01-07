using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace TitovCore.Cards.Milestones
{
    public class M1TheLongExile : MilestoneCard
    {
        public void EnlistTheirSoldiers()
        {
            // Cost 4 Influence
            // Replace 1 copy of "Conscription" with "Hill Country Conscription" 
            Debug.Log("M1TheLongExile::EnlistTheirSoldiers -- Executed");
        }
        
        public void IntegrateTheirNobility()
        {
            // Cost 4 Stability 
            // Gain "Hill Country Couriers"
            Debug.Log("M1TheLongExile::IntegrateTheirNobility -- Executed");
        }
        
        public override void ResolveCard()
        {
            Debug.Log("M1TheLongExile::ResolveCard -- Card Resolved.");
        }
    }
}