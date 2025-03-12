using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedboost : MonoBehaviour
{

    public CodeyMove Codey;
    
   

    // Start is called before the first frame update
    void Start()
    {
        Codey = FindObjectOfType<CodeyMove>();
        Codey.Speed = 600f;
        Invoke("Slow", 10.0f);
        Destroy(gameObject, 10);
      
    }
    void Slow()
    {
        Codey.Speed = 400f;
    }

}
