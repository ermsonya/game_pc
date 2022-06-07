using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockway : MonoBehaviour
{
    public GameObject tip;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            tip.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            tip.SetActive(false);
        }
    }
}
