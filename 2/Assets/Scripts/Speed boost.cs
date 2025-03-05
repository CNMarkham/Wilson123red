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
        Codey.Speed = 400f;
        Invoke("Slow", 5.0f);
        Destroy(gameObject, 5);
      
    }
    void Slow()
    {
        Codey.Speed = 200f;
    }

}
