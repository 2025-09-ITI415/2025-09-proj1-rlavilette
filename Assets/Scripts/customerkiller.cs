using UnityEngine;

public class customerkiller : MonoBehaviour
{
    public Customers lol;
    public pizzamaker pizza;
    public bool customerkilled;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (customerkilled == true){
            if (pizza.justserved == true && pizza.firstspotfilled == true )
             pizza.justserved = false;   
             customerkilled = false;
        }
    }

      void OnTriggerEnter(Collider coll ) {                             
        GameObject customer = coll.gameObject;                        
         if ( customer.CompareTag("servedcustomer") ) {                        
           Destroy( customer );
           lol.customeramnt--;
           lol.customersleft--;
           customerkilled = true;
          pizza.justserved = false;  
          Invoke ("overloadpreventer", 1.6f);
        }
   }   

   void overloadpreventer(){
    pizza.canbeserved = true;
   }
}
