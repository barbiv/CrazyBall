using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScoreEditor : MonoBehaviour
{

    public Text scoreText;

    void Start()
    {
        scoreText.text = "Score: " + GameManager.instance.score;
    }

}
