using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayController : MonoBehaviour
{
    public static GamePlayController Instance; //Singleton
    public pipeController pipeController;
    public ScoreController scoreController;
    public StartPopUp startPopUp;
    public EndGamePopUp endGamePopUp;
    public BirdCobtroller birdController;


    public void Awake() //van chay even tho the scipt is turned off
    {
        Instance = this; //instance first
        scoreController.Init(); //score chay 

        startPopUp.Init();
        endGamePopUp.Init();



    }
    public void StartGame()
    {
        pipeController.Init();
        birdController.Init();
    }
    
    
}
