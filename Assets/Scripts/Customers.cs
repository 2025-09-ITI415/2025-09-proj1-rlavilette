using UnityEngine;

public class Customers : MonoBehaviour
{
   public GameObject customer;
   public pizzamaker servedchecker;
   public int customersleft; 
   public int customeramnt = 0; 
   public bool atcapacity = false;


    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         
        InvokeRepeating("SpawnCustomer", 3f, 5); 

        
    }

    // Update is called once per frame
    void Update()
    {
          if (customeramnt < 3 && atcapacity == true && customersleft > 0){
            Invoke("SpawnCustomer", 3f);
            atcapacity = false;
          }
       
    }

       void SpawnCustomer()
    {
        if (customeramnt < 3){
        Instantiate(customer, new Vector3(97.56f, 0.2f, 3.47f), Quaternion.identity);
        customeramnt++;
        }

        if (customeramnt == 3){
            atcapacity = true;
          
        }

        if (servedchecker.justserved){
            customeramnt--;
           
        }
    }

 
    

   
}
