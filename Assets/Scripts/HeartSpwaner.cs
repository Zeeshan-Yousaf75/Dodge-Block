using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSpwaner : MonoBehaviour
{
    public GameObject heartPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("HeartSpwan", 3.5f, 5.5f);
    }

    public void HeartSpwan()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-9,9),transform.position.y,transform.position.z);
        Instantiate(heartPrefab, spawnPos, heartPrefab.transform.rotation);
    }

}
