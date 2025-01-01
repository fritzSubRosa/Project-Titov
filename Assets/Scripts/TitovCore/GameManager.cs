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
            if (state == null)
            {
                state = GetComponent<GameState>();
            }
        }
    }
}