using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class givesword : MonoBehaviour
{
    private int g;
    public Image swordimg;
    public Sprite spr;
    public GameObject sword;
    void Update()
    {
        if (g > 0)
        {
            sword.SetActive(true);
           swordimg.sprite = spr;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" & Input.GetKeyDown(KeyCode.F) )
        {
            g++;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (g > 0)
        {
            sword.SetActive(true);
            swordimg.sprite = spr;
        }
    }
}
