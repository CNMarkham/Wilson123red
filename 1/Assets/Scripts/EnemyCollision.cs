using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollision : MonoBehaviour
{
    //public int enemyCount;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }
        if (collision.gameObject.CompareTag("3"))
        {
            Destroy(this.gameObject);

            GameObject.FindGameObjectWithTag("Portal").GetComponent<Teleport>().enemyCount -= 1;

            Destroy(collision.gameObject);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
