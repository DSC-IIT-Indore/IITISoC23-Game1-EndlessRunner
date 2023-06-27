using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomspawn : MonoBehaviour
{
    public GameObject cubeprefab;
    public GameObject pl;
    public GameObject end1;
    public GameObject end2;
    public int objcount;
    public int num;
    
    void Start() 
    {
        StartCoroutine(spawnerzz());
        
        
    }


IEnumerator spawnerzz()
{
    while (objcount<num)
    {
        
        Vector3 randomspawnPosition=new Vector3(Random.Range(-100,100),0,Random.Range(end1.transform.position.z,end2.transform.position.z));
        Instantiate(cubeprefab,randomspawnPosition,Quaternion.identity);
        yield return new WaitForSeconds(0f);
        objcount+=1;
    }
    

 
} 


}
