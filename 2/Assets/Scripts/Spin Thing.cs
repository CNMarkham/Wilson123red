using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinThing : MonoBehaviour
{
    public float xAngle, yAngle, zAngle;


    private void OnCollisionEnter(Collision collision)
    {
        gameObject.SetActive(false);
        Invoke("Respawn", 10);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
    void Respawn()
    {
        gameObject.SetActive(true);
    }
}
