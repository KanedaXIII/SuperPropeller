using System.Collections.Generic;
using UnityEngine;

namespace Code
{
    public class RegularColourable : IColourable
    {
        private readonly List<BladeColourController> _blades;

        public RegularColourable(List<BladeColourController> blades)
        {
            _blades = blades;
        }

        public void DoNextColour()
        {
            foreach (BladeColourController blade in _blades)
            {
                blade.DoSwitchAndSetColour();
            }
        }
    }
}
