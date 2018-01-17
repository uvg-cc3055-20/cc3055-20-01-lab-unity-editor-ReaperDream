using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScrip : MonoBehaviour {

    float forceBird = 10f;
    float forwardSpeed = 2f;
    Rigidbody2D birb;
    GameObject cam;

	// Use this for initialization
	void Start () {
        birb = GetComponent<Rigidbody2D>();
        cam = GameObject.Find("Main Camera");
    }
	
	// Update is called once per frame
	void Update () {
        birb.velocity = Vector2.zero;
        if (Input.GetKey(KeyCode.Space)) {
            birb.AddForce(Vector2.up * forceBird);
            birb.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);
        }
        cam.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);

    }
}
