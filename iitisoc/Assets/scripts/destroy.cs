using UnityEngine;

public class destroy : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject player;
    public spacemotion sp;

    // Update is called once per frame
    void Update()
    {
    

        if (player.transform.position.x<-51f || player.transform.position.x>51f)
        {
            rb.useGravity = true;
            sp.enabled=false;
            
        }

    }
}
