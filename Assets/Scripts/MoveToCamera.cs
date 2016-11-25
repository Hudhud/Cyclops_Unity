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
	void Update ()
    {  
        if(GameOverSingleton.Instance.GameOver) return;
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
	    if (transform.position.Equals(target.position))
	    {
            Destroy(gameObject);
	        GameOverSingleton.Instance.GameOver = true;
	        print("lost");
	    }
    }
}
