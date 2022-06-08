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
    public Transform spawn;
    public Transform playerPref;
    public Animator die;
    //public GameObject Ragdoll;
    public GameObject tip;
    public Text HpMalinatext;
    public Image UIHP;
    private float Xposition= 9f;
    private float Yposition= 0.5f;
    private float Zposition= 11.5f;
    /* public float HpMalina = 0f*/
    private int n;
  
    void Start()
    {
     
    }
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


        if (Global.hp < 0){
            //  Instantiate(Ragdoll, transform.position, transform.rotation);
            //    gameObject.SetActive(false);
            //die.SetBool("dead",true);
            //Instantiate(playerPref, spawnpoint.position, spawnpoint.rotation, 0);
            //die.SetBool("dead", false);
            die.SetBool("dead", true);
            StartCoroutine(Wait(2f));
          
          
        
            /*   Instantiate(playerPref, spawn.position, spawn.rotation)*/  
            //die.SetBool("dead", false);

            //Global.hp = 0.5f;
      
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
        if (other.tag == "malina"/* & n == 0*/) {
tip.SetActive(true);
        }
      
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Spawnpoint")
        {
          Debug.Log("hit");
            die.SetBool("dead", false); 
        }
        if (other.tag == "sword")
        {
            ////Debug.Log("hit");
            Global.hp = Global.hp - 0.1f; 
        }
    }
    //    void OnTriggerExit(Collider other) { 

    //    tip.SetActive(false);
    //}
    private IEnumerator Wait(float value)
    {
        //die.SetBool("dead", true);
        yield return new WaitForSeconds(value); 
        transform.position = new Vector3(Xposition, Yposition, Zposition);
        Global.hp = 1f;
        
    }
}
