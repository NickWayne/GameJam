using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public int speed;
    private bool grounded;
    public GameObject ground;
    public GameObject MapGenerator;

	// Use this for initialization
	void Start ()
    {
        grounded = true;
	}
	
	// Update is called once per frame
	void Update () {
        var move = new Vector3(1, 0, 0);
        transform.position += move * speed * Time.deltaTime;


        foreach (GameObject o in MapGenerator.GetComponent<GenerateMap>().floorObjects)
        {
            if (GetComponent<Rigidbody2D>().IsTouching(o.GetComponent<BoxCollider2D>()))
            {
                grounded = true;
            }
        }

        if (Input.GetKeyDown("space") && grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 250));
            grounded = false;
        }

    }
}
