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
            int cost = 4;
            ResourceType rt = ResourceType.Influence; 
            // Cost 4 Influence
            if (GameState.Instance.SpendResource(ResourceType.Influence, cost))
            {
                      
                GameState.Instance.actions.Add(new Card("C11"));
            // Replace 1 copy of "Conscription" with "Hill Country Conscription" 
            }
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