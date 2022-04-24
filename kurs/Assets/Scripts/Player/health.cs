using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class health : MonoBehaviour
{
    public Image UIHP;
    public float hp = 1f;
    public GameObject Ragdoll;
    public GameObject tip;
    public Text HpMalinatext;
    public float HpMalina = 0f;
    private int n;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) & HpMalina > 0f & hp < 1f)
        {
            hp = hp + 0.15f;
            HpMalina = HpMalina - 1f;
        }
        if (hp > 1f)
        {
            hp = 1f;
        }


        if (hp < 0)
        {  Instantiate(Ragdoll, transform.position, transform.rotation);
            gameObject.SetActive(false);
          
        }
        HpMalinatext.text = "" + HpMalina;
UIHP.fillAmount = hp;

    }
    void OnTriggerStay(Collider other) // для лавы, шипов 
    {
       
        if (other.tag == "dead")
        {
            hp -= Time.deltaTime / 10f;
        }  
        if (other.tag == "malina" & Input.GetKeyDown(KeyCode.F))
        {
            n += 1;
            HpMalina = HpMalina + 1f;
      other.tag = "nomalina";
            tip.SetActive(false);
        }
        if (other.tag == "malina" & n == 0) {
tip.SetActive(true);
        }
      
    }
    //    void OnTriggerExit(Collider other) { 

    //    tip.SetActive(false);
    //}
    
    }
