using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject cylinder;

    public void ButtonActivated()
    {
        if (cylinder.active == false)
        {
            Debug.Log("Object is deactivated");
        }

        if (cylinder.active == true)
        {
            Debug.Log("Object is activated");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }
}
