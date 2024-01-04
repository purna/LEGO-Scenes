using UnityEngine;
using System.Collections;
using Unity.LEGO.Minifig;
using System;
using Unity.LEGO.UI;


//This is the derived class whis is
//also know as the Child class.
public class LegoExtensions : MinifigController
{
    /*
    Animator animator;
    AudioSource audioSource;

    int playSpecialHash = Animator.StringToHash("Play Special");
    int cancelSpecialHash = Animator.StringToHash("Cancel Special");
    int specialIdHash = Animator.StringToHash("Special Id");
    Action<bool> onSpecialComplete;
    */

   
    Animator animator;
   

    int playSpecialHash = Animator.StringToHash("Play Special");
    int specialIdHash = Animator.StringToHash("Special Id");




    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public new enum SpecialAnimation
    {
        LookLeft = 50,
        LookRight = 51
    }


    public void PlaySpecialAnimation(SpecialAnimation animation)
    {

        animator.SetBool(playSpecialHash, true);
        animator.SetInteger(specialIdHash, (int)animation);
    }
   

    // You can add new methods and properties to this subclass.
    public void SayHello()
    {
        Debug.Log("Hello, I am a lego figure.");
    }

}
