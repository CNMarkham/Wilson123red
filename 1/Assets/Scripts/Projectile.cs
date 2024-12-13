using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public Throwable direction;
    // Start is called before the first frame update
    private void DestroyThrowable()
    {
        Destroy(gameObject);
    }
    void Start()
    {
        direction = GameObject.FindGameObjectWithTag("Player").GetComponent<Throwable>();
        Invoke("DestroyThrowable",5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction.offset * Time.deltaTime * speed;
    }
    
}
