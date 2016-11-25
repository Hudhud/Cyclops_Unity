using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{

    float timeLeft = 30.0f;
    public TextMesh countdown, gameOverText;
    static int i;
    public Hit counter;
    private bool finished;

    // Use this for initialization
    void Start()
    {
        finished = false;
        gameOverText.gameObject.SetActive(false);
        counter = gameObject.AddComponent<Hit>();
        countdown = GameObject.Find("CountDownText").GetComponent<TextMesh>();
        i = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        if (finished) return;

        if (timeLeft >= 0)
        {
            timeLeft -= Time.deltaTime;
            countdown.text = "Time: " + Mathf.Round(timeLeft);

            if (GameObject.FindGameObjectWithTag("Can") == null)
            {
                finished = true;
                gameOverText.text = i == SceneManager.sceneCountInBuildSettings -1? "GAME WON" : "LEVEL COMPLETE";
                gameOverText.gameObject.SetActive(true);
                StartCoroutine(Wait(3));
                counter.Restartcounter();
            }

        }
        else
        {
            finished = true;
            gameOverText.text = "GAME OVER";
            gameOverText.gameObject.SetActive(true);
        }
    }

    IEnumerator Wait(float sec)
    {
        yield return new WaitForSeconds(sec);
        SceneManager.LoadScene(++i);
    }
}
