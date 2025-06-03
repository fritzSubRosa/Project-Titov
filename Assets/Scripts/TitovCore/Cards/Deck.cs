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

        public static void Initialize()
        {
            InitMilestones();
            InitObjectives();
            InitActions();
        }

        static void AddCard(CardType cardType, Card card)
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
                    typeof(M1TheLongExile),
                    GameManager.GetCardPrefab("MilestoneChoices"))
            );
            
            AddCard(CardType.Milestone, new Card(
                    "Ways of War", 
                    "M2",
                    "The Wheel-Turners were so named for their new way of war - standing armies led by chariot-riding nobles. Perhaps we may defeat them by emulating them.",
                    typeof(M2WaysOfWar),
                    GameManager.GetCardPrefab("MilestoneChoices"))
            );
            
            AddCard(CardType.Milestone, new Card(
                    "Turn of The Wheel", 
                    "M3",
                    "The Wheel-Turner kings think our dynasty broken, friendless, defeated. Let us prove them wrong.",
                    typeof(M3TheTurnOfTheWheel),GameManager.GetCardPrefab("MilestoneChoices"))
            );
            
            AddCard(CardType.Milestone, new Card(
                    "The Siege of Esh-Edu", 
                    "M4",
                    "We have driven the invaders into their capital at Esh-Edu. They are well-provisioned. We will need to summon a great effort to dislodge them.",
                    typeof(M4TheSiegeOfEshEdu),
                    GameManager.GetCardPrefab("BattleCard"))
            );
            
            AddCard(CardType.Milestone, new Card(
                    "Act 2", 
                    "M5",
                    "The Two Lands have been reunited at last, but our victory is tinged with sorrow. Our noble king has passed beyond the horizon, taken by a Wheel-Turner arrow. He leaves a son too young to rule and a daughter to serve as regent. It now falls to them to restore our place in the world."
                )
            );
            AddCard(CardType.Milestone, new Card(
                    "The Regency", 
                    "M6",
                    "The Lady of Gold’s regency for our young King was only meant to be temporary. But perhaps it need not be."
                )
            );

            AddCard(CardType.Milestone, new Card(
                    "The Upriver Expedition", 
                    "M7",
                    "Five ships lie low in the water, the sweet smoke of the priests’ offerings fluttering their sails. They will return with the bounty of the far south, or not at all."
                )
            );

            AddCard(CardType.Milestone, new Card(
                    "In the Land of the God", 
                    "M8",
                    "The captain sleeps and will not stir. The Great River shifts under our feet. If we are nearer to our destination or our deaths, none can be certain."
                )
            );

            AddCard(CardType.Milestone, new Card(
                    "In the Land of the God", 
                    "M9",
                    "The captain sleeps and will not stir. The Great River shifts under our feet. If we are nearer to our destination or our deaths, none can be certain."
                )
            );

            AddCard(CardType.Milestone, new Card(
                    "Legacy of the Lady of Gold", 
                    "M10",
                    "\“Where lay only ash, I sowed seeds. Where there was want, I gave succor. I go to the Gods with a light heart.\”"
                )
            );

            AddCard(CardType.Milestone, new Card(
                    "A Show of Force", 
                    "M11",
                    "flavour tk"
                )
            );

            AddCard(CardType.Milestone, new Card(
                    "Grand Naval Campaign", 
                    "M12",
                    "flavour tk"
                )
            );

            AddCard(CardType.Milestone, new Card(
                    "An Overland Campaign", 
                    "M13",
                    "flavour tk"
                )
            );

            AddCard(CardType.Milestone, new Card(
                    "Legacy of the Conqueror", 
                    "M14",
                    "flavour tk"
                )
            );

            AddCard(CardType.Milestone, new Card(
                    "Interlude - The Eclipse", 
                    "M15",
                    "Years spin into decades, decades into centuries. Our people grow and prosper, but as dynasties begin so too do they end. A young iconoclast takes the throne, the Sun Goddess burning in his heart. The priests of Father Moon oppose him - in secrecy, at first. It is the time of the Eclipse."
                )
            );

            AddCard(CardType.Milestone, new Card(
                    "The Sun Rises", 
                    "M16",
                    "\“Let the Moon Priests cower in darkness. The Sun is the one true Goddess, and I serve only Her. She shall make my reign as brilliant and terrible as She is.\”"
                )
            );

            AddCard(CardType.Milestone, new Card(
                    "Sunstroke", 
                    "M17",
                    "We have come this far. Let us not hesitate at the threshold of righteousness."
                )
            );

            AddCard(CardType.Milestone, new Card(
                    "Ill-Met by Moonlight", 
                    "M18",
                    "They meet in the temple gardens fortnightly to plan the unthinkable."
                )
            );

            AddCard(CardType.Milestone, new Card(
                    "Legacy of the Sun King", 
                    "M19",
                    "The Sun King has broken his enemies and elevated the Sun Goddess over all. But even the Sun must set."
                )
            );

            AddCard(CardType.Milestone, new Card(
                    "Legacy of the Heretic", 
                    "M20",
                    "By terror or by mercy, we must bring those the Heretic led astray back under Father Moon’s protection."
                )
            );

            AddCard(CardType.Milestone, new Card(
                    "Act 3", 
                    "M21",
                    "Our people have passed out of the Eclipse into a brilliant dawn. The Sun Goddess and the Kings who rule in Her name will guide our people to glory. We turn to them for guidance as a new century dawns."
                )
            );

            AddCard(CardType.Milestone, new Card(
                    "Act 3", 
                    "M22",
                    "Our people have passed out of the Eclipse into a harmonious equinox. Just as we are a people of Two Lands, we have become a people of Two Lights - Sun and Moon, in eternal balance. We turn to them for guidance as a new century dawns."
                )
            );

            AddCard(CardType.Milestone, new Card(
                    "Act 3", 
                    "M23",
                    "The madness of the Sun King has been put to an end - his blasphemous monuments toppled, his name itself stricken from our history. We place our fate in the firm hand of the Priests of Father Moon. We turn to them for guidance as a new century dawns."
                )
            );

            AddCard(CardType.Milestone, new Card(
                    "The Submerged Mind of Empire", 
                    "M24",
                    "The outer provinces report the arrival of a strange people to our shores. They seem to be drawn to us because of..."
                )
            );

            AddCard(CardType.Milestone, new Card(
                    "Waiting for the Barbarians", 
                    "M25",
                    "The outsiders conspire on their islands. We have received word that they have designs on the Two Lands. We must prepare."
                )
            );

            AddCard(CardType.Milestone, new Card(
                    "By Land and Sea", 
                    "M26",
                    "The enemy falls upon us. We must summon all of our strength to drive them back into the sea."
                )
            );

            AddCard(CardType.Milestone, new Card(
                    "The Storm Breaks", 
                    "M27",
                    "The invaders’ host has been smashed, but the lands around the Great Green still burn. Let us secure our victory once and for all."
                )
            );
        }

        static void InitActions()
        {
            AddCard(CardType.Action, new Card(
                "Tax Collection",
                "C1",
                "\"Given the river’s inundation this year, I’m sure you’ll agree this is perfectly fair...\"", 
                typeof(C1TaxCollection)));
            
            AddCard(CardType.Action, new Card(
                "Conscription", 
                "C2", 
                "Fame, glory, and dysentery await!"));
            
            AddCard(CardType.Action, new Card(
                "Levy Infantry", 
                "C3", 
                "Desert heat. Forced marches. Nighttime raids. And to cap it all off, I got a splinter."));
            
            AddCard(CardType.Action, new Card(
                "Public Rituals", 
                "C4", 
                "A lamb or two is a small price to pay for the favour of the Gods."));
            
            AddCard(CardType.Action, new Card(
                "Political Maneuvers", 
                "C5", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "State Rituals", 
                "C6", 
                "\"We have far too many gods for the common folk to keep track of. They need only one. Me."\""));
            
            AddCard(CardType.Action, new Card(
                "Royal Guard", 
                "C7", 
                "Take the third son of a minor house, give him a plumed helmet and bronze khopesh, and he will believe he’s a god made flesh."));
            
            AddCard(CardType.Action, new Card(
                "Court Intrigue", 
                "C8", 
                "You just would not believe the things I’ve heard..."));
            
            AddCard(CardType.Action, new Card(
                "Corruption", 
                "C9", 
                "\"Such a shame that this harvest of figs 'rotted on the vine.' Care for another, darling?\""));
            
            AddCard(CardType.Action, new Card(
                "Blood Money", 
                "C10", 
                "\"We’re security contractors. You pay us, and your villages stay safe.\""));
            
            AddCard(CardType.Action, new Card(
                "Hill Country Conscription", 
                "C11", 
                "They don't speak our tongue, but they understand the words for \"Gold\" and \"Kill\" well enough."));
            
            AddCard(CardType.Action, new Card(
                "Hill Country Couriers", 
                "C12", 
                "These hillfolk have the damndest accents, but they're undoubtedly resourceful."));
            
            AddCard(CardType.Action, new Card(
                "Hill Country Archers", 
                "C13", 
                "Just the thing for when you went someone three hundred paces away to have a very, very bad day."));
            
            AddCard(CardType.Action, new Card(
                "Exorbitant Gift", 
                "C14", 
                "\"Surely you wouldn’t be so rude as to refuse us hospitality?\""));
            
            AddCard(CardType.Action, new Card(
                "Border Fort", 
                "C15", 
                "Beer rations temporarily suspended. You know what you did."));
            
            AddCard(CardType.Action, new Card(
                "Trading Post", 
                "C16", 
                "The lifeblood of commerce. The sweat of industry. The phlegm of communicable disease."));
            
            AddCard(CardType.Action, new Card(
                "Moon God Sacrifices", 
                "C17", 
                "The priests of Father Moon are diligent, fanatical, and very quick to take offense."));
            
            AddCard(CardType.Action, new Card(
                "Corvee", 
                "C18", 
                "\"Don’t stop fanning me, damn you! Your farm can wait!\""));
            
            AddCard(CardType.Action, new Card(
                "Volunteers", 
                "C19", 
                "It’s not \"pillage\", it’s a signing bonus."));
            
            AddCard(CardType.Action, new Card(
                "Seditious Priests", 
                "C20", 
                "The omens turned sour when we curtailed the priests' privileges. Coincidence, surely."));
            
            AddCard(CardType.Action, new Card(
                "Cataracts Vassal", 
                "C21", 
                "The Upper Cataracts have bent their knees to us. In exchange for our protection, they send men for the King’s armies."));
            
            AddCard(CardType.Action, new Card(
                "Cataracts Vassal", 
                "C22", 
                "The Upper Cataracts have bent their knees to us. In exchange for our protection, they send barges of gold, grain, and salt mutton."));
            
            AddCard(CardType.Action, new Card(
                "Sable Coast Vassal", 
                "C23", 
                "The Rebel Princes have been brought to heel. In exchange for our protection, they lend us the use of their fleet of many-oared warships."));
            
            AddCard(CardType.Action, new Card(
                "Sable Coast Vassal", 
                "C24", 
                "The Rebel Princes have been brought to heel. In exchange for our protection, they send trade ships laden with ivory and cinnamon."));
            
            AddCard(CardType.Action, new Card(
                "Cedars Vassal", 
                "C25", 
                "The once-proud Cedar King has sworn his fealty to us. His armies are now ours to command."));
            
            AddCard(CardType.Action, new Card(
                "Cedars Vassal", 
                "C26", 
                "The once-proud Cedar King has sworn his fealty to us. We have commissioned a new fleet from his master shipwrights."));
            
            AddCard(CardType.Action, new Card(
                "Noble Charioteers", 
                "C27", 
                "Chariot, noun: A two-wheeled vehicle that communicates just how very important your father is."));
            
            AddCard(CardType.Action, new Card(
                "The Lady of Gold", 
                "C28", 
                "\"My mother was Great Royal Wife of the king. His, a concubine. Tell me, why should I not rule?\""));
            
            AddCard(CardType.Action, new Card(
                "The Conqueror", 
                "C29", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Moon God’s Chosen", 
                "C30", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "Temple Administration", 
                "C31", 
                "\“The Gods have tremendous appetites, you see...\”"));
            
            AddCard(CardType.Action, new Card(
                "empty", 
                "C32", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "empty", 
                "C33", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "empty", 
                "C34", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "empty", 
                "C35", 
                ""));
            
            AddCard(CardType.Action, new Card(
                "empty", 
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
                "Their loyalty may be suspect, but their knowledge of foreign courts is unparalleled"));
            
            AddCard(CardType.Action, new Card(
                "Royal Flagship", 
                "C40", 
                "flavourtk"));
            
            AddCard(CardType.Action, new Card(
                "Naval Patrol", 
                "C41", 
                "\“Give us four of those casks you ‘don’t have’ and we’ll agree that you ‘don’t have’ the other forty.\”"));
            
            AddCard(CardType.Action, new Card(
                "Sun King's Decree", 
                "C42", 
                "\"I will it to be so. That is all the instruction you require.\""));
            
            AddCard(CardType.Action, new Card(
                "High Priest of the Moon", 
                "C43", 
                "\"It's treason, then.\""));
            
            AddCard(CardType.Action, new Card(
                "Heralds of the sun", 
                "C44", 
                "We bring a universal dawn"));
            
            AddCard(CardType.Action, new Card(
                "Zealous Administration", 
                "C45", 
                "\"All the bounty of the Great River belongs to the King. Give thanks that He grants you anything at all.\""));

            AddCard(CardType.Action, new Card(
                "Storms Vassal", 
                "C46", 
                "flavourtk"));

            AddCard(CardType.Action, new Card(
                "Storms Vassal", 
                "C47", 
                "flavourtk"));

            AddCard(CardType.Action, new Card(
                "Mural-Painters Vassal", 
                "C48", 
                "flavourtk"));

            AddCard(CardType.Action, new Card(
                "Mural-Painters Vassal", 
                "C49", 
                "flavourtk"));
            
            AddCard(CardType.Action, new Card(
                "Sisters Vassal", 
                "C50", 
                ""));

            AddCard(CardType.Action, new Card(
                "Sisters Vassal", 
                "C51", 
                ""));

            AddCard(CardType.Action, new Card(
                "Terraces Vassal", 
                "C52", 
                ""));

            AddCard(CardType.Action, new Card(
                "Terraces Vassal", 
                "C53", 
                ""));

            AddCard(CardType.Action, new Card(
                "Bulls Vassal", 
                "C54", 
                ""));

            AddCard(CardType.Action, new Card(
                "Bulls Vassal", 
                "C55", 
                ""));

            AddCard(CardType.Action, new Card(
                "Rivers Vassal", 
                "C56", 
                ""));

            AddCard(CardType.Action, new Card(
                "Rivers Vassal", 
                "C57", 
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