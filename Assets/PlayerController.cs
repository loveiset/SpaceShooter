using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMax = 6.9f;
    public float xMin = -6.9f;

    public float zMax = 11.2f;
    public float zMin = -2.0f;
}

public class PlayerController : MonoBehaviour {
    public Boundary bound;

    public float speed = 10.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        Vector3 move = new Vector3(h, 0f, v);
        rigidbody.velocity = move * speed;
        rigidbody.position = new Vector3(
            Mathf.Clamp(rigidbody.position.x, bound.xMin, bound.xMax),
            0,
            Mathf.Clamp(rigidbody.position.z, bound.zMin, bound.zMax));
    }
}
