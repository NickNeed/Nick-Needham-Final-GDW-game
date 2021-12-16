using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    private GameObject player;
    //public bool playerHasKey;
    private static int numkeys;
    //public GameObject key;
    //public KeyLogic KeyLogic;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        numkeys = ItemCollector.Keys;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

   public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Doesn't actually reconize you have 3 keys
            //&& playerHasKey == true
            //if (collision.gameObject.tag == "Player")
            //if (key.GetComponent<KeyLogic>().playerHasKey)

         
            
                SceneManager.LoadScene("End Screen");
            
        }  
        
    }

}
