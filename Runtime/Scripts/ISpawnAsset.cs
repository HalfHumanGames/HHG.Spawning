using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace HHG.SpawnSystem.Runtime
{
    public interface ISpawnAsset
    {
        public bool IsEnabled { get; }
        public GameObject Prefab { get; }
        public Sprite Icon { get; }

        public void AppendInfoTextInternal(StringBuilder sb, List<SpawnPoint> points, int wave)
        {

        }

        public static void AppendInfoText(StringBuilder sb, List<SpawnPoint> points, int wave)
        {
            points.SelectMany(p => p.Spawns.Cast<ISpawnAsset>()).FirstOrDefault(s => s != null)?.AppendInfoTextInternal(sb, points, wave);
        }
    }
}