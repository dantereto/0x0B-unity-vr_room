using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour

{
    public Animator anim;
    public GameObject Canvas;
    public GameObject Light;
    public void contol()
    {
        anim.SetBool("character_nearby", true);
        Canvas.SetActive(false);
    }
    public void LighsOn()
    {
        Light.SetActive(true);
    }
}