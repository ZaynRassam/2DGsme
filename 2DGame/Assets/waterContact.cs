using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class waterContact : MonoBehaviour
{
     

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collider that entered the trigger belongs to the character
        if (other.gameObject.tag == "Player")
        {
            // Reset the scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Debug.Log("Game Restarted");
        }
    }
}
