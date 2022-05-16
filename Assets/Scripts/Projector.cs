using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projector : MonoBehaviour
{
    public GameObject projector;
    public GameObject Light;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "vr")
        {
            Light.SetActive(true);
        }
    }
}
