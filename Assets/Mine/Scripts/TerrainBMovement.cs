using UnityEngine;
using System.Collections;

public class TerrainBMovement : MonoBehaviour {

	// Use this for initialization
    private bool m_moveTerrainA = true;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        float speed = 70;
        float terrainLength = 500f;

        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - speed * Time.deltaTime);

        if (this.transform.position.z <= -250 && m_moveTerrainA)
        {
            GameObject a = GameObject.FindGameObjectWithTag("TerrainA");
            a.transform.position = new Vector3(a.transform.position.x, a.transform.position.y, this.transform.position.z + terrainLength);
            a.GetComponent<TerrainAMovement>().SetCanMoveTerrainB(true);
            m_moveTerrainA = false;
        }	
	}

    public void SetCanMoveTerrainA(bool _bool) { m_moveTerrainA = _bool;  }
}
