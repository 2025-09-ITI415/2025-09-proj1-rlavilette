using UnityEngine;

public class CloseIfOnCustomers : MonoBehaviour
{

    public camswitcher viewcontroller;
    public GameObject pizzatasks;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         GameObject viewfind = GameObject.Find( "Views" );
            viewcontroller = viewfind.GetComponent<camswitcher>(); 
         
          
    }

    // Update is called once per frame
    void Update()
    {
        if(viewcontroller.ondiningroom == false){
            pizzatasks.SetActive(true);

        } else {
            pizzatasks.SetActive(false);
        }
    }
}
