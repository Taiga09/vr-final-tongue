using UnityEngine;
using TMPro;

public class TriggerCounter : MonoBehaviour
{
    private int triggerCount = 0;
    public TextMeshProUGUI countText;
    public GameObject hand;
    public Material newMaterial;

    private Material oldMaterial;

    private Renderer handRenderer;

    private bool changeColor = false;

    private void Awake()
    {
        countText.text = "0";

        if (hand == null) changeColor = false;
        else
        {
            handRenderer = hand.GetComponent<Renderer>();
            oldMaterial = handRenderer.material;

            Debug.Log("handrenderer: ");
            Debug.Log(handRenderer);
            Debug.Log("material: ");
            Debug.Log(handRenderer.material);

            changeColor = true;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        triggerCount++;
        countText.text = triggerCount.ToString();

        if (changeColor)
        {
            Debug.Log("red");
            //handRenderer.material.SetColor("_Color", Color.red);
            handRenderer.material = newMaterial;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (changeColor)
        {
            Debug.Log("white");
            //handRenderer.material.SetColor("_Color", Color.white);
            handRenderer.material = oldMaterial;
        }
    }
}
