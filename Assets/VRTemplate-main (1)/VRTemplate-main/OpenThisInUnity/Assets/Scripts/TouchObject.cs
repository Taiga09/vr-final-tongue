using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchObject : MonoBehaviour
{
    public GameObject gameObject;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Cube")
        {
            transform.SetParent(gameObject.transform);
        }
    }
}