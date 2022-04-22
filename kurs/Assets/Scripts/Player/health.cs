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
    public Text HpMalinatext;
    public float HpMalina = 0f;
    void Update()
    {
        UIHP.fillAmount = hp;
        if (hp < 0)
        {  Instantiate(Ragdoll, transform.position, transform.rotation);
            gameObject.SetActive(false);
          
        }
        HpMalinatext.text = "" + HpMalina;


    }
    void OnTriggerStay(Collider other) // для лавы, шипов 
    {
        if (other.tag == "dead")
        {
            hp -= Time.deltaTime / 10f;
        }
        if (other.tag == "malina" & Input.GetKeyDown(KeyCode.F)) {

            HpMalina=HpMalina + 1f; 
 }
    }
    }
