
using UnityEngine;

public class playercollision : MonoBehaviour
{
    public spacemotion sp;
     void OnCollisionEnter(Collision collisionInfo)
    {
       if (collisionInfo.collider.tag=="obs" )
       {
        Debug.Log("we hit it");
        sp.enabled=false;
       }
    }
}
