using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager2 : MonoBehaviour
{
    public GameObject[] animalPrefab;

    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;

    private float spawnxRight = 26;
    private float sideSpawnMaxZ = 14;
    private float sideSpawnMinZ = -3;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnAnimalRight", startDelay, spawnInterval);
        InvokeRepeating("SpawnAnimalLeft", startDelay, spawnInterval);
    }

    private void SpawnAnimal()
    {
        int randomIndex = Random.Range(0, 2);
        Vector3 randomPos = new Vector3((Random.Range(-10f, 10f)), 0, 19);
       
        Instantiate(animalPrefab[randomIndex], randomPos, animalPrefab[randomIndex].transform.rotation);

    }

    private void SpawnAnimalRight()
    {
        int randomIndex = Random.Range(0, 2);
        Vector3 randomPos = new Vector3(spawnxRight, 0, Random.Range(sideSpawnMinZ,sideSpawnMaxZ ));
        Vector3 rotation = new Vector3(0, -90, 0);

        Instantiate(animalPrefab[randomIndex], randomPos, Quaternion.Euler(rotation));
    }

    private void SpawnAnimalLeft()
    {
        int randomIndex = Random.Range(0, 2);
        Vector3 randomPos = new Vector3(-spawnxRight, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, 90, 0);

        Instantiate(animalPrefab[randomIndex], randomPos, Quaternion.Euler(rotation));
    }

}
