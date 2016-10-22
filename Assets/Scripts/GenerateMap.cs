using UnityEngine;
using System.Collections;

public class GenerateMap : MonoBehaviour {

    public GameObject Locker;
    public GameObject Background;

    private Random random;
    private float BackgroundWidth;
    private float BackgroundHeight;

    // Use this for initialization
    void Start () {
        random = new Random();


        BackgroundWidth = Background.GetComponent<SpriteRenderer>().sprite.bounds.size.x;
        BackgroundHeight = Background.GetComponent<SpriteRenderer>().sprite.bounds.size.y;

        int numBackground = 15;
        for (int i = 0; i < numBackground; i++) {
            Instantiate(Background, (new Vector3(-6 + i * BackgroundWidth, BackgroundHeight / 2, 0)), Quaternion.identity);
        }
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
