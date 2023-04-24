using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionPulpo : MonoBehaviour
{
    private Animator anim;


    private void Awake()
    {
        anim = GetComponentInChildren<Animator>(); 
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("pulpoanimacion");
        }
    }
}
