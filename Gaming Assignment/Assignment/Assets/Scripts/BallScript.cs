using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour {

    public PlayerOneScript Player1;
    public PlayerTwoScript Player2;
    Vector3 paddleToBallVector1;
    Vector3 paddleToBallVector2;
    bool hasStarted = false;

    int player1;
    public Text Player1Score;
    public GameObject Ball;
    int player2;
    public Text Player2Score;

    private Vector3 spawn;
    // Use this for initialization
    void Start()
    {

        Player1 = GameObject.FindObjectOfType<PlayerOneScript>();
        Player2 = GameObject.FindObjectOfType<PlayerTwoScript>();
        paddleToBallVector1 = this.transform.position - Player1.transform.position;
        paddleToBallVector2 = this.transform.position - Player2.transform.position;

        player1 = 0;
        Player1Score.text = player1.ToString();
        player2 = 0;
        Player2Score.text = player2.ToString();
        spawn = transform.position;

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0) && hasStarted == false)
            {
                hasStarted = true;
                GetComponent<Rigidbody2D>().velocity = Random.onUnitSphere * 10;
            }
    }

   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasStarted && (collision.collider.tag == "Border"))
        {
            gameObject.GetComponent<AudioSource>().Play();
        }
        if (collision.gameObject.name == "Player1PostBorder")
        {
            player2 = player2 + 1;
            Player2Score.text = player2.ToString();
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
            player1 = player1 + 1;
            Player1Score.text = player1.ToString();
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
