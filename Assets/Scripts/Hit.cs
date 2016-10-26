using UnityEngine;
using System.Collections;
using System;

public class Hit : MonoBehaviour {

    public GameObject effect;
    private static int count = 0;
    public TextMesh countText;

    // Use this for initialization
    void Start () {
        effect = GameObject.Find("HitEffect");
        countText = GameObject.Find("CountText").GetComponent<TextMesh>();
        countText.text = "Count: " + count.ToString();
    }

    // Update is called once per frame
    void Update () {
	}

    public void Disappear()
    {
        Destroy(gameObject);
        count++;
        countText.text = "Count: " + count.ToString();
        Instantiate(effect, transform.position, transform.rotation);
    }

    
}
