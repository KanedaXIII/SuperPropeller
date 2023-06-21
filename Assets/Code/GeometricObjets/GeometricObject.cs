using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableObjectArchitecture;
using UnityEngine;
using Random = UnityEngine.Random;
using Code;
public class GeometricObject : MonoBehaviour
{
    [SerializeField] private List<ColourSO> _coloursSO;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private GameObject PartticleMatch;
    [SerializeField] private GameObject ParticleUnmatch;
    private ColourSO _currentColour;

    public RuleCheckRequestGameEvent RuleCheckRequestEvent;

    private void Awake()
    {
        _currentColour = ChooseRandomColour();
        _spriteRenderer.color = _currentColour.colourRender;
    }

    private ColourSO ChooseRandomColour()
    {
        int index = Random.Range(0, _coloursSO.Count);
        return _coloursSO[index];
    }
    
    void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.CompareTag("Player"))
        {
            GameObject propeller = (col.GetComponent<Propeller>()) ? col.gameObject : null;

            RuleCheckRequest resquest = new RuleCheckRequest(propeller, propeller.transform.GetChild(0).GetComponent<BladeColourController>().CurrentColour, _currentColour);

            RuleCheckRequestEvent.Raise(resquest);

            String colourBlade = propeller.transform.GetChild(0).GetComponent<BladeColourController>().CurrentColour.colourName;

            Vector2 collisionPosition = col.gameObject.transform.position;

            if (_currentColour.colourName == colourBlade)
            {
                Instantiate(PartticleMatch, collisionPosition, Quaternion.identity);
            }
            else
            {
                Instantiate(ParticleUnmatch, collisionPosition, Quaternion.identity);
            }

            Destroy(this.gameObject);
        }
        else if(col.CompareTag("Destroyer"))
        {
            Destroy(this.gameObject);
        }
    }
}
