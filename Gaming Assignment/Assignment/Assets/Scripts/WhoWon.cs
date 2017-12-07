using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhoWon : MonoBehaviour {
    public Text whoWon;
    // Use this for initialization
    void Start () {
        if (BallScript.player2FinalScore > BallScript.player1FinalScore)
        {
            whoWon.text = "Player 2 Won";
        }

        if (BallScript.player2FinalScore < BallScript.player1FinalScore)
        {
            whoWon.text = "Player 1 Won";
        }
    }
	
	// Update is called once per frame
	void Update () {
		
    }
}
