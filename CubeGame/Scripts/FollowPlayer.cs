using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;

    private void Start()
    {
        //offset holds the distance between camera and player objects
        offset = transform.position - player.position;  
    }

    // Update is called once per frame
    void Update()
    {
        //camera follows players position + the distance set in the editor
        transform.position = player.position + offset;
    }
}
