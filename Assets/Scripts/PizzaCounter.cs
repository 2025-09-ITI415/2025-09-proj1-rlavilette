using UnityEngine;

public class PizzaCounter : MonoBehaviour
{
    public pizzamaker mypizza; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            GameObject pizza = GameObject.Find( "PizzaMaker" );
        mypizza = pizza.GetComponent<pizzamaker>(); 
    }

    // Update is called once per frame
    void Update()
    {
         mypizza.pepscount.text = mypizza.pepperonicnt.ToString( "#,0" );
         mypizza.cheesecount.text = mypizza.cheesecnt.ToString("#,0");
    }
    
    public void addPizza()
   {
    if (mypizza.cooked == true){
         mypizza.pepscount.text = mypizza.pepperonicnt.ToString( "#,0" );
         mypizza.cheesecount.text = mypizza.cheesecnt.ToString("#,0");
    }

   }
}
