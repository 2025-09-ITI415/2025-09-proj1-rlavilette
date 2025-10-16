using UnityEngine;

public class Topppingdrag : MonoBehaviour
{
    public Vector3 mouse;

 
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
          
    }

    private Vector3 Getmouse(){
        return Camera.main.WorldToScreenPoint(transform.position);
    }
    private void OnMouseDown(){
        mouse = Input.mousePosition - Getmouse();
    }
  private void OnMouseDrag()
    {
       
        Debug.Log( " was clicked!");
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition-mouse);
            
         }
    }
 

