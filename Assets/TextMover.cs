using UnityEngine;
using UnityEngine.UI;

public class TextMover : MonoBehaviour
{
    public RectTransform textTransform;  
    public float speed = 30f;            
    public float range = 50f;            
    private Vector3 startPosition;       

    void Start()
    {
        // Get the starting position of the text
        startPosition = textTransform.localPosition;
    }

    void Update()
    {
        // Calculate the new position with oscillation
        float newX = startPosition.x + Mathf.PingPong(Time.time * speed, range) - range / 2f;
        textTransform.localPosition = new Vector3(newX, startPosition.y, startPosition.z);
    }
}
