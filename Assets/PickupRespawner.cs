using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupRespawner : MonoBehaviour {

    public float minSpawnTime;
    public float maxSpawnTime;

    private BoxCollider bc;
    private MeshRenderer mr;
    private float nextSpawnTime = 0;

	// Use this for initialization
	void Start () {
        bc = GetComponent<BoxCollider>();
        mr = GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextSpawnTime)
        {
            bc.enabled = true;
            mr.enabled = true;
        }
	}

    public void collect()
    {
        bc.enabled = false;
        mr.enabled = false;
        nextSpawnTime = Random.Range(minSpawnTime, maxSpawnTime) + Time.time;
    }
}
