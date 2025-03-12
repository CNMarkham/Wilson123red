using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class TimerCountdown : MonoBehaviour
{
    public CodeyMove speed;
    public TextMeshProUGUI lapTime;
    public TextMeshProUGUI startCountdown;

    public float totalLapTime;
    public float totalCountdownTime;

    public bool Boom;
    // Update is called once per frame
    void Update()
    {
      
        if (totalCountdownTime >= 0)
        {
            totalCountdownTime -= Time.deltaTime;
            startCountdown.text = (totalCountdownTime).ToString();
            speed.Speed = 0;
        }
        if (totalCountdownTime <= 0)
        {
            startCountdown.text = "";
            totalLapTime-= Time.deltaTime;
            lapTime.text = Mathf.Round(totalLapTime).ToString();
            if (Boom == false)
            {
                speed.Speed = 400;
                Boom = true;
            }
            
        }
        if (totalLapTime <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
