using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class move
{
    public static bool t=true;
}

    public class startingdialogue : MonoBehaviour
{
    public Dialogue dialogue;
    //public double talkDistance = 0.5;
    //public GameObject player1;
    private int n;
    public GameObject tip;
    void Update()
    {
       
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" & Input.GetKeyDown(KeyCode.F) &n==0)
        {
            move.t = false;
            tip.SetActive(false);
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            transform.gameObject.tag = "wastalk";
            n += 1;
        }
        }
        void OnTriggerExit(Collider other)
        {
        move.t = true;

    }

        //void OnTriggerEnter(Collider collision)
        //{
        //    if (collision.gameObject.tag == "Player")
        //    {

        //    }
        //}
        //void OnTriggerExit(Collider collision)
        //{
        //    animator.SetBool("IsOpen", false);
        //}
    }
