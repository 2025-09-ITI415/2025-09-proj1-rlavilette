using UnityEngine;
using UnityEngine.UI;
public class camswitcher : MonoBehaviour
{
 
 public Camera foodview;
public Camera serveview;
public GameObject foodui;
public GameObject peopleui;
public Text foodorcust;
public bool ondiningroom;


public void Update()
{
   
}

public void camswitch()
{
   
   if(foodview.enabled == false){
    foodview.enabled = true;
    serveview.enabled = false;
    ondiningroom = false;
   } 

   else {
    serveview.enabled = true;
    foodview.enabled = false; 
    ondiningroom = true;
   }

    if (foodview.enabled == true){
        foodui.SetActive(true);
        foodorcust.text = ("Serve Customers");

    } else {
        foodui.SetActive(false);
        foodorcust.text = ("Cook Pizzas");
    }
    
    
}
}
