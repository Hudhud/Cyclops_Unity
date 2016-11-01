using UnityEngine;
using System.Collections;

public class CountDown : MonoBehaviour {

    float timeLeft = 10.0f;
    public TextMesh countdown;

    // Use this for initialization
    void Start () {
        countdown = gameObject.GetComponent<TextMesh>();

    }

    // Update is called once per frame
    void Update () {
        if (timeLeft >= 0)
        {
            timeLeft -= Time.deltaTime;
            countdown.text = "Time: " + Mathf.Round(timeLeft);
        }
            
        //Her skal der implementeres hvad der skal gøres, når tiden er gået
        if (timeLeft <= 0)
        {

        }
    }
}
