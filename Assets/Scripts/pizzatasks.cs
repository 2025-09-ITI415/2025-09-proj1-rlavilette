using UnityEngine;
using UnityEngine.UI;

public class pizzatasks : MonoBehaviour
{
    public pizzamaker thispizza;
    public GameObject pizza;
    public bool sauced;
    public bool cheesed;
    public bool ischeese;
    public Button cheeseGo;
    public Button toppingsGO;
    public Button sauceGO;
    public Button cookGo;
    public Button finishGo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject pizza = GameObject.Find("PizzaMaker");
        thispizza = pizza.GetComponent<pizzamaker>(); 
      
        
    }

    // Update is called once per frame
    void Update()
    {
        bool sauced = thispizza.GetComponent<pizzamaker>();
        if (thispizza.sauced)
        {
            cheeseGo.interactable = true;
            sauceGO.interactable = false;
        }

        bool cheesed = thispizza.GetComponent<pizzamaker>();
        if (thispizza.cheesed){
            toppingsGO.interactable = true;
            cheeseGo.interactable = false;
        } 

        if (ischeese == true && thispizza.cheesed == true){
            thispizza.topped = true; 
        }
        bool topped = thispizza.GetComponent<pizzamaker>();
        if (thispizza.topped){
            toppingsGO.interactable = false;
            cookGo.interactable = true;
        }
            bool cooked = thispizza.GetComponent<pizzamaker>();
        if (thispizza.cooked){
            cookGo.interactable = false;
            finishGo.interactable = true;
        }

    }

    public void killcurrentpizza(){
        Destroy(pizza);
        thispizza.pizzacompleted = true;
        thispizza.newpizza.SetActive(true);
        thispizza.pepperonicnt++;
    }

     public void killcurrentcheesepizza(){
        Destroy(pizza);
        thispizza.pizzacompleted = true;
        thispizza.newpizza.SetActive(true);
        thispizza.cheesecnt++;
    }
}
