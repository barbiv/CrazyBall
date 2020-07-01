using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSizeDetector : MonoBehaviour
{

    //private Transform startTransform;
    //private Vector3 startScale;
    private float startX, startY;
    public MeshRenderer renderer;
    public BoxCollider boxCollider;
    public Material normalObstacleMat, fadedObstacleMat;


    void Start()
    {
        startX = transform.localScale.x;
        startY = transform.localScale.y;
        renderer = GetComponent<MeshRenderer>();
        boxCollider = GetComponent<BoxCollider>();
    }

    void Update()
    {
        transform.localScale = new Vector3(startX + GameManager.instance.wallWidth, startY + GameManager.instance.wallHeight, transform.localScale.z);; 

    }

    public void FadeObstacle(){
        renderer.material = fadedObstacleMat;
        boxCollider.enabled = false;
        {
            Invoke("UnFadeObstacles", GameManager.instance.fadeTime);
        }
    }

    public void UnFadeObstacles(){
        renderer.material = normalObstacleMat;
        boxCollider.enabled = true;
    }

}
