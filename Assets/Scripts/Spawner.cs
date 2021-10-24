using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Reference to this spawner

    public static Spawner instance;

    //number of rabbits

    public int nbRabbitsToSpawn;
    public int nbSpawnedRabbits;

    //List of all rabbits

    public List<GameObject> allRabbits = new List<GameObject>();

    //Rabbit prefabs

    public GameObject normalRabbit;
    public GameObject dangerRabbit;

    //Map Limits

    public float maxX;
    public float maxZ;
    public float minX;
    public float minZ;

    public GameObject danger;

    private void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    //Spawning all rabbits

    public void SpawnRabbits()
    {
        Debug.Log("Spawner.. SpawnRabbits");

        //Initilize list of all rabbits

        allRabbits.Clear();

        //Spawn danger rabbit in a random position
        // and add him to the list

        danger = Instantiate(dangerRabbit, GetRandomSpawnPosition(dangerRabbit), Quaternion.identity);

        //Spawn normal rabbits in a random positions
        // and add them to the list

        while (nbSpawnedRabbits <= nbRabbitsToSpawn)
        {
            GameObject rabbit = Instantiate(normalRabbit, GetRandomSpawnPosition(normalRabbit), Quaternion.identity);
            allRabbits.Add(rabbit);
            nbSpawnedRabbits++;
        }
    }

    //Generate a random spawn position for the rabbits

    public Vector3 GetRandomSpawnPosition(GameObject prefab)
    {
        float posX = Random.Range(minX, maxX);
        float posZ = Random.Range(minZ, maxZ);

        return new Vector3(posX, prefab.transform.position.y, posZ);
    }
}
