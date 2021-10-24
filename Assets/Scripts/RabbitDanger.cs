using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitDanger : MonoBehaviour
{
    public static RabbitDanger instance;

    public MeshRenderer head;
    public MeshRenderer body;

    public Color white;

    public GameObject eye1;
    public GameObject eye2;
    
    Vector3 targetPos;
    

    private void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void Attack()
    {
        ChangeToAlbinos();
        GameManager.instance.gameOver = true;
        GameManager.instance.gameStarted = false;
    }

    public void ChangeToAlbinos()
    {
        head.materials[0].color = white;
        body.materials[0].color = white;

        eye1.GetComponent<Eyes>().AlbinosEyes();
        eye2.GetComponent<Eyes>().AlbinosEyes();
    }
}
