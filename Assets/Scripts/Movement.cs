using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float speed;
    public float length;

    void Update()
    {
        transform.position = new Vector3(transform.position.x + (Mathf.PingPong(Time.time * speed, length) - 0.5f * length), transform.position.y, transform.position.z);
    }
}
