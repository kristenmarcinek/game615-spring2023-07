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
        cc.Move(move * Time.deltaTime * playerSpeed);
        transform.Rotate(0, 80 * Input.GetAxis("Horizontal") * Time.deltaTime, 0);

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