using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    public GameObject Model;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" & Input.GetKeyDown(KeyCode.F))
        {
            Destroy(Model);
        }
    }
}