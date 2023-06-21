using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeometryGenerator : MonoBehaviour
{
    [SerializeField] private Collider2D spawnZone;
    [SerializeField] private List<GameObject> geometricObjects;
    [SerializeField] private List<ColourSO> coloursGeometricObjects;

    [SerializeField] private float spawnInterval = 2f;

    [SerializeField] private CascadeSpawn _customSpawn;

    private IEnumerator Start()
    {
        while (true)
        {
            yield return StartCoroutine("SpawnCustom");

            yield return new WaitForSeconds(3f);
        }
    }

    private void Update()
    {
        StartCoroutine("Reset");
    }

    private void SpawnGeometricObject(Vector2 spawnPos)
    {
        GameObject objectToSpawn = ChooseRandomGeometricObject();
        Instantiate(objectToSpawn, spawnPos, Quaternion.identity);
    }

    IEnumerator Reset()
    {
        // your process
        yield return new WaitForSeconds(5);
        // continue process
    }

    private IEnumerator SpawnCustom()
    {
        Vector2 spawnPosition = GetRandomSpawnPosition();

        bool checkResLeft = CheckLeftSpace(spawnPosition);


        List<Vector2> spawnPointsList = _customSpawn.GetRandomSpawnPoints(spawnPosition, checkResLeft);

        foreach (Vector2 spawnP in spawnPointsList)
        {
            yield return new WaitForSeconds(0.5f);
            SpawnGeometricObject(spawnP);
        }
    }

    private bool CheckLeftSpace(Vector2 initSpawn)
    {
        bool checkResLeft = true;

        Vector2 rightPoint = new Vector2(spawnZone.bounds.max.x, spawnZone.bounds.max.y);
        Vector2 leftPoint = new Vector2(spawnZone.bounds.min.x, spawnZone.bounds.min.y);

        float distanceRight = Mathf.Sqrt(Mathf.Pow(initSpawn.x - rightPoint.x, 2) + Mathf.Pow(initSpawn.y - initSpawn.y, 2));

        float distanceLeft = Mathf.Sqrt(Mathf.Pow(initSpawn.x - leftPoint.x, 2) + Mathf.Pow(initSpawn.y - initSpawn.y, 2));

        if (distanceRight> distanceLeft)
        {
            checkResLeft = false;
        }

        return checkResLeft;
    }

    private Vector2 GetRandomSpawnPosition()
    {
        float minX = spawnZone.bounds.min.x;
        float maxX = spawnZone.bounds.max.x;
        float minY = spawnZone.bounds.min.y;
        float maxY = spawnZone.bounds.max.y;

        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        return new Vector2(randomX, randomY);
    }

    private GameObject ChooseRandomGeometricObject()
    {
        int index = Random.Range(0, geometricObjects.Count);
        return geometricObjects[index];
    }
}
