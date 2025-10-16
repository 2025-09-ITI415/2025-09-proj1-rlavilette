using UnityEngine;

public class closeafterpizzadone : MonoBehaviour
{

    public pizzamaker thispizza;
    void Start()
    {  GameObject pizza = GameObject.Find( "PizzaMaker" );
        thispizza = pizza.GetComponent<pizzamaker>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(thispizza.pizzacompleted==true){
            Destroy(gameObject);
        }
        
    }
}
