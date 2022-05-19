using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectmovement : MonoBehaviour
{
    public GameObject micubo;
    public Vector3 movementvector;
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(micubo.transform.position.x) < 8) {

            micubo.transform.position += movementvector;
        }
        
    }
}
