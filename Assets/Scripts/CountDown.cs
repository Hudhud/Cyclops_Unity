using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour {

    float timeLeft = 30.0f;
    public TextMesh countdown;
    static int i;

    // Use this for initialization
    void Start () {
        countdown = GameObject.Find("CountDownText").GetComponent<TextMesh>();
        i = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update () {
       
        if (timeLeft >= 0)
        {
            timeLeft -= Time.deltaTime;
            countdown.text = "Time: " + Mathf.Round(timeLeft);
        }
            
            if (GameObject.FindGameObjectWithTag("Can") == null)
            {
            Hit counter = new Hit();
            counter.Restartcounter();
            SceneManager.LoadScene(++i);
            }
            if (timeLeft <= 0)
            {
        }
    }
}
