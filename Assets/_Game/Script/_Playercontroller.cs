using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Playercontroller : MonoBehaviour
{

    public Vector3 startTouch;
    public Vector3 endTouch;
    public Vector3 VectorTouch;
    public Rigidbody Rb ;
    public float  movespeed ;
       
   
    void Start()
    {
        

    }

    
    void Update()
    {
        
        movePlayer();
        
        
    }
    public void movePlayer()
    { 
        if(Input.GetMouseButtonDown(0))
        {
             startTouch = new Vector3(Input.mousePosition.x, Input.mousePosition.y);

        }    
        if(Input.GetMouseButtonUp(0))
        {

             endTouch = new Vector3(Input.mousePosition.x, Input.mousePosition.y);

            VectorTouch = new Vector3(endTouch.x - startTouch.x, endTouch.y-startTouch.y);
             
            VectorTouch.Normalize();

            if (VectorTouch.y > 0f && VectorTouch.x < 0.5f && VectorTouch.x > -0.5f)
            {
                Rb.velocity = Vector3.forward.normalized * movespeed * Time.deltaTime;// di chuyển lên 
                
                

            }
          
            else if (VectorTouch.y < 0f && VectorTouch.x < 0.5f && VectorTouch.x > -0.5f)
          
            {
                Rb.velocity = Vector3.down.normalized * movespeed * Time.deltaTime;// di chuyển xuống
            }
          
            else if (VectorTouch.x > 0f && VectorTouch.y < 0.5f && VectorTouch.y > -0.5f)
           
            {
                Rb.velocity = Vector3.right.normalized * movespeed * Time.deltaTime;// di chuyển sang phải
            }
           
            else if (VectorTouch.x < 0f && VectorTouch.y < 0.5f && VectorTouch.y > -0.5f)
           
            {
                Rb.velocity = Vector3.left.normalized * movespeed * Time.deltaTime;// di chuyển sang trái
            }

        }    
        




    }


}
