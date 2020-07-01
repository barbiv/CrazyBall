using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public float ballSpeed = 1f;
    public float jumpForce = 1f;
    public int score = 0;
    public float wallHeight = 0;
    public float wallWidth = 0;
    public float fadeTime = 3;
    public Vector3 cameraOffset = new Vector3(0, 15, -30);
    public bool isPaused = false;
    //List<Transform> obstacles = new List<Transform>();


    void Awake()
    {
        if(instance != null){
            Destroy(gameObject);
        }else{
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void ChangeBallSpeed(float input){
        ballSpeed = input;
    }

    public void changeJumpForce(float input)
    {
        jumpForce = input;
    }

    public void changeCameraDistance(float input)
    {
        cameraOffset.Set(cameraOffset.x, cameraOffset.y, input);
    }

    public void changeCameraHeight(float input)
    {
        cameraOffset.Set(cameraOffset.x, input, cameraOffset.z);
    }

    public void ChangeWallHeight(float input){
        wallHeight = input;
    }

    public void ChangeWallWidth(float input){
        wallWidth = input;
    }

    public void ChangeFadeTime(float input)
    {
        fadeTime = input;
    }

    public void AddScore(int score){
        this.score += score;
        Debug.Log("The Score is: " + this.score);
    }

    public void FadeCubes(){
        ObstacleSizeDetector[] obstacles = FindObjectsOfType<ObstacleSizeDetector>();
        foreach(ObstacleSizeDetector obstacle in obstacles){
            obstacle.FadeObstacle();
        }
    }

    public void ResetScore(){
        this.score = 0;
    }

    public void PauseGame(){
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame(){
        Time.timeScale = 1f;
        isPaused = false;
    }

}
