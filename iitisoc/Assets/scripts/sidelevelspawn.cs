using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sidelevelspawn : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public float zSpawn = 0;
    public float xSpawn = 0;
    public float tileLength = 500;
    public float tileLength2 = 100;

    public int totalNumOfTiles = 8;
    public int numberOfTiles = 3;
    public Transform playerTransform;
    private List<GameObject> activeTiles = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfTiles; i++)
        {
            if(i==0)
                SpawnTile(0);
            else
                SpawnTile(Random.Range(0, tilePrefabs.Length));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.x-100>xSpawn-(numberOfTiles*tileLength))
        {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
            DeleteTile();
        }
    }
    public void SpawnTile(int tileIndex)
    {
        Vector3 randomspawnPosition=new Vector3(85,-21+xSpawn,zSpawn);
        GameObject go= Instantiate(tilePrefabs[tileIndex],randomspawnPosition,transform.rotation);

        activeTiles.Add(go);
        zSpawn+=tileLength;
        xSpawn+=tileLength2;
    }
    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}
