using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "ColourSOGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "ScriptableObjects",
	    order = 120)]
	public sealed class ColourSOGameEvent : GameEventBase<ColourSO>
	{
	}
}