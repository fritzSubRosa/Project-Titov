using System;
using System.Collections.Generic;
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
        public int initialResource = 3;
        public int initialMaxResource = 6;
        
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
        #endregion

        #region Cards and Decks
        public int currentMilestone = 1; // Index of the current milestone in the Milestone Deck
        public int drawPerTurn = 5; // start at drawing 5 cards to hand per turn. 
        
        public List<GameObject> milestones; 
        public List<GameObject> objectives; 
        public List<GameObject> actions; 
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
            
        }
        

        public void Cleanup()
        {}
        
        public void SaveGame() 
        {}
        
        public void LoadGame()
        {}
    }
}