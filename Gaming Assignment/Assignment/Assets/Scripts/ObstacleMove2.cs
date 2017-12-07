using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove2 : MonoBehaviour {

    void Start()
    {

    }

    // Update is called once per frame
    int direction = -1; //int direction where 0 is stay, 1 up, -1 down
    int top = 5;
    int bottom = -5;

    float speed = 5;


    void Update()
    {
        if (this.transform.position.y >= top)
            direction = -1;

        if (this.transform.position.y <= bottom)
            direction = 1;

        this.transform.Translate(0, speed * direction * Time.deltaTime, 0);
    }
}

