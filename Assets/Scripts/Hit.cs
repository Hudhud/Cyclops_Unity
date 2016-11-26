using UnityEngine;
using UnityEngine.SceneManagement;


public class Hit : MonoBehaviour {

    public GameObject effect;
    public static int count = 0;
    public TextMesh countText;
    public AudioClip destroySound;
    private AudioSource source;
    public float speed = 1;

    // Use this for initialization
    void Start () {
        effect = GameObject.Find("Explosion");
        countText = GameObject.Find("CountText").GetComponent<TextMesh>();
        countText.text = "Count: " + count.ToString();
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {

	}

    public void Disappear()
    {
        if (GameOverSingleton.Instance.GameOver) return;
        source.PlayOneShot(destroySound, 1F);
        Instantiate(effect, transform.position, transform.rotation);
        Destroy(gameObject);
        //destroySound;
        count++;
        countText.text = "Count: " + count.ToString();
        if (destroySound)
        {
            AudioSource.PlayClipAtPoint(destroySound, transform.position);
        }
           
    }

    public void Restartcounter()
    {
        count = 0;
    }

    public void Restart()
    {
        if (GameOverSingleton.Instance.GameOver)
        {
            GameOverSingleton.Instance.GameOver = false;
            SceneManager.LoadScene(0);
        }
    }
}
