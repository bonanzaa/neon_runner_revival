using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NeonRunnerRevival.Assets.Scripts.Manager;
namespace NeonRunnerRevival
{
    public class PlatformGroundCheck : MonoBehaviour
    {
     private PlayerGroundCheck player;

     private void Start() {
         player = PlayerTracker.Instance.GetComponent<PlayerGroundCheck>();
     }
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
