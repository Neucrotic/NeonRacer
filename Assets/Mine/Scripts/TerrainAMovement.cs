using UnityEngine;
using System.Collections;

public class TerrainAMovement : MonoBehaviour {

    public GameObject p_player;
    private bool m_moveTerrainB = true;
    private float m_speed = 70;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        int terrainLength = 500;

        m_speed = p_player.GetComponent<Player>().p_movement.y;

        //Move this terrain towards the player.
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - m_speed * Time.deltaTime);

        //this move the other terrain to the back of this one
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
