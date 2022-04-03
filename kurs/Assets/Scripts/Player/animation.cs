    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    public Animator go;
    private int _state;
    // Start is called before the first frame update
    void Start()
    {
        go = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
                _state = 2;
            else
                _state = 1;
        }
        else _state = 0;
        go.SetInteger("state", _state);

    }
}
