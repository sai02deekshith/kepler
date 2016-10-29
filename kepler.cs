using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public  class TileManager : MonoBehaviour
{
	public GameObject[] tilePrefabs;
	
	private Transform playerTransform;
	private float spawnZ = -6.0f;
	private float tileLength = 12.0f;
	private int amnTilesOnScreen = 7;
	private List<GameObject> activeTiles;
	
	
	// use this for initialization
	private void Start () {
		activeTiles = new List<GameObject>();
		playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
		
		for(int i =0; i < amnTilesOnScreen; i++)
		{
			SpawnTile();
		}
	}	

	 // Update is called once per frame
	
