using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeonRunnerRevival.Assets.Scripts.Manager.LvlGen
{
    /// <summary>
    /// A Collection of Lvl Sections
    /// </summary>
    [Serializable]
    struct Chunk
    {
        public string Name;
        //[Range(0, 5f)]
        //public float chaserSpeed; // TODO : implement chaser speed changes to lvl gen manager
        public List<LevelSection> sections;

        public void Shuffle()
        {
            int listCount = sections.Count;
            while (listCount > 1)
            {
                int k = UnityEngine.Random.Range(0, listCount);
                listCount--;
                LevelSection temp = sections[listCount];
                sections[listCount] = sections[k];
                sections[k] = temp;
            }
        }
    }
}
