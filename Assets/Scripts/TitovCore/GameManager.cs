using System;
using NUnit.Framework;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TitovCore.Cards;
using TMPro;

namespace TitovCore
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager _instance;
        public static GameManager Instance
        {
            get
            {
                if(_instance == null) _instance = GameObject.FindFirstObjectByType<GameManager>();
                return _instance;
            }
        }
        //Name of the prefab will be used to identify it in the Deck Initializations. 
        [SerializeField] List<GameObject> cardPrefabs;
        
        GameState state;
        [SerializeField] GameObject endTurnButton; 
        
        public TextMeshProUGUI gamePhase; 
        const string actionPhase = "Action Phase", crisisPhase = "Crisis Phase", resetPhase = "Reset Phase";
        
       
        
        private void Awake()
        {
            _instance = this;
        }
        
        private void Start()
        {
            gamePhase.text = "Setting up...";
            state = GameState.Instance;
            Deck.Initialize();
            state.Initialize(onComplete: NextPhase);
        }

        #region Game Phases
        void ActionPhase()
        {
            state.phase = GamePhase.Action;
            gamePhase.text = actionPhase;

            // while (state.phase == GamePhase.Action)
            // {
            //     // play hand, use resources  
            // }
            
        }

        void CrisisPhase()
        {
            state.phase = GamePhase.Crisis;
            gamePhase.text = crisisPhase;

            // while (state.phase == GamePhase.Crisis)
            // {
            //     // resolve objectives and milestones, use resources and play history 
            // }
            
        }

        void ResetPhase()
        {
            state.phase = GamePhase.Reset;
            gamePhase.text = resetPhase;
            
            // advance timers,
            // call each milestone's resolveCard()
            // add n cards to hand 
            
            ActionPhase();
            
        }
        #endregion

        public void NextPhase()
        {

            if (state.phase == GamePhase.Setup || state.phase == GamePhase.Tutorial) ActionPhase();
            else if (state.phase == GamePhase.Action) CrisisPhase();
            else if (state.phase == GamePhase.Crisis) ResetPhase();
            
        }

        public static GameObject GetCardPrefab(string name)
        {
            if (Instance.cardPrefabs is { Count: 0 }) return null;

            return Instance.cardPrefabs.FirstOrDefault(model => model.name == name);
        }
        
        # region Game Over
        void IsGameLost()
        {
            // check if gamelost
            Gameover();
        }
        void Gameover(bool isWin = false)
        {
            if (!isWin)
            {
                // lose logic here
                return; 
            } 
            // win logic here. 
        }
        
        #endregion
        
        
    }
}