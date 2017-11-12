using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {
    // game state
    int level;
    enum Screen { MainMenu, Password, Win}
    
    // Use this for initialization
	void Start () {
        ShowMainMenu();
	}
	
    void ShowMainMenu() {
        Screen currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("Would you like to access:");
        Terminal.WriteLine("1. Main Menu");
        Terminal.WriteLine("2. Messages");
        Terminal.WriteLine("3. System");
        Terminal.WriteLine("4. Portfolio");

    }

    void OnUserInput(string input)
    {
        if (input == "1"){
            ShowMainMenu();

        }
        else if (currentScreen == Screen.MainMenu) {
            RunMainMenu(input);
        }
    }

    private void RunMainMenu(string input)
    {
        
        if (input == "2") {
            level = 2;
            StartGame();
        }
        else if (input == "3") {
            level = 3;
            StartGame();
        }
        else if (input == "4") {
            level = 4;
            StartGame();
        }
    }

    void StartGame() {
        currentScreen = Screen.Password;
        Terminal.WriteLine("Start of game");
        Terminal.WriteLine("Please Enter Your Password:");
        
    }

    // update is called once per frame 
    private void Update()
    {
       
    }

}
