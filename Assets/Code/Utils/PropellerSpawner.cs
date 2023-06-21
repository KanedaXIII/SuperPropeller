using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpawner : MonoBehaviour
{
    [Header("Dependencies")]
    public GameObject railSpawn;
    public GameObject propellerPrefab;

    public void InstantiatePropellerOnLevel()
    {
        GameObject propeller = GetPropeller();
        propeller.transform.position = railSpawn.transform.position;
    }

    private GameObject GetPropeller()
    {
        GameObject propellerObject = GameObject.FindGameObjectWithTag("Player");

        if (propellerObject == null)
        {
            propellerObject = Instantiate(propellerPrefab, Vector3.zero, Quaternion.identity);
        }

        return propellerObject;
    }
}
