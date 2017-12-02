using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour {

    int player1Score = 0;
    int player2Score = 0;
    // Use this for initialization
    void Start () {
        player1Score = 0;
        player2Score = 0;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void player1Inc()
    {
        player1Score++;
    }

    public void player2Inc()
    {
        player2Score++;
    }
}
