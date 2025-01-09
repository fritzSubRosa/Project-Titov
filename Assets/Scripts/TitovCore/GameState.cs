using System;
using System.Collections.Generic;
using TitovCore.Cards;
using TitovCore.Cards.Milestones;
using TMPro;
using UnityEngine;

namespace TitovCore
{
    
    [Serializable]
    public class GameState : MonoBehaviour
    {
        public GamePhase phase = GamePhase.Setup;
        private static GameState _instance;
        public static GameState Instance
        {
            get
            {
                if(_instance == null) _instance = GameObject.FindFirstObjectByType<GameState>();
                return _instance;
            }
        }

        #region Resources
        // CONSTANTS
        public int initialResource;
        public int initialMaxResource;
        
        public Resource food;
        [SerializeField] TextMeshProUGUI foodValue;
        [SerializeField] TextMeshProUGUI foodMax;
        
        public Resource stability;
        [SerializeField] TextMeshProUGUI stabilityValue;
        [SerializeField] TextMeshProUGUI stabilityMax;
        
        public Resource might;
        [SerializeField] TextMeshProUGUI mightValue;
        [SerializeField] TextMeshProUGUI mightMax;
        
        public Resource influence;
        [SerializeField] TextMeshProUGUI influenceValue;
        [SerializeField] TextMeshProUGUI influenceMax;
        
        public Resource tradeGoods; 
        [SerializeField] TextMeshProUGUI tradeGoodsValue;
        [SerializeField] TextMeshProUGUI tradeGoodsMax;
        
        Resource GetResource(ResourceType resourceType)
        {
            // helper. 
            // Relation mapping type to resource instance. 
            // Untested, make sure there aren't any reference issues here
            Resource r = null; 
            switch (resourceType)
            {
                case ResourceType.Food:
                    r = food;
                    break;
                case ResourceType.Stability:
                    r = stability;
                    break;
                case ResourceType.Might:
                    r = might;
                    break;
                case ResourceType.Influence:
                    r = influence;
                    break;
                case ResourceType.TradeGoods:
                    r = tradeGoods;
                    break;
                default:
                    break;
            }

            return r; 
        }
        
        #endregion

        #region Cards and Decks
        
        public int currentMilestone = 0; // Index of the current milestone in the Milestone Deck
        public Card milestone; // I wonder if I should just directly reference the milestone from the
                                      // global milestones array instead of tracking them here... 

        
        // Add a mechanism here to prevent adding Cards that dont belong to these classes. 
        public List<Card> objectives = new List<Card>(); 
        public List<Card> actions = new List<Card>();
        
        // these two are concerned with rendering.  
        public List<GameObject> hand;
        public List<GameObject> agenda; 
        public int drawLimit = 5; // start at drawing 5 cards to hand per turn. 
        
        #endregion

        private void Awake()
        {
            _instance = this;
        }
        
        public void Initialize(Action onComplete)
        {
            InitializeResources();
            InitializeDecks();
            
            onComplete?.Invoke();
        }

        private void InitializeResources()
        {
            food = new Resource(initialResource, initialMaxResource, foodValue, foodMax);
            stability = new Resource(initialResource, initialMaxResource, stabilityValue, stabilityMax);
            might = new Resource(initialResource, initialMaxResource, mightValue, mightMax);
            influence = new Resource(initialResource, initialMaxResource, influenceValue, influenceMax);
            tradeGoods = new Resource(0, initialMaxResource, tradeGoodsValue, tradeGoodsMax);
        }

        private void InitializeDecks()
        {
            milestone = Deck.AllMilestones[currentMilestone];
         
            // MVP Deck: O11, O14, O17, O18, O19, O20, O36, O37,   
            objectives.Add(new Card("O11"));
            objectives.Add(new Card("O14"));
            objectives.Add(new Card("O17"));
            objectives.Add(new Card("O18"));
            objectives.Add(new Card("O19"));
            objectives.Add(new Card("O20"));
            objectives.Add(new Card("O36"));
            objectives.Add(new Card("O37"));

            //MVP Deck: C1, C2, C3, C5, C11, C12, C13, C15, C17, C20, C21, C22   
            actions.Add(new Card("C1"));
            actions.Add(new Card("C2"));
            actions.Add(new Card("C3"));
            actions.Add(new Card("C5"));
            actions.Add(new Card("C11"));
            actions.Add(new Card("C12"));
            actions.Add(new Card("C13"));
            actions.Add(new Card("C15"));
            actions.Add(new Card("C17"));
            actions.Add(new Card("C20"));
            actions.Add(new Card("C21"));
            actions.Add(new Card("C22"));
            
            milestone = Deck.AllMilestones[currentMilestone];
        }


        public bool SpendResource(ResourceType resourceType, int amount)
        {
            if (CostCheck(resourceType, amount))
            {
                GetResource(resourceType).SpendValue(amount);
                return true;
            }
            return false;
        }
        
        public bool CostCheck(ResourceType resourceType, int cost)
        {
            return GetResource(resourceType).Value >= cost;
        }
        

        public void Cleanup()
        {}
        
        public void SaveGame() 
        {}
        
        public void LoadGame()
        {}
    }
}