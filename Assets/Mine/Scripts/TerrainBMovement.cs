using UnityEngine;
using System.Collections;

public class TerrainBMovement : MonoBehaviour {

	// Use this for initialization
    public GameObject p_player;
    private bool m_moveTerrainA = true;
    private float m_speed = 70;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        float terrainLength = 500f;

        m_speed = p_player.GetComponent<Player>().p_movement.y;

        //Move this terrain towards the player.
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - m_speed * Time.deltaTime);

        //this move the other terrain to the back of this one
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
