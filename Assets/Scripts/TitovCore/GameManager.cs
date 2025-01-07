using System;
using NUnit.Framework;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TitovCore.Cards;
using TMPro;

namespace TitovCore
{
    public class GameManager : MonoBehaviour
    {
        GameState state;
        [SerializeField] GameObject endTurnButton; 
        
        public TextMeshProUGUI gamePhase; 
        const string actionPhase = "Action Phase";
        const string crisisPhase = "Crisis Phase";
        const string resetPhase = "Reset Phase";
        

        private void Start()
        {
            gamePhase.text = "Setting up...";
            state = GameState.Instance;
            state.Initialize(onComplete: NextPhase);
            Deck.InitializeDeck();
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
            
            // advance timers 
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