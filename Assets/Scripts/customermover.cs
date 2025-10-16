using UnityEngine;

public class customermover : MonoBehaviour{

    public float speed = 1f;
    public bool queueup = false;
    public bool firstspotfilled = false;
    public orderingcustomer servedornah;
    public GameObject thing;
    public GameObject count;
    public pizzamaker thispizza;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         servedornah = GetComponent<orderingcustomer>(); 
            GameObject pizza = GameObject.Find( "PizzaMaker" );
            thispizza = pizza.GetComponent<pizzamaker>(); 
         
          

       
    }

    // Update is called once per frame
    void Update()
    {
          Vector3 customerpos = transform.position;

          if (servedornah.served){
            speed = 5; 
            if (thispizza.firstspotfilled == true){
                thispizza.firstspotfilled = false;
            }
            
                      }
         if (customerpos.x <= 84.8 && servedornah.served == false){
            speed = 0;
            thispizza.firstspotfilled = true;
           servedornah.isfirstcustomer = true;
           servedornah.issecondcustomer = false;
            }
          if ((int)customerpos.x == 88 && servedornah.served == false && thispizza.firstspotfilled == true){
            speed = 0;
            thispizza.secondspotfilled = true;
           servedornah.issecondcustomer = true;
           servedornah.isthirdcustomer = false;
        } else if ((int)customerpos.x == 92 && servedornah.served == false && thispizza.firstspotfilled==true && thispizza.secondspotfilled == true){
            speed = 0;
            servedornah.isthirdcustomer = true;
       
            } else {
             customerpos = transform.position;  
          customerpos.x -= speed * Time.deltaTime; 
         transform.position = customerpos;
       }         
    
}
  
  

}  
     

  

