using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace TitovCore
{
    [Serializable]
    public class GameState : MonoBehaviour
    {
        private static GameState _instance;
        public static GameState Instance
        {
            get
            {
                if(_instance == null) _instance = GameObject.FindFirstObjectByType<GameState>();
                return _instance;
            }
        }

        [SerializeField] TextMeshProUGUI gamePhase; 

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

        
        // CONSTANTS
        public int initialResource = 3;
        public int initialMaxResource = 6;

        private string actionPhase = "Action Phase";
        private string crisisPhase = "Crisis Phase";
        private string resetPhase = "Reset Phase";
        
        // Resources 
        public int currentMilestone = 0; // Index of the current milestone in the Milestone Deck

        public List<GameObject> milestones; 
        public List<GameObject> objectives; 
        public List<GameObject> actions; 

        private void Awake()
        {
            _instance = this;
            Initialize();
        }
        
        private void Initialize()
        {
            gamePhase.text = actionPhase;
            InitializeResources();
            InitializeDecks();
            
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
        {}
        

        public void Cleanup()
        {}
        
        public void SaveGame() 
        {}
        
        public void LoadGame()
        {}
    }
}