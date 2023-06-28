using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    public Animator anim;

    public KeyCode spacebar = KeyCode.Space;

    // Use this for initialization
    void Start()
    {
        if (Input.GetKeyDown(spacebar))

            anim.Play("yrdy234"); //Name of animation

        if (Input.GetKeyUp(spacebar))

            anim.SetTrigger("idle");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
