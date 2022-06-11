using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static killed;
public class endgame : MonoBehaviour
{
    public GameObject show;
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" & killed.w == 7)
        {
            show.SetActive(true);
        }
    }
   }
