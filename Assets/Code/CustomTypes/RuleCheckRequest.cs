using UnityEngine;

[System.Serializable]


public class RuleCheckRequest
{
    public GameObject propeller;
    public ColourSO bladeColour;
    public ColourSO geometricObject;

    public RuleCheckRequest(GameObject propeller, ColourSO bladeColour,ColourSO geometricObject)
    {
        this.propeller = propeller;
        this.bladeColour = bladeColour;
        this.geometricObject = geometricObject;
    }
    
}
