using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRule
{
    bool CheckMatchRule(ColourSO blade,ColourSO colourGeometry);

    bool CheckGameOver();
    
}
