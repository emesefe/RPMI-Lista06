using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    // ==================================
    // Make a countdown with a for loop
    // ==================================

    public int startCountdown = 10;

    private void Start()
    {
        // We initialize the iterator variable with the value of the startCountdown variable
        for (int i = startCountdown; i >= 0; i--) 
        {
            Debug.Log(i);
        }
    }
}
