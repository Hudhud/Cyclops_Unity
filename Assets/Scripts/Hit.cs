using UnityEngine;
using System.Collections;
using System;
using System.Threading;

public class Hit : MonoBehaviour {

    public GameObject effect;
    private static int count = 0;
    public TextMesh countText;
    public Texture2D textureToUse;
    public AudioClip destroySound;
    private AudioSource source;

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
        
        source.PlayOneShot(destroySound, 1F);
        GetComponent<Renderer>().enabled = false;        
        count++;
        countText.text = "Count: " + count.ToString();
        Instantiate(effect, transform.position, transform.rotation);
    }



}
