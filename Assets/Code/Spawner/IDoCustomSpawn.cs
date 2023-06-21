using System.Collections.Generic;
using UnityEngine;

public interface IDoCustomSpawn
{
    List<Vector2> GetRandomSpawnPoints(Vector2 vecSpawn,bool checkResLeft);
}
