using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject cube; 

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CubeSpawner", 0f, 0.05f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CubeSpawner()
    {
        Instantiate(cube, new Vector3(Random.Range(-18, 19), Random.Range(-11, 12), 0), Quaternion.identity);
    }
}
