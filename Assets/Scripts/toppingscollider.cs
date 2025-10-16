using UnityEngine;

public class toppingscollider : MonoBehaviour
{
    public bool ontarget;
    public float speed = 44f;
    public Vector3 Axis;
     public GameObject origin;
     public GameObject target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        origin = GameObject.Find("origin");
        transform.RotateAround (origin.transform.position,Axis, speed*Time.deltaTime);
       
    }

    // Update is called once per frame
    void Update()
    {
         transform.RotateAround (origin.transform.position,Axis, speed*Time.deltaTime);

    }

       void OnTriggerEnter(Collider col) {
           if(col.gameObject.name == "target"){
          ontarget = true;
         Debug.Log("Entered");
        
        }
     }
        
        void OnTriggerExit(Collider col) {
             
        ontarget = false;
         Debug.Log("LEFT");
        
        
           
}

    public void stopTopping(){
        speed = 0f;
        Debug.Log("stopped");
        Destroy(target);
    }

}
