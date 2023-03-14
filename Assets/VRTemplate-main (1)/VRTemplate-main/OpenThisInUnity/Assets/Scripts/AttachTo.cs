using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachTo : MonoBehaviour
{
    private bool isAttached = false;
    private Rigidbody attachedTo;

    private void OnCollisionEnter(Collision collision)
    {
        if (!isAttached)
        {
            Rigidbody otherRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Collider otherCollider = collision.gameObject.GetComponent<Collider>();
            if(otherCollider != null)
            {
                otherCollider.enabled = false;
            }

            if (otherRigidbody != null)
            {
                transform.SetParent(collision.transform, true);
                attachedTo = otherRigidbody;
                isAttached = true;
            }
        }
    }

    private void FixedUpdate()
    {
        if (isAttached)
        {
            transform.position = attachedTo.transform.position;
        }
    }
}

