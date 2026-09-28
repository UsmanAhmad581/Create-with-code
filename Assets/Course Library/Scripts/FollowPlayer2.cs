using UnityEngine;

public class FollowPlayer2 : MonoBehaviour
{   
    public GameObject Player;
    private Vector3 offset = new Vector3(0.04f, 3.7f, -5.7f);
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
