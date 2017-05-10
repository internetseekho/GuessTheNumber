using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuessTheNumber : MonoBehaviour {

	// Use this for initialization
	void Start () {

        print("Welcome to Guess The Number Game");
        print("Guess a Number in your Head and don't Tell me about it");

        int Higherlimit = 100;
        int Lowerlimit = 1;
        int ComputerGuess = (Higherlimit + Lowerlimit) / 2;

        print("The Higher Limit you can think of is " + Higherlimit);
        print("The Lower Limit you can think of is "  + Lowerlimit);

        print("Is Your Number Lower or Higer Than " + ComputerGuess);
        print("For Higer Press Up Arrow, For Lower Press Down Arrow and For Equal Press Return/Enter");


    }
	
	// Update is called once per frame
	void Update () {

        if ( Input.GetKeyDown( KeyCode.UpArrow ) ) { 
            print("Up Arrow Pressed");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down Arrow Pressed");
        }

        if (Input.GetKeyDown(KeyCode.Return)) { 
            print("Return/Enter Arrow Pressed");
        }

    }
}
