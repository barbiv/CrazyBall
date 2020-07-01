using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void MoveToNextScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MoveToMainMenu(){
        SceneManager.LoadScene("MainMenuScene");
    }

    public void MoveToGameOver(){
        SceneManager.LoadScene("GameOverScene");
    }

    public void MoveToFirstLevel(){
        GameManager.instance.ResetScore();
        SceneManager.LoadScene(1);
    }
}
