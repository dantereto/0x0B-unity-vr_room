using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour

{
    public Animator anim;
    public void contol()
    {
        anim.SetBool("character_nearby", true);
    }
}