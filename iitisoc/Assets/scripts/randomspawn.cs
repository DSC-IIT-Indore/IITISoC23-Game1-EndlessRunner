using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomspawn : MonoBehaviour
{
    public GameObject cubeprefab;

    void Update()
    {
        Vector3 randomspawnPosition=new Vector3(Random.Range(-10,11),-2,Random.Range(-10,11));
        Instantiate(cubeprefab,randomspawnPosition,Quaternion.identity);
        
    }
}
