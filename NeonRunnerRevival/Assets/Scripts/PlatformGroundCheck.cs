using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeonRunnerRevival
{
    public class PlatformGroundCheck : MonoBehaviour
    {
     public PlayerGroundCheck player;
        private void OnTriggerExit2D(Collider2D other) {
            if(other.CompareTag("Player")){
                player.Grounded = false;
                player.PlayerFalling();
            }
        }

        private void OnTriggerEnter2D(Collider2D other) {
            if(other.CompareTag("Player")){
                player.Grounded = true;
            }
        }
    }
}
