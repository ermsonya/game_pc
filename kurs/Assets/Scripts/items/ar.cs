using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ar : MonoBehaviour
{
    public Image[] inImages;
    public Sprite[] spr;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = (GameObject)this.gameObject;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            inImages[0].sprite = spr[0];
        } Destroy(player);
    }
    private void OnTriggerExit(Collider other)
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
