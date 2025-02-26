using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TimerCountdown : MonoBehaviour
{
    public CodeyMove speed;
    public TextMeshProUGUI lapTime;
    public TextMeshProUGUI startCountdown;

    public float totalLapTime;
    public float totalCountdownTime;

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
            speed.Speed = 200;
        }
        if (totalLapTime <= 0)
        {
            print("times up");
        }
    }
}
