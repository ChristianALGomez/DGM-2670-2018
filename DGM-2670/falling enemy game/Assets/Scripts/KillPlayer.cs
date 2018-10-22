using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    public GameObject player;
    public Holder EndTime;

    private void Start()
    {
        player = GameObject.Find("Player");
        EndTime = GameObject.Find("Holder").GetComponent<Holder>();
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player") == collider)
        {
            Destroy(player);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            EndTime.Finished();
        }
    }
    
}
