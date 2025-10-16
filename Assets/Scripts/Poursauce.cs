using UnityEngine;
using UnityEngine.UI;

public class Poursauce : MonoBehaviour
{
    public pizzamaker mypizza; 
    public Image saucefiller; 
    public float speed = 1f;
    public GameObject[] sauces;
    public float filledstop = 0f; 
    public GameObject sauceButton;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject pizza = GameObject.Find( "PizzaMaker" );
        mypizza = pizza.GetComponent<pizzamaker>(); 
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButton( 0 ))
        {
           saucefiller.fillAmount += speed * Time.deltaTime;
           filledstop = saucefiller.fillAmount;
        }   

        if(Input.GetMouseButtonUp(0)){
             makeSauce();
        }
    }

   public void makeSauce ()
{
    if (filledstop < 0.641){
        Instantiate<GameObject>(sauces[0]);
         mypizza.sauceScore += 50; 
    } else if (filledstop >= 0.641 || filledstop <= 0.706){
        Instantiate<GameObject>(sauces[1]);
         mypizza.sauceScore += 100; 
    } else {
        Instantiate<GameObject>(sauces[2]);
         mypizza.sauceScore += 25; 
    }

   Destroy(sauceButton);
   mypizza.sauced = true;
}
    
    
    

   
}
