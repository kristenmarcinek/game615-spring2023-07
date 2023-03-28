using System.Threading;
//using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController cc;

    public Animator animator;
    //public Animator menuAnimator;

    public float playerSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        
        if (move != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(move, Vector3.up);
            targetRotation = Quaternion.RotateTowards(transform.rotation, targetRotation, 360 * Time.deltaTime);
            transform.rotation = targetRotation;         
        }

        cc.Move(move * Time.deltaTime * playerSpeed);

        if (Input.GetAxis("Vertical") > 0)
        {
            animator.SetBool("walking", true);
            animator.SetBool("idle", false);
            //menuAnimator.SetBool("walking", true);
        } else if (Input.GetAxis("Vertical") == 0)
        {
            animator.SetBool("walking", false);
            animator.SetBool("idle", true);
            //menuAnimator.SetBool("walking", false);
        } else
        {
            animator.SetBool("walking", false);
            animator.SetBool("idle", true);
        }

        
    }
    
}