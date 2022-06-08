using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static forKey;

public class blockway : MonoBehaviour
{
    public GameObject tipfind;
    public GameObject tippress;
    public Animator gates;
    public GameObject showkey;
    private int n=0;
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" & forKey.kk==0)
        {
            tipfind.SetActive(true);
        }
        if (other.tag == "Player" & forKey.kk == 1 & n==0)
        {
            tippress.SetActive(true);
            
        }
        if (other.tag == "Player" & Input.GetKeyDown(KeyCode.F) & forKey.kk == 1)
        {
            n++;
            Destroy(showkey);
                gates.SetTrigger("open");
                
            }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            tipfind.SetActive(false);
            tippress.SetActive(false);
        }
    }
}
