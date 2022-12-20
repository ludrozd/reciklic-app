using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{
 public GameObject[] objects;

    void Start()
    {
           InvokeRepeating("createObject", 0.1f, 5f);

    }

    void Update()
    {

    }

    public void createObject()
    {   
        int objectIndex = Random.Range(0, objects.Length);
        Instantiate(objects[objectIndex], new Vector3(Random.Range(1.5f, -0.8f), Random.Range(1.9f, 2.1f), 0), objects[objectIndex].transform.rotation);
    }
}
