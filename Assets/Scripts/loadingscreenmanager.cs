using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class loadingscreenmanager : MonoBehaviour
{

    public Text HTP;
    public GameObject MainScreen;
    public GameObject HTPscreen;
    public bool onmainscreen = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void howtoplayclick(){
        HTP.text = ("Back To Main");

        if (onmainscreen == true){
        MainScreen.SetActive(false);
        HTPscreen.SetActive(true);
        onmainscreen = false;
        } else {
         MainScreen.SetActive(true);
        HTPscreen.SetActive(false);
        onmainscreen = true;
    }
}


public void replaygame(){
 SceneManager.LoadScene( "Game" );
}
}

