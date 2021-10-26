using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Class that's responsible for implementing both recursive and interactive functions,
 * to solve "Exercicios 1_Recursividade, Árvores e Grafos".
 * 
 * Implemented by Sara Batista
 * 
 */
public class RecursiveFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        writeResultsForFatorialFunctions(16);
    }

    /* ============================================================================================
     *                                        EXERCISE 3
     * ============================================================================================
     */

    /**
     * Method to implement the Factorial function by the iteractive approach.
     * Input: n -> integer
     * Output: n! -> integer
     */
    int fatorialIteractive(int n)
    {
        if(n == 0)
        {
            return 1;
        }
        else
        {
            int fat = 1;
            for (int i = 1; i<=n;  i++)
            {
                fat = fat * i;
            }
            return fat;
        }
    }

    /**
    * Method to implement the Factorial function by the recursive approach.
    * Input: n -> integer
    * Output: n! -> integer
    */
    int fatorialRecursive(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * fatorialRecursive(n - 1);
        }
    }

    /**
     * Method to write the results for both factorial functions (recursive and iteractive).
     * input: n -> integer
     */
    void writeResultsForFatorialFunctions(int n)
    {
        print("\n RECURSIVE APPROACH: Result of " + n + "! = " + fatorialRecursive(n));
        
        print("\n INTERACTIVE APPROACH: Result of " + n + "! = " + fatorialIteractive(n));
    }
}
