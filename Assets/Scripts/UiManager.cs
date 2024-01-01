using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public Image heart1;
    public Image heart2;
    public Image heart3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HealthSystem.health == 10)
        {
            heart1.gameObject.SetActive(true);
            heart2.gameObject.SetActive(false);
            heart3.gameObject.SetActive(false);
        }
        else if (HealthSystem.health ==  20)
        {
            heart1.gameObject.SetActive(true);
            heart2.gameObject.SetActive(true);
            heart3.gameObject.SetActive(false);
        }
        else if (HealthSystem.health == 30)
        {
            heart1.gameObject.SetActive(true);
            heart2.gameObject.SetActive(true);
            heart3.gameObject.SetActive(true);
        }
        else if (HealthSystem.health <= 0 )
        {
            //game over!
            heart1.gameObject.SetActive(false);
            heart2.gameObject.SetActive(false);
            heart3.gameObject.SetActive(false);
        }
    }
}
