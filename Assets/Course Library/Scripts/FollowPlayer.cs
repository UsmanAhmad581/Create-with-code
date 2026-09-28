using UnityEngine;

public class FollowPlayer : MonoBehaviour
{   
    public GameObject Player;
    private Vector3 offset = new Vector3(-0.02f, 3.8f, -5.72f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
    }
}
