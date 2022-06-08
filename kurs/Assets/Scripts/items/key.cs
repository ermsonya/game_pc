using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class forKey
{
    public static int kk = 0;
}
public class key : MonoBehaviour
{
    public Sprite spr;
    public GameObject tip;
    public Image keyim;
    public GameObject gate_tip;
    public GameObject kkkey;
    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerStay(Collider other) 
    {
        if (other.tag == "Player")
        {
tip.SetActive(true);
        }
          if (other.tag == "Player" & Input.GetKeyDown(KeyCode.F))
        {
            keyim.sprite = spr;
            //Destroy(gate_tip);
           forKey.kk++;
            Destroy(kkkey);
            
            tip.SetActive(false);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            tip.SetActive(false);
           
        }
    }

}
