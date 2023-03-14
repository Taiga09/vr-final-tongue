using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickMove : MonoBehaviour
{
    HingeJoint hj;
    JointSpring sp;
    public float beginPos;
    public float shotPos;

    void Start()
    {
        hj = GetComponent<HingeJoint>();
        sp = hj.spring;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            sp.targetPosition = beginPos;
            hj.spring = sp;
        }

        if (Input.GetMouseButtonUp(0))
        {
            sp.targetPosition = shotPos;
            hj.spring = sp;
        }
    }
}