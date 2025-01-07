using System.Collections.Generic;
using System;
using TitovCore.Cards.Milestones;
using TitovCore.Cards.Actions;
using TitovCore.Cards.Objectives;
using UnityEngine;

namespace TitovCore.Cards
{
    /// <summary>
    /// Class keeps track of entire deck. 
    /// </summary>
    public class Deck
    {
        // This makes the deck's position irrelevant 
        public static Dictionary<string, int> deckLookup = new Dictionary<string, int>(); 
        
        public static List<Card> AllMilestones = new List<Card>();
        public static List<Card> AllActions = new List<Card>();
        public static List<Card> AllObjectives = new List<Card>();

        public static void InitializeDeck()
        {
            InitMilestones();
            InitObjectives();
            InitActions();
        }

        public static void AddCard(CardType cardType, Card card)
        {
            if (cardType == CardType.Milestone)
            {
                AllMilestones.Add(card);
                deckLookup.Add(card.code, AllMilestones.Count - 1);
            }
            else if (cardType == CardType.Objective)
            {
                AllObjectives.Add(card);
                deckLookup.Add(card.code, AllObjectives.Count - 1);
            }
            else if (cardType == CardType.Action)
            {
                AllActions.Add(card);
                deckLookup.Add(card.code, AllActions.Count - 1);
            }
        }
        
        
        static void InitMilestones()
        {
            AddCard(CardType.Milestone, new Card(
                    "The Long Exile", 
                    "M1",
                    "The hill clans of the Upper Lands are a rowdy, uncouth lot. Not the ideal allies, but these are desperate times.",
                    typeof(M1TheLongExile))   
            );
            
            AddCard(CardType.Milestone, new Card(
                    "Ways of War", 
                    "M2",
                    "The Wheel-Turners were so named for their new way of war - standing armies led by chariot-riding nobles. Perhaps we may defeat them by emulating them.",
                    typeof(M2WaysOfWar))
            );
            
            AddCard(CardType.Milestone, new Card(
                    "Turn of The Wheel", 
                    "M3",
                    "The Wheel-Turner kings think our dynasty broken, friendless, defeated. Let us prove them wrong.",
                    typeof(M3TheTurnOfTheWheel))
            );
            
            AddCard(CardType.Milestone, new Card(
                    "The Siege of Esh-Edu", 
                    "M4",
                    "We have driven the invaders into their capital at Esh-Edu. They are well-provisioned. We will need to summon a great effort to dislodge them.",
                    typeof(M4TheSiegeOfEshEdu))
            );
            
            AddCard(CardType.Milestone, new Card(
                    "Act 2", 
                    "M5",
                    "The Two Lands have been reunited at last, but our victory is tinged with sorrow. Our noble king has passed beyond the horizon, taken by a Wheel-Turner arrow. He leaves a son too young to rule and a daughter to serve as regent. It now falls to them to restore our place in the world."
                )
            );

        }

        static void InitActions()
        {
            AddCard(CardType.Action, new Card(
                "Tax Collection",
                "C1",
                "Given the river’s inundation this year, I’m sure you’ll agree this is perfectly fair...", 
                typeof(C1TaxCollection)));
            
            AddCard(CardType.Action, new Card(
                "Conscription", 
                "C2", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Levy Infantry", 
                "C3", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Public Rituals", 
                "C4", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Diplomatic Overtures", 
                "C5", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "State Rituals", 
                "C6", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Royal Guard", 
                "C7", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Court Intrigue", 
                "C8", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Corruption", 
                "C9", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Blood Money", 
                "C10", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Hill Country Conscription", 
                "C11", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Hill Country Couriers", 
                "C12", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Hill Country Archers", 
                "C13", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Exorbitant Gift", 
                "C14", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Border Fort", 
                "C15", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Trading Post", 
                "C16", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Moon God Sacrifices", 
                "C17", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Corvee", 
                "C18", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Volunteers", 
                "C19", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Seditious Priests", 
                "C20", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Cataracts Vassal", 
                "C21", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Cataracts Vassal", 
                "C22", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Sable Coast Vassal", 
                "C23", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Sable Coast Vassal", 
                "C24", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Cedars Vassal", 
                "C25", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Cedars Vassal", 
                "C26", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Noble Charioteers", 
                "C27", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Trade with the Mural-Painters", 
                "C28", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Trade with the Storm-Followers", 
                "C29", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Trade with the Four Sisters", 
                "C30", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Trade with the River-Crossers", 
                "C31", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Trade with the Lord of Bulls", 
                "C32", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Trade with the Deep Desert", 
                "C33", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Trade with the Lapis-Miners", 
                "C34", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Trade with the Barrow-Builders", 
                "C35", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Trade with the Orange-Planters", 
                "C36", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "EMPTY", 
                "C37", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "EMPTY", 
                "C38", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Wheel-Turner Diplomats", 
                "C39", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Royal Flagship", 
                "C40", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Naval Patrol", 
                "C41", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Sun King's Decree", 
                "C42", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "EMPTY", 
                "C43", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Sun King's Heralds", 
                "C44", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Zealous Administration", 
                "C45", 
                ""));
        }

        static void InitObjectives()
        {
            AddCard(CardType.Objective, new Card(
                "Ritualized Taxation",
                "O1",
                "Timing tax collection to coincide with annual religious festivals should help smooth things over with the peasantry.", 
                typeof(O1RitualizedTaxation)));
            AddCard( CardType.Objective, new Card( 
                "Peasant Unrest", 
                "O2", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Uncertain Succession", 
                "O3", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Civil War", 
                "O4", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "At Sun's Edge", 
                "O5", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Moon God's Blessings", 
                "O6", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Debt Jubilee", 
                "O7", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Raise Moon Temple", 
                "O8", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Moon Temple", 
                "O9", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Plague", 
                "O10", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Raid Beyond the Cataracts", 
                "O11", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Raid the Sable Coast Princes", 
                "O12", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Raid the Cedar Kings", 
                "O13", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "War Beyond the Cataracts", 
                "O14", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "War with the Sable Coast", 
                "O15", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "War with the Cedar King", 
                "O16", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Dynasty Triumphant", 
                "O17", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Conduct Census", 
                "O18", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Raise Stele", 
                "O19", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Royal Stele", 
                "O20", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Raise Grand Monument", 
                "O21", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Grand Monument", 
                "O22", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Peasant Uprising", 
                "O23", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Envoy from the Mural-Painters", 
                "O26", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Envoy from the Storm-Followers", 
                "O27", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Envoy from the Four Sisters", 
                "O28", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Envoy from the River-Crossers", 
                "O29", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Envoy from the Lord of Bulls", 
                "O30", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Envoy from the Deep Desert", 
                "O31", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Consolidation", 
                "O35", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Border Raid", 
                "O36", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Enemy Invades!", 
                "O37", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Capital besieged!", 
                "O38", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Whispers of Treason", 
                "O39", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Seditious Conspiracy", 
                "O40", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Palace Coup", 
                "O41", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Crop Failure", 
                "O42", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Famine", 
                "O43", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Desolation", 
                "O44", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Diplomatic Incident", 
                "O45", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Foreign Claimant", 
                "O46", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Vassalization", 
                "O47", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Thunderheads", 
                "O48", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Chain Lightning", 
                "O49", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Distant Thunder", 
                "O50", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Plague Ships", 
                "O51", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Waylaid Shipping", 
                "O52", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Bride and Prejudice", 
                "O53", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Distant Thunder", 
                "O54", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Build Eternal Pyre", 
                "O55", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Fuel Eternal Pyre", 
                "O56", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Eternal Pyre", 
                "O57", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "War with the Storm-Followers", 
                "O58", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "War with the Mural-Painters", 
                "O59", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "War with the Four-Sisters", 
                "O60", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Oil Lamp Workshop", 
                "O61", 
                "Flavor text here..."));
            AddCard( CardType.Objective, new Card( 
                "Bronze Foundry", 
                "O62", 
                "Flavor text here...")); 
        }
    }
}