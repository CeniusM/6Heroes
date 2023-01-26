using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityManager : MonoBehaviour
{
    public GameObject hero1;

    float TimeToSpawn = 0.1f;
    float TimeSinceLastSpawn = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TimeSinceLastSpawn += Time.deltaTime;
        if (TimeSinceLastSpawn > TimeToSpawn)
        {
            SpawnHero();
            TimeSinceLastSpawn -= TimeToSpawn;
        }

    }

    void SpawnHero()
    {
        Instantiate(hero1, new Vector3(-10, Random.Range(-5, 5)), transform.rotation);
    }
}
