using UnityEngine;
using System.Collections;
using System;

public class Hit : MonoBehaviour {

    public GameObject effect;
    private ParticleSystem _psystem;

    // Use this for initialization
    void Start () {
        effect = GameObject.Find("HitEffect");
    }

    // Update is called once per frame
    void Update () {
	
	}
    public void Disappear()
    {
        Destroy(gameObject);
        Instantiate(effect, transform.position, transform.rotation);
    }
}
