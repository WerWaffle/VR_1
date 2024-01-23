using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AScrinpt : MonoBehaviour
{
    public GameObject Cylinder;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.S)) {
            Debug.Log("Object is activated");
            Cylinder.SetActive(true);
        }

        if (Input.GetKey(KeyCode.H)) {
            Debug.Log("Object is deactivated");
            Cylinder.SetActive(false);
        }
    }
}
