using UnityEngine;
using UnityEngine.UI;

public class CookMinigame : MonoBehaviour
{
    public pizzamaker mypizza;
    public GameObject minigame;
    public Image cookbar;
    public Button cookbutton;
    public Text cookTimeText;
    public bool clickedyet = false;
    public float speed = 0f;
    public float cookamnt = 0f;
    public float cookTime  = 10;
    public float cookscore = 0f; 
    public float currentcook = 0f;
    public int displaytime = 0;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         GameObject pizza = GameObject.Find( "PizzaMaker" );
        mypizza = pizza.GetComponent<pizzamaker>(); 
    }

    // Update is called once per frame
    void Update()
    {

        if (cookTime <= 0){
            endGame();
            
         
         
        } 

      else {
        cookbar.fillAmount -= speed * Time.deltaTime;
        cookTime -= 1 * Time.deltaTime;
        AvoidNegTime();
        displaytime = (int)cookTime;
        cookTimeText.text = "Cook Time Left:" + displaytime.ToString( "#,0" ) + " seconds";

         if (cookbar.fillAmount<= 0.706 && cookbar.fillAmount > 0.618){
            cookscore += 10* Time.deltaTime;
            AvoidNegScore();
            mypizza.cookscore = (int)cookscore;
        } else {
             cookscore -= 1* Time.deltaTime;
             AvoidNegScore();
            mypizza.cookscore = (int)cookscore;
        }
       
       currentcook = cookbar.fillAmount;

      }

    }

    public void cookPizza(){
        cookbar.fillAmount += cookamnt* Time.deltaTime;
    }

   void AvoidNegScore(){
    	if (cookscore <= 0){
		cookscore = 0;
	}
   }

    void AvoidNegTime(){
        if (cookTime <= 0){
            cookTime = 0;
        }
    }
   

   void endGame(){
     cookbar.fillAmount = currentcook;
        if (clickedyet == false){
        clickedyet = true;
        }
     Invoke("killUI", 1f);
        mypizza.cooked = true;

     
   }

   void killUI (){
    Destroy(minigame);
   
   }


 



    
}

       
