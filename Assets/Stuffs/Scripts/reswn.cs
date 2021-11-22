using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class reswn : MonoBehaviour
{
    private GameObject Car;
    public GameObject scoreboard;
    public GameObject mainmenubutton;
    public GameObject pausebutton;
    public GameObject respbutton;
    bool GamePaused = true;
    
    void Start()
    {
        Car = GameObject.Find("body");
        Debug.Log("Play");
        Time.timeScale = 1;
        GamePaused = true;
        mainmenubutton.SetActive(false);
    }
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown("p")) {
            pause();
        }
    }

    public void respwn()
    {
        Debug.Log("Level Reset");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void mainmenu()
    {
        Debug.Log("Main Menu");
        SceneManager.LoadScene("MainMenu");
    }
    public void pause()
    {   
        if(GamePaused) {
            Debug.Log("Pause");
            Time.timeScale = 0;
            GamePaused = false;
            mainmenubutton.SetActive(true);
            respbutton.SetActive(true);
        }
        else if (scoreboard.GetComponent<score>().ded != true){
            Debug.Log("Play");
            Time.timeScale = 1;
            GamePaused = true;
            mainmenubutton.SetActive(false);
            respbutton.SetActive(false);
        }
        else if (scoreboard.GetComponent<score>().ded == true){
            Debug.Log("Dead Partial Play");
            Time.timeScale = 1;
            GamePaused = true;
            mainmenubutton.SetActive(false);
        }
    }
    public void flip()
    {   
        if (Car.transform.eulerAngles.z <220 && Car.transform.eulerAngles.z > 140) {
            Car.transform.Rotate (new Vector3 (0, 0, -180));
            Debug.Log("Flip Complete");
            scoreboard.GetComponent<score>().flipcounter = scoreboard.GetComponent<score>().flipcounter + 1;
            Debug.Log("Flip Counter " + scoreboard.GetComponent<score>().flipcounter);
        }
        else {
            Debug.Log("No Flip Needed");
        }
    }
    public void tow()
    {   
        if (Car.transform.position.y > 1) {
            Debug.Log("TOWING CAR" + scoreboard.GetComponent<score>().towcounter);
            Car.transform.position = new Vector3(Car.transform.position.x-100, Car.transform.position.y+5, Car.transform.position.z);
            scoreboard.GetComponent<score>().towcounter = scoreboard.GetComponent<score>().towcounter + 1;
        }
        else {
            Debug.Log("Tow Not Availible");
        }
    }
}
