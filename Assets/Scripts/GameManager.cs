using System;
using NUnit.Framework;
using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{


    /// Resources
    int Might = 0;
    int Food = 0;
    int Stability = 0;
    int Influence = 0;

    int MaxMight = 4; 
    int MaxFood = 4;
    int MaxStability = 4;
    int MaxInfluence = 4;

    public enum GamePhase
    {
        Tutorial,
        Action, 
        Crisis, 
        Resolve
    }

        
    void Start()
    {
        
    }

    /// <summary>
    /// Reset state to ground state
    /// </summary>
    void RestartGame()
    {
        // load the groundstate.json file
        // read and reset all system state to this state. 
    }
}
