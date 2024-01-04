using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.LEGO.Minifig;
using Unity.LEGO.UI;


public class test : MonoBehaviour
{

    public void UseExtendedController()
    {
        LegoExtensions extendedController = new LegoExtensions();

        //MinifigController.SpecialAnimation animation = (MinifigController.SpecialAnimation)LegoExtensions.SpecialAnimation.LookLeft;

        // You can use the new methods from the extended class.
        //extendedController.PlaySpecialAnimation(animation);

        // You can also use the methods and properties from the base class (MinifigController).
        extendedController.SayHello();
    }



    // Start is called before the first frame update
    void Start()
    {
        UseExtendedController();
    }




}
