using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CascadeSpawn : MonoBehaviour, IDoCustomSpawn
{
    [SerializeField] private int _minNGeometricObjects;
    [SerializeField] private int _maxNGeometricObjects;
    [SerializeField] private bool _leftDirectionSpawn;
    [SerializeField] private float _minOffsetX;
    [SerializeField] private float _maxOffsetX;
    private Vector2 _initialSpawnPoint;

    public List<Vector2> GetRandomSpawnPoints(Vector2 initSpawnVec,bool checkResLeft)
    {
        List<Vector2> resListSpawnPoints = new List<Vector2>();
        int displacementFactor = 1;
        _initialSpawnPoint = initSpawnVec;
        Vector2 initSpawnVector = _initialSpawnPoint;

        resListSpawnPoints.Add(_initialSpawnPoint);

        if (_leftDirectionSpawn)
        {
            displacementFactor = -1;
        }
       
        float offsetX = RandomOffsetX() * displacementFactor;

        int nGeometricObjects = (int)RandomNGeometricObjects();

        for (int n=1; n<nGeometricObjects; n++)
        {
            initSpawnVector = new Vector2(initSpawnVector.x + offsetX, initSpawnVector.y);
            resListSpawnPoints.Add(initSpawnVector);

        }
        return resListSpawnPoints;
    }

    private float RandomOffsetX()
    {
       float res = Random.Range(_minOffsetX, _maxOffsetX);
        return res;
    }

    private float RandomNGeometricObjects()
    {
        float res = Random.Range(_minNGeometricObjects, _maxNGeometricObjects);
        return res;
    }
    public Vector2 InitialSpawnPoint { get => _initialSpawnPoint; set => _initialSpawnPoint = value; }
}
