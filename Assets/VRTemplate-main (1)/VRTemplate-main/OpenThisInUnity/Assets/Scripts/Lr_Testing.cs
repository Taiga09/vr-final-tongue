using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lr_Testing : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private lr_LineController line;


    // Start is called before the first frame update
    private void Start()
    {
        line.SetUpLine(points);
    }

}
