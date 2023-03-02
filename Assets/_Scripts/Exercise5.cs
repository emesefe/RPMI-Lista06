using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise5 : MonoBehaviour
{
    // ====================================================================================
    // Compute the sum of the elements of your array and display the result on the console.
    // ====================================================================================
    
    public int[] numbers;

    private int sum;

    private void Start()
    {
        foreach (int n in numbers)
        {
            sum += n; // We sum each number of the array
        }
        
        // Once we have computed the sum, we display the result
        Debug.Log($"Sum = {sum}");
    }
}
