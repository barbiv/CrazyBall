using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsPanelController : MonoBehaviour
{

    public Text playerSpeedValue, jumpForceValue, cameraDistanceValue, cameraHeightValue, wallHeightValue, wallWidthValue, fadeObstaclesValue;
    public Slider playerSpeedSlider, jumpForceSlider, cameraDistanceSlider, cameraHeightSlider, wallHeightSlider, wallWidthSlider, fadeObstaclesSlider;

    void Start()
    {
        playerSpeedValue.text = "= " + GameManager.instance.ballSpeed;
        jumpForceValue.text = "= " + GameManager.instance.jumpForce;
        cameraDistanceValue.text = "= " + GameManager.instance.cameraOffset.z;
        cameraHeightValue.text = "= " + GameManager.instance.cameraOffset.y;
        wallHeightValue.text = "= " + GameManager.instance.wallHeight;
        wallWidthValue.text = "= " + GameManager.instance.wallWidth;
        fadeObstaclesValue.text = "= " + GameManager.instance.fadeTime;

    }

    void OnEnable()
    {
        GameManager.instance.PauseGame();
    }

    void OnDisable()
    {
        GameManager.instance.ResumeGame();
    }

    public void setDefaultPreset(){
        SetPlayerValues(200, 18000);
        SetCameraValues(-30, 15);
        SetObstaclesValues(0, 0);
        SetFadeTime(3);
    }

    public void setSlowPreset()
    {
        SetPlayerValues(50, 10000);
    }

    public void setFastPreset()
    {
        SetPlayerValues(500, 22000);
    }

    public void setClosePreset()
    {
        SetCameraValues(-15, 5);
    }

    public void setFarPreset()
    {
        SetCameraValues(-60, 25);
    }

    public void setBigObstaclesPreset()
    {
        SetObstaclesValues(2, 3);
    }

    public void SetPlayerValues(int playerSpeed, int jumpForce){
        playerSpeedSlider.value = playerSpeed;
        jumpForceSlider.value = jumpForce;
    }

    public void SetCameraValues(int cameraDistance, int cameraHeight){
        cameraDistanceSlider.value = cameraDistance;
        cameraHeightSlider.value = cameraHeight;
    }

    public void SetObstaclesValues(int wallHeight, int wallWidth)
    {
        wallHeightSlider.value = wallHeight;
        wallWidthSlider.value = wallWidth;
    }

    public void SetFadeTime(int fadeTime)
    {
        fadeObstaclesSlider.value = fadeTime;
    }

    public void OnPlayerSpeedChange(float value){
        playerSpeedValue.text = "= " + value;
        GameManager.instance.ChangeBallSpeed(value);
    }

    public void OnJumpForceChange(float value)
    {
        jumpForceValue.text = "= " + value;
        GameManager.instance.changeJumpForce(value);
    }

    public void OnCameraDistanceValueChange(float value)
    {
        cameraDistanceValue.text = "= " + value;
        GameManager.instance.changeCameraDistance(value);
    }

    public void OnCameraHeightValueChange(float value)
    {
        cameraHeightValue.text = "= " + value;
        GameManager.instance.changeCameraHeight(value);
    }

    public void OnWallHeightValueChange(float value){
        wallHeightValue.text = "= " + value;
        GameManager.instance.ChangeWallHeight(value);
    }

    public void OnWallWidthValueChange(float value)
    {
        wallWidthValue.text = "= " + value;
        GameManager.instance.ChangeWallWidth(value);
    }

    public void OnFadeTimeValueChange(float value)
    {
        fadeObstaclesValue.text = "= " + value;
        GameManager.instance.ChangeFadeTime(value);
    }

}
