﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
            StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to Number Wizard! Please pick a number...");
        Debug.Log("Highest number you can pick is " + max);
        Debug.Log("Lowest number you can pick is " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Press Up = higher, press Down = lower, press Enter = Correct");
        max = max + 1;
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
            Debug.Log("Rockstar!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than " + guess);
    }
}