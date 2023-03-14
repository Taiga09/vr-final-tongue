using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab; // Reference to the projectile prefab to be instantiated
    [SerializeField] private Transform spawnPoint; // Reference to the spawn point for the projectile
    public float projectileForce = 10.0f;
    private InputDevice rightController; // Reference to the right controller

    private void Start()
    {
        // Find the right controller by checking all available input devices
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevices(devices);

        foreach (InputDevice device in devices)
        {
            if (device.characteristics == InputDeviceCharacteristics.Right)
            {
                rightController = device;
                break;
            }
        }
    }


    void Update()
    {
        if (rightController.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue) && primaryButtonValue)
        {
            ShootProjectile();
        }
    }

    void ShootProjectile()
    {
        GameObject projectile = Instantiate(projectilePrefab, spawnPoint.position, spawnPoint.rotation);
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.AddForce(spawnPoint.forward * projectileForce, ForceMode.Impulse);
    }

}
