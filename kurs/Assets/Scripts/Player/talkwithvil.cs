using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talkwithvil : MonoBehaviour
{
    public GameObject tip;
   private int n;
    public CharacterController pers;
    public Animator move;
    // Start is called before the first frame update
    void Awake()
    {
        move = GetComponent<Animator>();
        pers = GetComponent<CharacterController>();
        pers.enabled = true;
        move.enabled = true;
    }
    void OnTriggerStay(Collider other) // для лавы, шипов 
    { 
        if (other.tag == "vil" & Input.GetKeyDown(KeyCode.F))
        {
            n += 1;
            tip.SetActive(false);
            //pers.enabled = false;
            //move.enabled = false;

        }
        //if (Input.GetKeyDown(KeyCode.F))
        //{
        //    pers.enabled = false;
        //    move.enabled = false;
        //}
        
        if (other.tag == "vil" & n == 0){
            tip.SetActive(true);
           
        }
           
    }
        void OnTriggerExit(Collider other) 
        {
        tip.SetActive(false);
        pers.enabled = true;
        move.enabled = true;
    }

            // Update is called once per frame
            void Update()
    {
        
    }
}
