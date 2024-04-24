using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    public static GameManager instance;
    public string _stageName = "Stage Zero";

    public enum GameStage
    {
        inti = 0,
        dataLoad = 1,
        start = 2,
        GameLoop = 3,
        GameEnd = 4,
        destroy = 5,
    }

    public GameStage state;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else 
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case GameStage.inti:
                { 
                    Debug.Log("My state is inti"); 
                }
                break;
            case GameStage.dataLoad:
                { 
                    Debug.Log("My state is DataLoad");
                }
                break;
            case GameStage.start:
                {
                    Debug.Log("My state is start");
                }
                break;
            case GameStage.GameLoop:
                {
                    Debug.Log("My state is GameLoop");
                }
                break;
            case GameStage.GameEnd:
                {
                    Debug.Log("My state is GameEnd");
                }
                break;
            case GameStage.destroy:
                {
                    Debug.Log("My state is destroy");
                }
                break;
        }
    }
}
