using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crusher : MonoBehaviour
{
    public float speed;
    public int maximumPosition;
    public int minimumXPosition;

    private void FixedUpdate()
    {
        if (transform.position.x <= minimumXPosition || transform.position.x >= maximumPosition)
        {
            speed *= -1;
        }


        float newXPosition = transform.position.x + speed * Time.fixedDeltaTime;
        float newYPosition = transform.position.y;
        Vector2 newPosition = new Vector2(newXPosition, newYPosition);
        transform.position = newPosition;
    }
}
