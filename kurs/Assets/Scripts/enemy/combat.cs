using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class killed
{
    public static int w=0;
    
}
    public class combat : MonoBehaviour
{
    public float hp = 1f;
    public Image UIHP;
   
    void Update()
    {      
        UIHP.fillAmount = hp;
        if (hp < 0)
        {
           
            Destroy(gameObject);
        }
        if ((hp < 0)&(gameObject.tag == "camp"))
        {
            killed.w++;
          
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "plsword")
        {
          hp = hp - 0.1f;
        }
    }
}
