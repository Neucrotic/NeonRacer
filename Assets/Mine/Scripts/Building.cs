using UnityEngine;
using System.Collections;

public class Building : MonoBehaviour 
{
    public bool p_breakable;
    int m_colour; // 1 = red, 2 = orange, 3 = green
    Collider baseCol;
    Collider nearMiss;
    Collider[] cols;

	// Use this for initialization
	void Start () 
    {
        baseCol = this.GetComponent<BoxCollider>();
        nearMiss = this.GetComponent<BoxCollider>();
	}
	
	// Update is called once per frame
	void Update () 
    {
	    
	}
}
