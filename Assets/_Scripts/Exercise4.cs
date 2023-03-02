using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise4 : MonoBehaviour
{
    // ============================================================================
    // Create a while loop that displays all multiples of 5 between start and end.
    // ============================================================================
    
    public int start, end;

    private void Start()
    {
        int i = start;
        while (i <= end)
        {
            if (i % 5 == 0)
            {
                Debug.Log(i); // We only display multiples of 5
            }
            
            i++; // Necessary in order not to fall into an infinite loop
        }
    }
}
