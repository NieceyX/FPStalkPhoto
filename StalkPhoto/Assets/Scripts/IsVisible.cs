using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsVisible : MonoBehaviour
{
    Renderer m_Renderer;
    public bool seen = false;
    public bool near = false;

    public float radius = 10f;
    
    void Start()
    {
        m_Renderer = GetComponent<Renderer>();
    }

    
    void Update()
    {
        if (m_Renderer.isVisible)
        {
            //Debug.Log("Object is visible");
            seen = true;
        }
        else
        {
            seen = false;
           // Debug.Log("Object is no longer visible");
        }
        Vector3 center = this.gameObject.transform.position;
        Collider[] hitColliders = Physics.OverlapSphere(center, radius);
        int i = 0;
        while (i < hitColliders.Length)
        {
            if (hitColliders[i].tag == "Player")
            {
                near = true;
                //Debug.Log("close");
            }
            else
            {
                near = false;
            }
            i++;
        }
    }
}
