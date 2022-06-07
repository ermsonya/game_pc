using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class moving : MonoBehaviour 
{
    public GameObject player;
    public float dist;
    public float Radius;
    private UnityEngine.AI.NavMeshAgent nav;
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist > Radius)
        {
            nav.enabled = false;
            gameObject.GetComponent<Animator>().SetTrigger("idle");

        }
        if (dist < Radius)
        {
            nav.enabled = true;
            nav.SetDestination(player.transform.position);
            
        }
        if ((dist < Radius) & (dist > 1))
        {
gameObject.GetComponent<Animator>().SetTrigger("run");
        }
            //else if ((dist < Radius) & (dist <0.5))gameObject.GetComponent<Animator>().SetTrigger("active");
            if (dist < 1)
        {
            
            gameObject.GetComponent<Animator>().SetTrigger("attack");
        }
    }
}
