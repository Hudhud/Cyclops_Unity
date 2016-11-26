using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    private string ContinueText = "\nSHOOT SCOREBOARD TO RESTART";
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

        if (GameOverSingleton.Instance.GameOver) GameLost();

        if (timeLeft >= 0)
        {
            timeLeft -= Time.deltaTime;
            countdown.text = "Time: " + Mathf.Round(timeLeft);

            if (GameObject.FindGameObjectWithTag("Can") == null)
            {
                finished = true;
                if (i == SceneManager.sceneCountInBuildSettings - 1)
                {
                    gameOverText.text = "GAME WON" + ContinueText;
                    GameOverSingleton.Instance.GameOver = true;
                }
                else gameOverText.text = "LEVEL COMPLETE";
                gameOverText.gameObject.SetActive(true);
                StartCoroutine(Wait(3));
                counter.Restartcounter();
            }

        }
        else
        {
            GameLost();
        }
    }

    private void GameLost()
    {
        GameOverSingleton.Instance.GameOver = true;
        finished = true;
        gameOverText.text = "GAME OVER" + ContinueText;
        gameOverText.gameObject.SetActive(true);
    }

    IEnumerator Wait(float sec)
    {
        yield return new WaitForSeconds(sec);
        SceneManager.LoadScene(++i);
    }
}
