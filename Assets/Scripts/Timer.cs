using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

    public Text TimerText;
    public float time;
    public bool done;

    // Use this for initialization
    void Start () {
        time = 35.0f;
        done = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (time > 0 && !done) {
            time -= Time.deltaTime;
        }

        else if (time < 0) {
            time = 0;
        }
        

        int minutes = (int) System.Math.Floor(time / 60.0f); //Divide the guiTime by sixty to get the minutes.
        int seconds = (int) time % 60;//Use the euclidean division for the seconds.
        int fraction = (int) (time * 100) % 100;

        //update the label value
        TimerText.text = string.Format("{0:00} : {1:00} : {2:00}", minutes, seconds, fraction);
    }
}
