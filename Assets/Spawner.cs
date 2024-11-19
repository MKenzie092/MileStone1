using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject coin;
    public int numberToSpawn = 10;
    public float distanceCoin = 2.0f;

    void Start()
    {
        for (var i = 0; i < numberToSpawn; i++)
        {
            Instantiate(coin, new Vector3(i * distanceCoin, 1.36f, 0), Quaternion.identity);
        }
    }
}
