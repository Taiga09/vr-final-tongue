using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("up"))
        {
            transform.position += transform.forward * 0.03f;
        }

        if (Input.GetKey("down"))
        {
            transform.position += transform.forward * -0.03f;
        }

        if (Input.GetKey("right"))
        {
            transform.Rotate(0, 2, 0);
        }

        if (Input.GetKey("left"))
        {
            transform.Rotate(0, -2, 0);
        }
    }
}