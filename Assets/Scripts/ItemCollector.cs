using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemCollector : MonoBehaviour
{
    public static int Keys;

    [SerializeField] private Text KeysText;


    private void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Key"))
        {
            Destroy(collision.gameObject);
            Keys++;
            KeysText.text = "Keys: " + Keys;
            //GetComponent<BoxCollider2D>().enabled = false;
        }
    }


}
