using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static killed;
public class blockexit : MonoBehaviour
{
    public GameObject tipexit;
    public Animator gates;
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" & killed.w < 7)
        {
            tipexit.SetActive(true);
        }
        if (other.tag == "Player" & killed.w == 7)
        {
            gates.SetTrigger("open");
        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            tipexit.SetActive(false);
        
        }
    }
}
