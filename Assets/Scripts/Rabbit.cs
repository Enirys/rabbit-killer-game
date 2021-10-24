using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit : MonoBehaviour
{

    private void OnMouseDown()
    {
        if(gameObject.GetComponent<RabbitDanger>())
        {
            Debug.Log("You fond the one!");
            GameManager.instance.score += 100;
            GameManager.instance.spawnedRabbits = false;
            GameManager.instance.startBtn.SetActive(true);
            
            foreach (GameObject rabbit in Spawner.instance.allRabbits)
            {
                Destroy(rabbit.gameObject);
            }
            Destroy(Spawner.instance.danger);
        } else
        {
            Debug.Log("You lost");
            RabbitDanger.instance.Attack();

            foreach (GameObject rabbit in Spawner.instance.allRabbits)
            {
                Destroy(rabbit.gameObject);
            }
        }
    }
}
