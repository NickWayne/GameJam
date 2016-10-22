using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public int speed;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update () {
        var move = new Vector3(1, 0, 0);
        transform.position += move * speed * Time.deltaTime;
	}
}
