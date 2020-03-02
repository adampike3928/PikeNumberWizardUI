using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{//varables that are globle to the class
    [SerializeField] int intmax;
    [SerializeField] int intmin;
    int intguess;
    // Start is called before the first frame update

  
    void Start()
    {//calls on VoidGameStart commands
        VoidStartGame();
    }
    void VoidStartGame()
    {
        intmax = intmax + 1;

        intguess = (intmax = intmin) / 2;
    }
    //Start of game commands
    public void OnPressHigher()
    {
        intmin = intguess;
        VoidNextGuess();
    }
    //Method for when higher is Pressed
    public void OnPressLower()
    {
        intmax = intguess;
        VoidNextGuess();
    }
    //Method for when lower is pressed
    
    void VoidNextGuess()
    {
        intguess = (intmax = intmin) / 2;
        
    }
    //Equation method for getting closer to number
}

