using System;
using System.Collections.Generic;
using UnityEngine;

namespace HHG.Spawning.Runtime
{
    [Serializable]
    public class SpawnWaves
    {
        public List<SpawnPoint> SpawnPoints => spawnPoints;

        [SerializeField] private List<SpawnPoint> spawnPoints = new List<SpawnPoint>();
    }
}