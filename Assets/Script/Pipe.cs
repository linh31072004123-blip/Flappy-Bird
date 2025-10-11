using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform pipe;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pipe.position.x > -7)
        {
            pipe.position -= new Vector3(0.009f, 0, 0);
        }
        else
        {
            SimplePool2.Despawn(this.gameObject);
        }
        
    }
}
