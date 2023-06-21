using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class ColourSOReference : BaseReference<ColourSO, ColourSOVariable>
	{
	    public ColourSOReference() : base() { }
	    public ColourSOReference(ColourSO value) : base(value) { }
	}
}