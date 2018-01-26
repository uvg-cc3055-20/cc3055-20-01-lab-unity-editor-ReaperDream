using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScrip : MonoBehaviour {

    public float forceBird;
    public float forceBird1;
    float forwardSpeed = 4f;
    Rigidbody2D birb;
    GameObject cam;
    bool crash = false;

	// Use this for initialization
	void Start () {
        birb = GetComponent<Rigidbody2D>();
        cam = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        birb.velocity = Vector2.zero;
        birb.AddForce(Vector2.down * forceBird1);
        birb.transform.Translate(new Vector3(0, 0, 1) * forwardSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.Space))
        {
            birb.AddForce(Vector2.up * forceBird);
            birb.transform.Translate(new Vector3(2, 0, 0) * forwardSpeed * Time.deltaTime);
        }
        cam.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Column")
        {
            Destroy(birb.gameObject);
        }
    }
}

