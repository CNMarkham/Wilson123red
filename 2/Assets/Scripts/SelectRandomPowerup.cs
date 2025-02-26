using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomPowerup : MonoBehaviour
{
    public List<GameObject> powerupList;
    public int randomNumberInList;
    public GameObject chosenPowerup;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetKey(KeyCode.Space) && chosenPowerup != null)
        {
           GameObject temp = Instantiate(chosenPowerup, transform.position + transform.forward, Quaternion.identity);
            temp.transform.forward = transform.forward;
            chosenPowerup = null;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ItemBox")
        {
            randomNumberInList = Random.Range(0, powerupList.Count);
            chosenPowerup = powerupList[randomNumberInList];
        }
    }

}
