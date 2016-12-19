using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

    public void RunGame()
    {
        SceneManager.LoadScene(1);
    }
}
