using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver_Screen : MonoBehaviour
{
    public void playAgain()
    {
        SceneManager.LoadScene("SampleScene");

        //Score objct = new Score();
        //int resetScore = GetComponent<>()        
        //objct.ScoreValueNew = 0;
    }
    public void QuitGame()
    {
        //Werkt niet 
        Debug.Log("Quit");
    }
}
