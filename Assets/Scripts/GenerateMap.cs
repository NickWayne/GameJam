using UnityEngine;
using System.Collections;

public class GenerateMap : MonoBehaviour {

    public GameObject Player;
    public GameObject Locker;
    public GameObject Background;
    public GameObject Ground;

    private Random random;
    private float BackgroundWidth;
    private float BackgroundHeight;
    private float GroundWidth;
    private float GroundHeight;
    public GameObject[] floorObjects;

    // Use this for initialization
    void Start () {
        random = new Random();

        BackgroundWidth = Background.GetComponent<SpriteRenderer>().sprite.bounds.size.x;
        BackgroundHeight = Background.GetComponent<SpriteRenderer>().sprite.bounds.size.y;

        GroundWidth = Ground.GetComponent<SpriteRenderer>().sprite.bounds.size.x;
        GroundHeight = Ground.GetComponent<SpriteRenderer>().sprite.bounds.size.y;

        int numBackground = 15;
        for (int i = 0; i < numBackground; i++) {
            Instantiate(Background, (new Vector3(-6 + i * BackgroundWidth, BackgroundHeight / 2 + GroundHeight / 2, 0)), Quaternion.identity);
        }

        int numGround = 5;
        floorObjects = new GameObject[numGround];
        for (int i = 0; i < numGround; i++)
        {
            floorObjects[i] = (GameObject) Instantiate(Ground, (new Vector3(i * BackgroundWidth - BackgroundWidth / 2, 0, 0)), Quaternion.identity);
        }
        
	}

    public GameObject[] getFloorObjects()
    {
        return floorObjects;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
