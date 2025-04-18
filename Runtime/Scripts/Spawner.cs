using HHG.Common.Runtime;
using System;
using UnityEngine;

namespace HHG.Spawning.Runtime
{
    public class Spawner : MonoBehaviour
    {
        public SpawnerWaves Waves => waves;

        [SerializeField, Unfold(UnfoldName.Child)] protected SpawnerWaves waves;

        public virtual void Initialize(Action<Spawn> create)
        {
            waves.Initialize(create);
        }

        public Coroutine Trigger(MonoBehaviour source, Transform transform, float timeScale = 1f)
        {
            return Trigger(source, transform, () => timeScale);
        }

        public Coroutine Trigger(MonoBehaviour source, Transform transform, Func<float> timeScale)
        {
            if (source == null)
            {
                source = this;
            }
            if (transform == null)
            {
                transform = source.transform;
            }
            return source.StartCoroutine(waves.SpawnAsync(transform, timeScale));
        }
    }
}