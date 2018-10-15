using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

    public static Manager instance = null;
    public object currentScene;
    public GameObject player;
    
    void Awake() //singleton
    {
        //Singleton
        if (instance == null)  //if instance is not assigned
        {
            instance = this;  //then assign instance to this object
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);  //then destroy this object
        }

        //DontDestroyOnLoad(this.gameObject);
    }

    public void Respawn()
    {
        //yield return new WaitForSeconds(5);
        GameObject newplayer = Instantiate(player);
        Camera.main.GetComponent<CameraMovment>().player = newplayer;
    }


    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  //load next scene going up by 1
    }
    
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
