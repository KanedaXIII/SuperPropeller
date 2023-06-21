using System;
using System.Collections.Generic;
using UnityEngine;

namespace Code
{
    public class ColourController : MonoBehaviour
    {
        [SerializeField] private List<BladeColourController> _blades;

        private IColourable _regularColourable;

        private IColourable _currentColourable;

        public IColourable CurrentColourable { get => _currentColourable; }

        public ColourController(List<BladeColourController> blades)
        {
            _blades = blades;
        }

        private void Awake()
        {
            _regularColourable = new RegularColourable(_blades);
            _currentColourable = _regularColourable;
        }
        
        public void OnSwitchColor()
        {
            _currentColourable.DoNextColour();
        }
        
        public void Reset()
        {
            
        }
    }
}
