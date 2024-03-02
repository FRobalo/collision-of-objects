using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    //The default jump strength in trampolines
    public int trampolineJumpStrength = 10;

    //Happens when the player enters the collider 
    private void OnTriggerEnter(Collider other)
    {
        //Changes the jumpStrength component to default trampoline value
        other.GetComponent<Jump>().jumpStrength = trampolineJumpStrength;
    }

    //Happens when the player exits the collider 
    private void OnTriggerExit(Collider other)
    {
        //Changes the jumpStrength component to the original value
        other.GetComponent<Jump>().jumpStrength = 2;
    }
}
