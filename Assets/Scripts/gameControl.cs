using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ballonPrefab, explosionPrefab, timeBalloonPrefab;
    public Text scoreText, timeText;
    public static int score = 0;
    public static float time = 15;
    float counter = 0, countertime=0;
    bool _isCreateed;

   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time <= 0)
        {
            GameObject[] objs;
            objs = GameObject.FindGameObjectsWithTag("ballon");

            foreach (GameObject currentBalloon in objs)
            {
                Instantiate(explosionPrefab, currentBalloon.transform.position, Quaternion.identity);
                Destroy(currentBalloon);

            }
        }
        else
        {
            time -= Time.deltaTime;
            timeText.text ="Time: "+ ((int)time).ToString() ;
            counter += Time.deltaTime;
            countertime += Time.deltaTime;
            if (counter > 0.4f)
            {
                GameObject balloonInstantiated = Instantiate(ballonPrefab, new Vector2(Random.Range(-3, 4), -9), Quaternion.identity);
                balloonInstantiated.name = "ballon";
                counter = 0;
            }
            if (countertime > Random.Range(3,8)&&time<10 && !_isCreateed)
            {
                GameObject balloonInstantiated = Instantiate(timeBalloonPrefab, new Vector2(Random.Range(-3, 4), -9), Quaternion.identity);
                balloonInstantiated.name = "timeballon";
                countertime = 0;
                _isCreateed = true;
            }
        }

    }
    public void Score()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();
    }
    public void ChangeTime()
    {
        time = time + 5;
        timeText.text = "Time: " + ((int)time).ToString();

    }
}
