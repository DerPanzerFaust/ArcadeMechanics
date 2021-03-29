using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public GameObject objPlayer;
    public GameObject Enemy1;

    public static int scoreValue = 0;
    //Text score;

    private void Start()
    {
        scoreText = GetComponent<Text> ();
    }


    // Update is called once per frame
    void Update()
    {
        
        if (objPlayer != null)
        {
            scoreText.text = ":" + scoreValue;

        }
    }
}
