using UnityEngine;
 using UnityEngine.UI;

public class openminigame : MonoBehaviour
{
    public GameObject minigame;
    public Text active;
    public Button Go;
  
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openMinigame(){
        Instantiate<GameObject>(minigame);
        Go.interactable = false;
        active.text = "done!";
    }
}
