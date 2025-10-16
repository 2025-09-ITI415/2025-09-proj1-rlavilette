using UnityEngine;

public class orderingcustomer : MonoBehaviour
{
    public int randomnumber;
    public float speed = 1f;
    public bool pepperonipizza;
    public bool cheesepizza;
    public bool veggiepizza;
    public bool isfirstcustomer;
    public bool isthirdcustomer = false;
    public bool issecondcustomer = false;
    public bool served; 
    public GameObject pepperoniorder;
    public GameObject cheeseorder;
    public GameObject completedorder;
    public pizzamaker thispizza; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        randomnumber = Random.Range(1,3);

        if (randomnumber == 1){
            pepperoniorder.SetActive(true);
        } if (randomnumber == 2) {
            cheeseorder.SetActive(true);
        }
   
     GameObject pizza = GameObject.Find( "PizzaMaker" );
        thispizza = pizza.GetComponent<pizzamaker>(); 

        
    }



    // Update is called once per frame
    void Update()
    {
       
    }

  void OnMouseDown(){
        if (randomnumber == 1 && thispizza.pepperonicnt >= 1 && thispizza.canbeserved == true){
            pepperoniorder.SetActive(false);
            completedorder.SetActive(true);
            served = true;
            gameObject.tag = "servedcustomer";
            thispizza.pepperonicnt --;
            thispizza.canbeserved = false;
            

            if (isfirstcustomer == true){
                thispizza.firstspotfilled = false;
                 thispizza.secondspotfilled = false;
                
            } else if (issecondcustomer == true){
                thispizza.secondspotfilled = false;
            
            }

        } else  if (randomnumber == 2 && thispizza.cheesecnt >= 1 && thispizza.canbeserved == true){
            cheeseorder.SetActive(false);
            completedorder.SetActive(true);
              gameObject.tag = "servedcustomer";
            served = true;
            thispizza.cheesecnt --;
            thispizza.justserved = true; 
            thispizza.canbeserved = false;

            
            if (isfirstcustomer == true){
                thispizza.firstspotfilled = false;
              
                 
            } else if (issecondcustomer == true){
                thispizza.secondspotfilled = false;
            }

        }
    }
}
  


