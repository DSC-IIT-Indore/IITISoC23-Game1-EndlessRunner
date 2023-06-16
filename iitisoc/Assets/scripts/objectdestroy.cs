using UnityEngine;

public class objectdestroy : MonoBehaviour
{

    public GameObject player;
    public GameObject objects;

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.z>objects.transform.position.z)
        {
        
             Destroy(objects, 1f);
            
        }
    }
}
