using UnityEngine;

/// <summary>
/// Destroys object after a few seconds or on collision
/// </summary>
public class DestroyObject1 : MonoBehaviour
{
    [Tooltip("Time before destroying in seconds")]
    public float lifeTime = 5.0f;

    //private void Start()
    //{
    //    // Destroy the object after the specified lifetime
    //    Destroy(gameObject, lifeTime);
    //}

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Destroy the object immediately when a collision occurs
    //    Destroy(gameObject);
    //}

    public void DestroySelf()
    {
        Destroy(gameObject);
        Debug.Log("Destroy");
    }
}
