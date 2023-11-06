using UnityEngine;

public class PlayerCollison : MonoBehaviour
{
    public PlayerMovement movement;
    

    void OnCollisonEnter (Collision collisonInfo)
    {
        if (collisonInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

    }


}
