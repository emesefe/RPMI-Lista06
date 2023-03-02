using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    // ========================================================================================
    // Display 20 times on the console the message “Hola, holita, vecinito” with a while loop.
    // ========================================================================================
    
    private int repetitions = 20;

    private void Start()
    {
        while (repetitions > 0)
        {
            Debug.Log("Hola, holita, vecinito");
            repetitions--; // Necessary in order not to fall into an infinite loop
        }
    }
}
