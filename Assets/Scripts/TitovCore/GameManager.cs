using System;
using NUnit.Framework;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace TitovCore
{
    public class GameManager : MonoBehaviour
    {
        GameState state;

        private void Start()
        {
            state = GameState.Instance;
        }

        private void ActionPhase()
        {
            
        }

        private void CrisisPhase()
        {
            
        }

        private void ResetPhase()
        {
        }

        private void Gameover(bool isWin = false)
        {
            if (!isWin)
            {
                // lose logic here
                return; 
            } 
            // win logic here. 
            
        }
    }
}