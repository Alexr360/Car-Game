using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomGen : MonoBehaviour
{

    //mainCamera
    private GameObject mainCamera;
    float newmainCameraX;
    float oldmainCameraXEnemy;
    float oldmainCameraXWorld;

    //Enemy
    float dificulty;
    public float enemyHOff = 75f;
    public float enemyVOff = 6.2f;
    public float enemyZOff = 0f;
    public GameObject[] enemies;

    //Level Gen
    public float mapHOff = 95f;
    public float mapVOff = -12f;
    public float mapZOff = 0f;
    public GameObject[] maps;

    void Start()
    {
        mainCamera = GameObject.Find("Main Camera  (Update For Change)");
        oldmainCameraXEnemy = mainCamera.transform.position.x;
        oldmainCameraXWorld = mainCamera.transform.position.x;
        dificulty = 0;
    }

    void Update()
    {
        newmainCameraX = mainCamera.transform.position.x;

        //Enemy Spawning
        if (oldmainCameraXEnemy + enemyHOff <= newmainCameraX) {
            oldmainCameraXEnemy = newmainCameraX;
            int num = Random.Range(0, enemies.Length);
            GameObject hp2 = Instantiate(enemies[num]);
        }

        //Level Gen
        if (oldmainCameraXWorld + mapHOff <= newmainCameraX)
        {
            oldmainCameraXWorld = newmainCameraX;
            int num = Random.Range(0, maps.Length);
            GameObject hp2 = Instantiate(maps[num]);
            hp2.transform.position = new Vector3(newmainCameraX + mapHOff, mapVOff, mapZOff);
        }
    }
}
