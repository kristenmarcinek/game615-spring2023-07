using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    float health = 90;
    public Animator healthBarAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            health -= 30;
        }

        if(health == 60) {
            healthBarAnim.SetBool("90", false);
            healthBarAnim.SetBool("60", true);
            healthBarAnim.SetBool("30", false);
            healthBarAnim.SetBool("0", false);
        } else if(health == 30) {
            healthBarAnim.SetBool("90", false);
            healthBarAnim.SetBool("60", false);
            healthBarAnim.SetBool("30", true);
            healthBarAnim.SetBool("0", false);
        } else if (health == 0) {
            healthBarAnim.SetBool("90", false);
            healthBarAnim.SetBool("60", false);
            healthBarAnim.SetBool("30", false);
            healthBarAnim.SetBool("0", true);
        } else {
            healthBarAnim.SetBool("90", true);
            healthBarAnim.SetBool("60", false);
            healthBarAnim.SetBool("30", false);
            healthBarAnim.SetBool("0", false);
        }

        
    }
}
