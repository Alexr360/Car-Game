using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using UnityEngine.Experimental.Rendering.LWRP;

public class score : MonoBehaviour
{
    private GameObject car;
    int distance;
    int scoresad;
    int disold;
    float carvel;
    public bool ded = false;
    public bool highscores = false;
    public bool mapcomplete = false;
    public bool mapcompletelpv = false;
    public float endMap;
    public int flipcounter = 0;
    public int towcounter = 0;
    public int highscoredata = 0000;
    public GameObject deadMessage;
    public GameObject highScore;
    public GameObject respwnButton;

    void Start() {
        car = GameObject.Find("body");
        if (PlayerPrefs.HasKey("highscoregame")) {
            highscoredata = int.Parse(PlayerPrefs.GetString("highscoregame"));
            highScore.GetComponent<Text>().text = "Highscore: " + highscoredata;
        }
        else {
            highScore.GetComponent<Text>().text = "No Highscores";
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoresad = distance - (flipcounter * 25);
        scoresad = scoresad - (towcounter * 100);
        if (ded) {
            if (highScore.GetComponent<Text>().text == "No Highscores" && highscores || highscoredata < scoresad && highscores) {
                highScore.GetComponent<Text>().text = "New Highscore: " + scoresad;
                PlayerPrefs.SetString("highscoregame", scoresad.ToString());
                PlayerPrefs.Save();
                Debug.Log("New High Score: " + scoresad);
            }
            gameObject.GetComponent<Text>().text = "Final distance: " + scoresad;
            deadMessage.SetActive(true);
            respwnButton.SetActive(true);
        }
        else if (Time.timeScale == 0) {
            gameObject.GetComponent<Text>().text = "Paused distance: " + scoresad;
            if (Input.GetKey("`") && Input.GetKey("1")) {
                PlayerPrefs.SetString("highscoregame", "0");
                highScore.GetComponent<Text>().text = "New Highscore: 0";
                PlayerPrefs.Save();
            }
        }
        else {
            distance = (int)car.transform.position.x;
            distance = Mathf.Max(distance, 0, disold);
            carvel = Mathf.Round(car.GetComponent<Rigidbody2D>().velocity.magnitude * 2);
            if (distance == 0 && carvel < 5)
            {
                gameObject.GetComponent<Text>().text = "Press Arrow Keys or WASD to move.";
            }
            else if (distance == 0 && carvel > 5)
            {
                gameObject.GetComponent<Text>().text = "Speed: " + carvel;
            }
            else if (carvel < 2)
            {
                gameObject.GetComponent<Text>().text = "Distance: " + scoresad;
                disold = distance;
            }
            else
            {
                gameObject.GetComponent<Text>().text = "Distance: " + scoresad + " Speed: " + carvel;
                disold = distance;
                if (scoresad > endMap && mapcompletelpv != true) {
                    mapcomplete = true;
                }
                else if (mapcompletelpv == true) {
                    endMap = endMap *2;
                    mapcomplete = false;
                    mapcompletelpv = false;
                }
            }
            if (highscoredata < scoresad && highscores)
            {
                highScore.GetComponent<Text>().text = "New Highscore: " + scoresad;
                PlayerPrefs.SetString("highscoregame", scoresad.ToString());
                PlayerPrefs.Save();
            }
        }
    }
}
