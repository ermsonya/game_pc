using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class startingdialogue : MonoBehaviour
{
    public Dialogue dialogue;
    //public double talkDistance = 0.5;
    //public GameObject player1;

    void Update()
    {
        // if (Input.GetKey(KeyCode.F)) {
        //    RaycastHit hit;
        //    if (Physics.Raycast(transform.position, -Vector3.up, out hit) )
        //        print("Found an object - distance: " + hit.distance);
        //    if (hit.distance <= talkDistance)
        //    //if (Vector3.Distance(player1.transform.position, transform.position) )
        //    FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        //}
    }


    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
    }
    //void OnTriggerExit(Collider collision)
    //{
    //    animator.SetBool("IsOpen", false);
    //}
}
