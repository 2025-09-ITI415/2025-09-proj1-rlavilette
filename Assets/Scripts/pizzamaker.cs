using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 

public class pizzamaker : MonoBehaviour
{

    public GameObject sauceBar; 
    public GameObject newpizza;
    public GameObject ClassicPep;
    public GameObject ClassicCheese;
    public GameObject finalscreen;
    public GameObject gamescreen;
    public GameObject[] winscreens;
    public Customers customercounter;
    public Text highScoretext; 
    public Text saucescoretext;
    public Text toppingscoretext;
      public Text cheesescoretext;
      public Text cookscoretext;
     public Text ordersortext;
     public Text pepscount;
     public Text cheesecount;
     public Text customercount;
     public Text finScore;
     public int cookscoreoverall = 0;
    public int sauceScore = 0; 
    public int cheeseScore = 0;
    public int toppingsscore = 0; 
    public int pepperonicnt = 0;
    public int cheesecnt = 0;
    public int cookscore = 100;
    public float finalscore = 0;
    public int highscore = 0; 
    public bool sauced = false; 
    public bool cheesed = false; 
    public bool topped = false; 
    public bool cooked = false; 
    public bool pizzacompleted = false;
    public bool justserved = false; 
    public bool firstspotfilled = false;
     public bool secondspotfilled = false;
    public bool canbeserved  = false;
    
  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    highscore = PlayerPrefs.GetInt("HighScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        saucescoretext.text = "Sauce:" + sauceScore.ToString( "#,0" );
       cheesescoretext.text = "Cheese:" + cheeseScore.ToString( "#,0" );
       toppingscoretext.text = "Toppings:" + toppingsscore.ToString( "#,0" );
       customercount.text = customercounter.customersleft.ToString("#,0");

       if (cooked == false){
          cookscoretext.text = "Cook:" + cookscore.ToString( "#,0" );
       } else {
        cookscoretext.text = "Cook:" + cookscoreoverall.ToString( "#,0" );
       }

       if (cooked){
        cookscoreoverall += cookscore;
        cookscore = 0;
       }

   

       if (customercounter.customersleft == 0){
        endgame();
       }
    }

    public void newPepperoniPizza(){
        Instantiate<GameObject>(ClassicPep);
        newpizza.SetActive(false);
        ordersortext.text = "Tasks";
        pizzacompleted = false;
        sauced = false; 
        cheesed = false;
        topped = false; 
        cooked = false; 
    }

    
    public void newCheesePizza(){
        Instantiate<GameObject>(ClassicCheese);
        newpizza.SetActive(false);
        ordersortext.text = "Tasks";
        pizzacompleted = false;
        sauced = false; 
        cheesed = false;
        topped = false; 
        cooked = false; 
        toppingsscore+= 100;
    }


   public void endgame(){
    finalscore = toppingsscore + sauceScore + cheeseScore + cookscoreoverall;
    finalscore = finalscore/6;
    finalscore = finalscore/4;
    finalscore = (int)finalscore;


     if ((int)finalscore > highscore)
        {
            highscore = (int)finalscore;
            PlayerPrefs.SetInt("HighScore", highscore);
            PlayerPrefs.Save();
        }


    finalscreen.SetActive(true);
    gamescreen.SetActive(false);

    finScore.text = "Todays Score: " + finalscore.ToString( "#,0" );
    highScoretext.text = "Highscore: " + highscore.ToString("#,0");
    

    

    if (finalscore >= 0 && finalscore < 40){
        winscreens[0].SetActive(true);
    } else if (finalscore>40 && finalscore < 70){
        winscreens[1].SetActive(true);
    } else {
        winscreens[2].SetActive(true);
   }

}

public void resetscore(){
  
   PlayerPrefs.SetInt( "HighScore", 0 );
   
}

public void replaygame(){
 SceneManager.LoadScene( "Game" );
}
}
