using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectpositon : MonoBehaviour
{
    public Vector3 newposition;
    public GameObject micubo;
    // Start is called before the first frame update
    void Start()
    {
        micubo.transform.position = newposition;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
