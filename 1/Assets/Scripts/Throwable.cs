using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwable : MonoBehaviour
{
    public Vector3 offset;
    public int throwableCounter;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ThrowingObject"))
        {
            Destroy(collision.gameObject);
            throwableCounter += 1;
        }
    }



    public GameObject ObjectThrown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if (throwableCounter >= 0)
            {


                offset = transform.localScale.x * new Vector3(1, 0, 0);

                Vector3 throwablePosition = transform.position + offset;


                Instantiate(ObjectThrown, throwablePosition, transform.rotation);
                throwableCounter -= 1;
            }

        }
        }



}


