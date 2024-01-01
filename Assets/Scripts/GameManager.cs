using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] platformPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("PlatformSpwaner", 2.0f, 3.5f);
    }

    private void Update()
    {
       
    }
    public void PlatformSpwaner()
    {
        int platformIndex = Random.Range(0,platformPrefabs.Length);
        Instantiate(platformPrefabs[platformIndex], transform.position, platformPrefabs[platformIndex].transform.rotation);
        if  ( transform.position.y < -10)
        {
            platformPrefabs[platformIndex].gameObject.SetActive(false);
        }
    }
}
