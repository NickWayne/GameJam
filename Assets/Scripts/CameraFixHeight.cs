using UnityEngine;
using System.Collections;

public class CameraFixHeight : MonoBehaviour {

    private float height;
    private float finalX;
    private float finalZ;

    public GameObject floor;
    public int gameWidth;

    private float groundSize;

	// Use this for initialization
	void Start () {
        height = this.transform.position.y;
        groundSize = floor.GetComponent<SpriteRenderer>().sprite.bounds.size.x * floor.transform.localScale.x;

    }

    // Update is called once per frame
    void Update() {
        if (this.transform.position.x < gameWidth * groundSize - groundSize / 2) {
            this.transform.position = new Vector3(this.transform.position.x, height, this.transform.position.z);
            if (this.transform.position.x < gameWidth * groundSize - groundSize / 2) {
                finalX = this.transform.position.x;
                finalZ = this.transform.position.z;
            }
        }
        else
        {
            this.transform.position = new Vector3(finalX, height, finalZ);
        }
	}
}
