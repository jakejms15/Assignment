using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallHitLeft : MonoBehaviour {
    int player2;
    public Text Player2Score;
    public GameObject Ball;

    // Use this for initialization
    void Start () {
        player2 = 0;
        Player2Score.text = player2.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            player2 = player2 + 1;
            Player2Score.text = player2.ToString();
            Destroy(collision.gameObject);
        }

    }
}