using UnityEngine;
using System.Collections;

public class GenerateMap : MonoBehaviour {

    public GameObject Player;
    public GameObject Background;
    public GameObject Ground;
    public GameObject Finish;
    public GameObject[] Obstacles;

    private Random random;
    private float BackgroundWidth;
    private float BackgroundHeight;
    private float GroundWidth;
    private float GroundHeight;
    public GameObject[] floorObjects;
    private float TimeLeft;

    // Use this for initialization
    void Start () {
        random = new Random();

        BackgroundWidth = GetSize(Background, true);
        BackgroundHeight = GetSize(Background, false);

        GroundWidth = GetSize(Ground, true);
        GroundHeight = GetSize(Ground, false);

        double ratio = (GroundWidth / BackgroundWidth);
        Debug.Log(ratio);

        int GameWidth = 2;
        TimeLeft = 10.0f;

        int numBackground = (int) (ratio * GameWidth);
        for (int i = 0; i < numBackground; i++) {
            Instantiate(Background, (new Vector3(-6 + i * BackgroundWidth, BackgroundHeight / 2 + GroundHeight / 2 - 0.3f, 0.5f)), Quaternion.identity);
        }

        int numGround = GameWidth;
        floorObjects = new GameObject[numGround];
        for (int i = 0; i < numGround; i++)
        {
            floorObjects[i] = (GameObject) Instantiate(Ground, (new Vector3(i * GroundWidth, 0, 0)), Quaternion.identity);
        }

        Instantiate(Finish, (new Vector3(GameWidth * GroundWidth - GroundWidth / 2, 0, -0.25f)), Quaternion.identity);

        placeObstacles();


    }

    private float GetSize(GameObject o, bool x)
    {
        if (x)
            return o.GetComponent<SpriteRenderer>().sprite.bounds.size.x * o.transform.localScale.x;

        return o.GetComponent<SpriteRenderer>().sprite.bounds.size.y * o.transform.localScale.y;
    }

    public GameObject[] getFloorObjects()
    {
        return floorObjects;
    }

    private void placeObstacles()
    {
        int numObjects = 15;
        for (int i = 0; i < numObjects; i++)
        {
            Instantiate(Obstacles[Random.Range(0, Obstacles.Length)], new Vector3(Random.Range(5, 2 * GroundWidth - 5), .32f + GroundHeight / 2, 0), Quaternion.identity);
        }
        
    }


	// Update is called once per frame
	void Update () {
        TimeLeft -= Time.deltaTime;
        GUI.Label(new Rect(10, 10, 100, 20), string.Format("{0:0.00}",TimeLeft));
    }
}
