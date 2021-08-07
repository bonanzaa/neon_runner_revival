using NeonRunnerRevival.Assets.Scripts.Manager;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeonRunnerRevival.Assets.Scripts
{
    public class PlayerMarker : MonoBehaviour
    {
        private PlayerTracker _tracker;
        private void Start()
        {
            ForceGameManagerToKnowAboutMe();
        }

        private void ForceGameManagerToKnowAboutMe()
        {
            // make GameManager a singleton, and better use GameManager.Instance
            // to find it, otherwise this is too slow and will throw null exceptions
            if(PlayerTracker.Instance != null){
                _tracker = PlayerTracker.Instance;
                _tracker.CashPlayerReference(this);
            }
        }
    }
}
