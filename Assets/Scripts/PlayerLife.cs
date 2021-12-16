using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerLife : MonoBehaviour
{

    private int health = 3;

    [SerializeField] private Text LivesText;




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Spikes"))
        {
            
            health--;
            LivesText.text = "Lives: " + health;
           
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Spikes"))
        {
            health -= 1;
            LivesText.text = "Lives: " + health;

            if (health <= 0)
            {


                SceneManager.LoadScene("Death Screen");
            }
        }
    }

}
