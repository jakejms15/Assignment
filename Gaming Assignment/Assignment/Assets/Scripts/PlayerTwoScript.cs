using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float mousePositionInUnits = ((Input.mousePosition.y / Screen.height) * 12) - 6;
        Vector3 newPaddlePos = new Vector3(gameObject.transform.position.x, mousePositionInUnits, gameObject.transform.position.z);
        newPaddlePos.y = Mathf.Clamp(mousePositionInUnits, -5.5f, 5.5f);
        this.transform.position = newPaddlePos;
    }
}   