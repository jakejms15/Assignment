using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallHitRIght : MonoBehaviour {
    int player1;
    public Text Player1Score;
    public GameObject Ball;

    // Use this for initialization
    void Start () {
        player1 = 0;
        Player1Score.text = player1.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            player1 = player1 + 1;
            Player1Score.text = player1.ToString();
            Destroy(collision.gameObject);
            
        }

    }
}
