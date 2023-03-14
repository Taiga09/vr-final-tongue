using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    public Rigidbody[] ropeSpheres; // Array of the Rigidbody components of the rope spheres

    public float forceMultiplier = 100f; // Multiplier for the force applied to the rope spheres

    private Vector3 prevControllerPos; // Previous position of the right controller

    private void Start()
    {
        prevControllerPos = transform.position; // Initialize the previous position of the right controller
    }

    private void FixedUpdate()
    {
        Vector3 controllerMovement = transform.position - prevControllerPos; // Calculate the movement of the right controller
        Vector3 force = new Vector3(0f, controllerMovement.y, 0f) * forceMultiplier; // Calculate the force to apply to the rope spheres
        foreach (Rigidbody sphere in ropeSpheres)
        {
            sphere.AddForce(force); // Apply the force to each rope sphere
        }
        prevControllerPos = transform.position; // Update the previous position of the right controller
    }
}