using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class ColourSOEvent : UnityEvent<ColourSO> { }

	[CreateAssetMenu(
	    fileName = "ColourSOVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "ScriptableObjects",
	    order = 120)]
	public class ColourSOVariable : BaseVariable<ColourSO, ColourSOEvent>
	{
	}
}