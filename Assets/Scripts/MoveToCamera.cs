using UnityEngine;
using System.Collections;

public class MoveToCamera : MonoBehaviour
{

    public float speed;
    public Transform target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
	    if (transform.position.Equals(target.position))
	    {
	        print("it's lit");
	    }
    }
}
