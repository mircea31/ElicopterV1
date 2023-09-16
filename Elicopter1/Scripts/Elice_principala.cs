using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elice_principala : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {                              //x  y   z
        transform.Rotate(new Vector3(0,500,0)*Time.deltaTime);
    }
}
