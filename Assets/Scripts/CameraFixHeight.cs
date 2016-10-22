using UnityEngine;
using System.Collections;

public class CameraFixHeight : MonoBehaviour {

    private float height;

	// Use this for initialization
	void Start () {
        height = this.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector2(this.transform.position.x, height);
	}
}
