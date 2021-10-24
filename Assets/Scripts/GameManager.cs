using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Reference to the GameManager
    public static GameManager instance;

    public bool spawnedRabbits = false;
    public bool gameOver = false;
    public bool gameStarted = false;
    public bool scored = false;
    

    //Panels and UI Elements
    public GameObject gamePanel;
    public GameObject gameoverPanel;
    public GameObject startBtn;

    public Text scoreText;

    public int score;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    private void Update()
    {

        if(!gameOver)
        {
            if (gameStarted && !spawnedRabbits)
            {
                Debug.Log("GameManager Update...");
                Spawner.instance.SpawnRabbits();
                Spawner.instance.nbSpawnedRabbits = 0;
                Spawner.instance.nbRabbitsToSpawn+=2;
                spawnedRabbits = true;
                gameStarted = false;
            }

            scoreText.text = "Score: " + score.ToString();
        }
        else
        {
            gamePanel.SetActive(false);
            gameoverPanel.SetActive(true);
        }
    }

    public void StartGame()
    {
        gameStarted = true;
    }
}
