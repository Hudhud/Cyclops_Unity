using UnityEngine;
using System.Collections;
using System;
using System.Threading;

public class Hit : MonoBehaviour {

    public GameObject effect;
    private static int count = 0;
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
        source.PlayOneShot(destroySound, 1F);
        GetComponent<Renderer>().enabled = false;
        Instantiate(effect, transform.position, transform.rotation);
        DestroyImmediate(gameObject);
        //destroySound;
        count++;
        countText.text = "Count: " + count.ToString();
        
       
    }



}
