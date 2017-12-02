using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
    }
    public int speed = 10;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * (speed + 6) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * (speed + 6) * Time.deltaTime;
        }
    }

   
}
