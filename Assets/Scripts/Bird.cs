using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {
    // Movement speed
    public float speed = 2;

    // Flap force
    public float force = 300;

    void OnCollisionEnter2D(Collision2D coll)
    {
        // Restart
        Application.LoadLevel(Application.loadedLevel);
    }

    // Use this for initialization
    void Start () {
        // Fly towards the right
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }
	
	// Update is called once per frame
	void Update () {
        // Flap
        if (Input.GetKeyDown(KeyCode.Space))
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
    }
}
