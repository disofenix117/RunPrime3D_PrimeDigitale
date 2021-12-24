using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody rigid;
    Animator anim;
    [Range(-1f,1f)] [SerializeField] int position;

    Vector3 destiny;
    bool toRight;
    bool toLeft;
    bool inFloor;
    float jumpForce=12;
    
    [Header("SETUP")]
    [SerializeField] float moveSpeed=6;

    void Awake()
    {
        rigid=GetComponent<Rigidbody>();
        anim=GetComponent<Animator>();

    }

    void Update()
    {
         if(Input.GetButtonDown("Right")||Input.GetKeyDown(KeyCode.D) &&(position<1))
         {
             toRight=true;
             toLeft=false;
             CancelInvoke();
             Invoke("toFalse",0.2f);

         }
         if(Input.GetButtonDown("Left")||Input.GetKeyDown(KeyCode.A) &&(position>-1))
         {
             toRight=false;
             toLeft=true;
             CancelInvoke();
             Invoke("toFalse",0.2f);

         }


        if (transform.position==destiny)
        {
            if((toRight) &&(position<1))
            {
                destiny.x=transform.position.x+2.5f;
                position++;

            }

            if((toLeft) &&(position>-1))
            {
                destiny.x=transform.position.x-2.5f;
                position--;

            }
        }
        Vector3 xDestiny= destiny;
        //pasa a la posicion que quiero que este 
        transform.position=Vector3.MoveTowards(transform.position,xDestiny,moveSpeed*Time.deltaTime);

        //salto
        if((Input.GetButtonDown("Up")||Input.GetKeyDown(KeyCode.W))&&inFloor)
        {
            rigid.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
            
        }
        //baja
        if ((Input.GetButtonDown("Down")||Input.GetKeyDown(KeyCode.S)))
        {
            if(!inFloor)
            {
                rigid.AddForce(Vector3.up*-jumpForce,ForceMode.Impulse);
            }

        }
        //animaciones
        anim.SetBool("up",(Input.GetButtonDown("Up")||Input.GetKeyDown(KeyCode.W))&&(inFloor));
        anim.SetBool("side",(toLeft||toRight)&&inFloor);
    }

    void OnCollisionStay()
    {
        inFloor=true;

        
    }
    void OnCollisionExit()
    {   
        inFloor=false;

    }

    void toFalse()
    {
        toRight=false;
        toLeft=false;
    }

  
    
}
