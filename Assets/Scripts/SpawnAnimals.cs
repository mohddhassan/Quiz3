using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimals : MonoBehaviour
{
    private float startDelay = 2;
    private float spawnInterval = 1f;
    private GameObject playerGo;
    public GameObject[] animalPrefabs;
    void Start()
    {
        playerGo = GameObject.Find("Player");
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void Update()
    {
        //DestroyAnimal();
    }

    void SpawnRandomAnimal()
    {
        //Vector3 spawnPos = new Vector3(Random.Range(-3, 3), 0.42f, Random.Range(-19000, 19000));
        Vector3 spawnPos = new Vector3(Random.Range(-3, 3), 0.42f, playerGo.GetComponent<Transform>().transform.position.z + 10f);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    //private void DestroyAnimal()
    //{
    //    if (animalPrefabs[0].transform.position.z < playerGo.GetComponent<Transform>().transform.position.z)
    //    {
    //        DestroyImmediate(this.animalPrefabs[0], true);
    //    }

    //    else if (animalPrefabs[1].transform.position.z < playerGo.GetComponent<Transform>().transform.position.z)
    //    {
    //        DestroyImmediate(this.animalPrefabs[1], true);
    //    }
    //}
}
