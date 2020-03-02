using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{//varables that are globle to the class
    [SerializeField] int intmax;
    [SerializeField] int intmin;
    [SerializeField] TextMeshProUGUI guessText;
    int intguess;
    
    
    // Start is called before the first frame update

  
    void Start()
    {//calls on VoidGameStart commands
        VoidStartGame();
    }
    void VoidStartGame()
    {
        VoidNextGuess();

        
    }
    //Start of game commands
    public void OnPressHigher()
    {
        intmin = intguess + 1;
        VoidNextGuess();
    }
    //Method for when higher is Pressed
    public void OnPressLower()
    {
        intmax = intguess - 1;
        VoidNextGuess();
    }
    //Method for when lower is pressed
    
    void VoidNextGuess()
    {
        intguess = Random.Range(intmin, intmax + 1);
        guessText.text = intguess.ToString();
        
    }
    //Equation method for getting closer to number
}

