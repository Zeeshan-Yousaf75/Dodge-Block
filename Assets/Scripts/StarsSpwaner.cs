using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsSpwaner : MonoBehaviour
{
    public GameObject starPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("StarsSpwan", 3.5f, 4.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StarsSpwan()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-9, 9), transform.position.y, transform.position.z);
        Instantiate(starPrefab, spawnPos, starPrefab.transform.rotation);
    }
}
