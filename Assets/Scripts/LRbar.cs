using UnityEngine;
using UnityEngine.UI;

public class LRbar : MonoBehaviour
{
    public pizzamaker pizza;   
    

    public float speed = 1f; 
    public GameObject lrBar; 
    public GameObject thisminigame;
    public GameObject[] toppings;
    public float leftedge = 10f; 
    public float rightedge = 10f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         GameObject newpizza = GameObject.Find( "PizzaMaker" );
         pizza = newpizza.GetComponent<pizzamaker>();

    }

    // Update is called once per frame
    void Update()
    {

          Vector3 lrpos = lrBar.transform.position;  
          lrpos.x += speed * Time.deltaTime; 
          lrBar.transform.position = lrpos;  

          if (lrpos.x < -leftedge){
          speed = Mathf.Abs(speed);
          } else if (lrpos.x > rightedge){
             speed = -Mathf.Abs(speed);

          
       }
        
    }

    public void stopMoving()
    {
        speed = 0f;
          Vector3 stoppedpos = lrBar.transform.position;  
        if (stoppedpos.x >= -0.35 && stoppedpos.x <= 0.05){
            pizza.cheeseScore += 100; 
            Instantiate<GameObject>(toppings[0]);
        } else if (stoppedpos.x >= -1.76 && stoppedpos.x < -0.35 ||stoppedpos.x > 0.05 && stoppedpos.x <= 1.39){
             pizza.cheeseScore += 50; 
           Instantiate<GameObject>(toppings[1]);
        } else {
             pizza.cheeseScore += 25; 
            Instantiate<GameObject>(toppings[2]);
        }
        Destroy(thisminigame);
        pizza.cheesed = true;
    }


}
