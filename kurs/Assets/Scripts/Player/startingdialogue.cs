using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class startingdialogue : MonoBehaviour
{
    public Dialogue dialogue;



    void Update()
    {

    }


    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("did0");
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("did1");
            //if (Input.GetKey(KeyCode.F))
            //{
            //    Debug.Log("did");
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);

            //}
        }
    }
        void OnTriggerExit(Collider collision)
        {
        //animator.SetBool("IsOpen", false);
    }
}