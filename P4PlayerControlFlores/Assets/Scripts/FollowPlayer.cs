using UnityEngine;

public class FolllowPlayer : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset= new Vector3(0, 5, -7);
    private Vector3 offset2 = new Vector3(0, 3, 0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
       
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = player.transform.position + offset2;
        }
    }
}
