using UnityEngine;
using System.Collections;

public class TableMovement : MonoBehaviour {

    public float speed = 1.0f;
    public float length = 0.5f;

    void Update()
    {
        transform.position = new Vector3(transform.position.x + (Mathf.PingPong(Time.time * speed, length) - 0.5f * length), transform.position.y, transform.position.z);
    }
}
