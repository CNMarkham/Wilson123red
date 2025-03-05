using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerFinishLine : MonoBehaviour

{
    public CheckpointCounter checkpointTracker;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (checkpointTracker.triggeredCheckpoints >= checkpointTracker.numberOfCheckpoints)
            {
                SceneManager.LoadScene(1);
            }
            else
            {
                print("Cheater!");
            }
;
        }
    }
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }
}
