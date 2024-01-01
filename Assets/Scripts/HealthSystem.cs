using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthSystem : MonoBehaviour
{
    public static int health = 30;
    public static int stars = 0;

    public GameObject gameOverPanel;
    public GameObject blackScreenEffect;

    private GameObject collideObj;

    private bool isGameOver;

    public TextMeshProUGUI starsText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Time.timeScale = 0f;
            gameOverPanel.SetActive(true);
            isGameOver = true;

        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (isGameOver)
            {
                Time.timeScale = 1f;
                gameOverPanel.SetActive(false);
                 health += 30;
                 isGameOver = false;
            }
        }

        starsText.text = stars.ToString();
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        collideObj = collision.gameObject;  
        if (collision.gameObject.tag == "Enemy")
        {
            if (health != 0)
            {
             health -= 10;
            }
            blackScreenEffect.SetActive(true);
            Time.timeScale = 0.2f;

            StartCoroutine(Slomo());
        }

        if (collision.gameObject.tag == "Heart")
        {
            collision.gameObject.SetActive(false);
            health += 10;
        }



        if (collision.gameObject.tag == "Star")
        {
            stars += 1;
            collision.gameObject.SetActive(false);
        }
    }

    IEnumerator Slomo()
    {
        yield return new WaitForSeconds(0.3f);
        Time.timeScale = 1;
        blackScreenEffect.SetActive(false);
        collideObj.SetActive(false);
    }
}
