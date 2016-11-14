using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour {

    float timeLeft = 30.0f;
    public TextMesh countdown, gameOverText;
    static int i;
    public Hit counter;

    // Use this for initialization
    void Start ()
    {
        gameOverText.gameObject.SetActive(false);
        counter = gameObject.AddComponent<Hit>();
        countdown = GameObject.Find("CountDownText").GetComponent<TextMesh>();
        i = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update () {

        if (timeLeft >= 0)
        {
            timeLeft -= Time.deltaTime;
            countdown.text = "Time: " + Mathf.Round(timeLeft);

            if (GameObject.FindGameObjectWithTag("Can") == null)
            {
                gameOverText.gameObject.SetActive(true);
                counter.Restartcounter();
                StartCoroutine(Wait(3000));
                SceneManager.LoadScene(++i);
            }

        }
        else
        {

        }
    }

    IEnumerator Wait(float sec)
    {
        yield return new WaitForSeconds(sec);
    }
}
