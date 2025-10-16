using UnityEngine;

public class topping : MonoBehaviour
{
    public pizzamaker thispizza; 
    public toppingscollider toppingscript;
    public int toppingnum = 0; 
    public int toppingcount;
    public GameObject[] toppings;
    public GameObject currentTopping; 
    public GameObject ToppingsHolder;
    public int pos = 0;
    public bool ontarget  = false;
    public int presses = 0;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
           GameObject pizza = GameObject.Find( "PizzaMaker" );
          thispizza = pizza.GetComponent<pizzamaker>(); 
           currentTopping =  toppings[presses];
           currentTopping.SetActive(true);
           toppingscript = currentTopping.GetComponentInChildren<toppingscollider>();
           ontarget = currentTopping.GetComponentInChildren<toppingscollider>().ontarget;
           
    }

    // Update is called once per frame
    void Update()
    {
        
        
        toppingscript = currentTopping.GetComponentInChildren<toppingscollider>();
        ontarget = currentTopping.GetComponentInChildren<toppingscollider>().ontarget;

        if (toppingcount == toppingnum){
            thispizza.topped = true; 

            Destroy(ToppingsHolder);
        }
   
    }
      


   


    public void toppingstop() 
    {
        

      
        if (currentTopping != null && toppingnum > toppingcount){
        Debug.Log("bun");
        
       currentTopping.GetComponentInChildren<toppingscollider>().stopTopping();
        presses++;
        toppingcount++;
       

        }
         if (presses >=4){
            presses = 4; 
        }

         currentTopping = toppings[presses];
        if (ontarget == true){
            thispizza.toppingsscore += 20;
        }
         toppings[presses].SetActive(true);
        
 
          
        
      
    }
}

       

