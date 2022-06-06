using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Global
{
    public static float HpMalina = 0f;
 public static float hp = 1f;
    
    //public static Text HpMalinatext;
}

public class health : MonoBehaviour
{
    public GameObject Ragdoll;
    public GameObject tip;
    public Text HpMalinatext;
    public Image UIHP;
    /* public float HpMalina = 0f*/
    private int n;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) & Global.HpMalina > 0f & Global.hp < 1f)
        {
            Global.hp = Global.hp + 0.15f;
            Global.HpMalina = Global.HpMalina - 1f;
        }
        if (Global.hp > 1f)
        {
            Global.hp = 1f;
        }


        if (Global.hp < 0)
        {  Instantiate(Ragdoll, transform.position, transform.rotation);
            gameObject.SetActive(false);
          
        }
        HpMalinatext.text = "" + Global.HpMalina;
       UIHP.fillAmount = Global.hp;

    }
    void OnTriggerStay(Collider other) // для лавы, шипов 
    {
       
        if (other.tag == "dead")
        {
            Global.hp -= Time.deltaTime / 10f;
        }  
        if (other.tag == "malina" & Input.GetKeyDown(KeyCode.F))
        {
            n += 1;
            Global.HpMalina = Global.HpMalina + 1f;
      other.tag = "nomalina";
            tip.SetActive(false);
        }
        if (other.tag == "malina" & n == 0) {
tip.SetActive(true);
        }
      
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Sword")
        {
            Global.hp = Global.hp - 0.1f; 
        }
    }
        //    void OnTriggerExit(Collider other) { 

        //    tip.SetActive(false);
        //}

    }
