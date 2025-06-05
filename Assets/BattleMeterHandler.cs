using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleMeterHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int current = 0;
    private Color green = new Color(0.725f, 1.0f, 0.725f);
    public List<Image> slots;

    public void MoveForward(int steps = 1)
    {
        for (int i = steps; i > 0; i--)
        {
            if (current != slots.Count - 1)
            {
                current += 1;
                slots[current].color = green;
            }
        }
    }

    public void MoveBackwards(int steps = 1)
    {
        for (int i = steps; i > 0; i--)
        {
            if (current != 0)
            {
                slots[current].color = Color.white;
                current -= 1;
            }
        }
    }
}
