using UnityEngine;
using System.Collections;

public class BoltMove : MonoBehaviour {

    public float speed = 10.0f;

	// Use this for initialization
	void Start () {
        rigidbody.velocity = transform.forward * speed;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
