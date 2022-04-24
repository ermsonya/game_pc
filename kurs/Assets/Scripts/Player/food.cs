using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class food : MonoBehaviour
{ 
   
    public GameObject Model;
    public Material change;
    
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
            Model.GetComponent<Renderer>().material = change;

            //Destroy(Model);
            //StartCoroutine(_wait(4));
            //transform.gameObject.tag = "nomalina";
        }
    }
    //IEnumerator _wait(float time)
    //{
    //    yield return new WaitForSeconds(time);
    //}



}