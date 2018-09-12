using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    public Animator animator;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        animator.SetFloat("Speed", v);
        animator.SetFloat("Direction", h);

        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("Wave");
        }

    }
}
