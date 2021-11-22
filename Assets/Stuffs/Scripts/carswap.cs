using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class carswap : MonoBehaviour
{
    public GameObject CarLabel;
    public string[] scenes;
    private Text text;
    int CurrentCar = 1;
    void Start()
    {
        Debug.Log("Main Menu Start");
        Time.timeScale = 1;
    }
    public void carswapright()
    {
        CurrentCar = CurrentCar + 1;
        if (CurrentCar > scenes.Length) {
            Debug.Log("Reset Top");
            CurrentCar = 1;
        }
        CarLabel.GetComponent<Text>().text = scenes[CurrentCar-1];
        Debug.Log("Car Swap Right");
    }
    public void carswapleft()
    {
        CurrentCar = CurrentCar - 1;
        if (CurrentCar < 1) {
            Debug.Log("Reset Bottom");
            CurrentCar = scenes.Length;
        }
        CarLabel.GetComponent<Text>().text = scenes[CurrentCar-1];
        Debug.Log("Car Swap Left");
    }
    public void play()
    {
        Debug.Log("Game Started");
        SceneManager.LoadScene(scenes[CurrentCar-1]);
    }
}
