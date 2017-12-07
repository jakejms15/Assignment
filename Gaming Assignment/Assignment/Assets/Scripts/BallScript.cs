using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour
{

    public PlayerOneScript Player1;
    public PlayerTwoScript Player2;
    Vector3 paddleToBallVector1;
    Vector3 paddleToBallVector2;
    bool hasStarted = false;

    int player1SCORE;
    public Text Player1Score;
    public GameObject Ball;
    int player2SCORE;
    public Text Player2Score;
    public int finalScore;
    public static int player1FinalScore = 0;
    public static int player2FinalScore = 0;

    public int ballSpeed;
    private Vector3 spawn;
    // Use this for initialization
    void Start()
    {

        Player1 = GameObject.FindObjectOfType<PlayerOneScript>();
        Player2 = GameObject.FindObjectOfType<PlayerTwoScript>();
        paddleToBallVector1 = this.transform.position - Player1.transform.position;
        paddleToBallVector2 = this.transform.position - Player2.transform.position;

        player1SCORE = 0;
        Player1Score.text = player1SCORE.ToString();
        player2SCORE = 0;
        Player2Score.text = player2SCORE.ToString();
        spawn = transform.position;
        

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0) && hasStarted == false)
        {
            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = Random.onUnitSphere * ballSpeed;
        }
    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 addspeed = new Vector2(0f, 0.2f);
        if (hasStarted && (collision.collider.tag == "Border" || collision.collider.tag == "Obstacle"))
        {
            gameObject.GetComponent<AudioSource>().Play();
        }
        

        if (hasStarted && (collision.collider.tag == "Border"))
        {
            this.GetComponent<Rigidbody2D>().velocity += addspeed;
        }

        if (collision.gameObject.name == "Player1PostBorder")
        {
            player2SCORE = player2SCORE + 1;
            if (player2SCORE == finalScore)
            {
                player2FinalScore += 1;
                LevelManager.LoadNextScene();

            }
            Player2Score.text = player2SCORE.ToString();
            transform.position = spawn;
            hasStarted = false;
            GetComponent<Rigidbody2D>().velocity = Random.onUnitSphere * 0;
            if (Input.GetMouseButtonDown(0) && hasStarted == false)
            {
                hasStarted = true;
                GetComponent<Rigidbody2D>().velocity = Random.onUnitSphere * 10;
            }
        }

        if (collision.gameObject.name == "Player2PostBorder")
        {
            player1SCORE = player1SCORE + 1;
            if (player1SCORE == finalScore)
            {
                player1FinalScore += 1;
                LevelManager.LoadNextScene();
    
            }
            
            Player1Score.text = player1SCORE.ToString();
            transform.position = spawn;
            hasStarted = false;
            GetComponent<Rigidbody2D>().velocity = Random.onUnitSphere * 0;
            if (Input.GetMouseButtonDown(0) && hasStarted == false)
            {
                hasStarted = true;
                GetComponent<Rigidbody2D>().velocity = Random.onUnitSphere * 10;
            }
        }
    }
}