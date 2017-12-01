using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    public PlayerOneScript Player1;
    public PlayerTwoScript Player2;
    Vector3 paddleToBallVector1;
    Vector3 paddleToBallVector2;
    bool hasStarted = false;

    // Use this for initialization
    void Start()
    {
        Player1 = GameObject.FindObjectOfType<PlayerOneScript>();
        Player2 = GameObject.FindObjectOfType<PlayerTwoScript>();
        paddleToBallVector1 = this.transform.position - Player1.transform.position;
        paddleToBallVector2 = this.transform.position - Player2.transform.position;
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

}
