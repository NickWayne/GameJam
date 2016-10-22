using UnityEngine;
using System.Collections;

public class CameraFixHeight : MonoBehaviour {

    private float height;
    private float finalX;
    private float finalZ;

    public GameObject floor;
    public int gameWidth;

    public GameObject time;
    public GameObject Explosion;
    public GameObject player;

    private float groundSize;

    private bool first = true;

	// Use this for initialization
	void Start () {
        height = this.transform.position.y;
        groundSize = floor.GetComponent<SpriteRenderer>().sprite.bounds.size.x * floor.transform.localScale.x;

    }

    // Update is called once per frame
    void Update() {
        if (this.transform.position.x < gameWidth * groundSize - groundSize / 2) {
            this.transform.position = new Vector3(this.transform.position.x, height, this.transform.position.z);
        }
        else
        {
            if (first)
            {
                finalX = this.transform.position.x;
                finalZ = this.transform.position.z;

                time.GetComponent<Timer>().done = true;
                Debug.Log("Written");
                first = false;

                Instantiate(Explosion, new Vector2(player.transform.position.x, 0.2f), player.transform.rotation);
            }
            this.transform.position = new Vector3(finalX, height, finalZ);
        }
	}
}
