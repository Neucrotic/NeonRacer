using UnityEngine;
using System.Collections;

public class TerrainAMovement : MonoBehaviour {

    private bool m_moveTerrainB = true;
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        float speed = 70;
        int terrainLength = 500;

        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - speed * Time.deltaTime);

        if (this.transform.position.z <= -250 && m_moveTerrainB)
        {
            GameObject b = GameObject.FindGameObjectWithTag("TerrainB");
            b.transform.position = new Vector3(b.transform.position.x, b.transform.position.y, this.transform.position.z + terrainLength);
            b.GetComponent<TerrainBMovement>().SetCanMoveTerrainA(true);
            m_moveTerrainB = false;
        }
	}

    public void SetCanMoveTerrainB(bool _bool) { m_moveTerrainB = _bool; }
}
