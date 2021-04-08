using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver_Screen : MonoBehaviour
{
    public void playAgain()
    {
        SceneManager.LoadScene("BeroepsOpdrachtArcadeMechanics");

        //Score objct = new Score();
        //int resetScore = GetComponent<>()        
        //objct.ScoreValueNew = 0;
    }
    public void QuitGame()
    {
        Debug.Log("QUIT");

        //Application.Quit(); PAS AAN HET EINDE GEBRUIKEN SLUIT DE GAME AF!
    }
}
