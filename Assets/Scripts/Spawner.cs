using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject cube; 
    [SerializeField] Material[] mats;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CubeSpawner", 0f, 0.001f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CubeSpawner()
    {
        Instantiate(cube, new Vector3(Random.Range(-17, 18), Random.Range(-9, 10), 0), Quaternion.identity);
        cube.GetComponent<Renderer>().material = mats[Random.Range(0, 3)];
    }
}
