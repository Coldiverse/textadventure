using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NW : MonoBehaviour
{
    // Start is called before the first frame update
    int max = 1000;
    int min = 1;
    int guess = 500;
    void Start()
    {
        StartGame();
    }
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Sup");
        Debug.Log("Pick Your own number in ya head");
        Debug.Log("Max value is: " + max);
        Debug.Log("min value is: " + min);
        Debug.Log("if number is higher than " + guess + ": up arrow, lower; down arrow, if correct; press enter");
        /*Debug.Log("Enter your max");
        int minimum = Convert.ToInt32(Console.ReadLine());
        Debug.Log("enter minimum");
        int maximum = Convert.ToInt32(Console.ReadLine());
        */
        max++;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Ben is a god, you also won btw");
            StartGame();
        }
    }
    void NextGuess()
    {
        guess = (min + max) / 2;
        Debug.Log("up arrow: is ya guess higher than: " + guess + " if so up arrow if nah down arrow");
    }
}
