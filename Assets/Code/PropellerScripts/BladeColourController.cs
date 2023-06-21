using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class BladeColourController : MonoBehaviour
{
    [SerializeField]private List<ColourSO> _coloursSO;
    [SerializeField]private SpriteRenderer _spriteRenderer;
    [SerializeField]private ColourSO _currentColour;
    
    private int _currentColorIndex = 0;
    
    public void DoSwitchAndSetColour()
    {
        _currentColorIndex = (_currentColorIndex + 1) % _coloursSO.Count;
        SetColourRenderer(_coloursSO[_currentColorIndex]);
    }
    
    public void SetColourRenderer(ColourSO colour)
    {
        _currentColour = colour;
        _spriteRenderer.color = _currentColour.colourRender;
    }

    public ColourSO CurrentColour
    {
        get => _currentColour;
    }
}
