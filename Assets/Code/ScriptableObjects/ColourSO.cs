using UnityEngine;

[CreateAssetMenu(fileName = "Colour", menuName = "Scriptable Object/Colour")]
public class ColourSO : ScriptableObject
{
    public string colourName;
    public Color colourRender;
}
