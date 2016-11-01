using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

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
            
        if (timeLeft <= 0)
        {
            if (GameObject.FindGameObjectsWithTag("Can") == null)
            {
                SceneManager.LoadScene("Level 2"); 
            }
            else
            {
                Debug.Log("Taber");
            }
        }
    }
}
