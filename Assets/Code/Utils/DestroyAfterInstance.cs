using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterInstance : MonoBehaviour
{
    [SerializeField]
    private float timeDelayDestroy = 1.2f;
    void Start()
    {
        Destroy(this.gameObject, timeDelayDestroy);
    }
}
