using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public Transform respawnCoordinates;

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player")
            other.gameObject.transform.position = new Vector2(respawnCoordinates.position.x, respawnCoordinates.position.y);
    }
}
