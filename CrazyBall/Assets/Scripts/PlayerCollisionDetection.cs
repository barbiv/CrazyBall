using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollisionDetection : MonoBehaviour
{

    public SceneController sceneController;
    public Text scoreText;

    void Start(){
        sceneController = FindObjectOfType<SceneController>();
    }

    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("We hit: " + collision.collider.tag);

        if(collision.collider.CompareTag("Obstacle")){
            sceneController.MoveToGameOver();
        }else if(collision.collider.CompareTag("FinishLine")){
            sceneController.MoveToNextScene();
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Coin"))
        {
            Debug.Log("Hit coin");
            collider.gameObject.SetActive(false);
            GameManager.instance.AddScore(10);
            scoreText.text = "Score: " + GameManager.instance.score;
        }else if(collider.CompareTag("FadedCube")){
            collider.gameObject.SetActive(false);
            GameManager.instance.FadeCubes();
        }

        
    }
}
