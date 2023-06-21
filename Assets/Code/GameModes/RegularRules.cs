using UnityEngine;

namespace Code.GameModes
{
    public class RegularRules : IRule
    {
        public bool CheckMatchRule(ColourSO blade, ColourSO colourGeometry)
        {
            if (blade.colourName == colourGeometry.colourName)
            {
                return true;
            }
            else
            {

            }
            return false;
        }
        public bool CheckGameOver()
        {

            return false;
        }
    }
}
