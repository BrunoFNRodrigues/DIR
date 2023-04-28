using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector2 offset;
    void Update () 
    {
        transform.position = new Vector2 (player.position.x + offset.x, player.position.y + offset.y); 
    }
}
