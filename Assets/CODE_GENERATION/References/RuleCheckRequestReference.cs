using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class RuleCheckRequestReference : BaseReference<RuleCheckRequest, RuleCheckRequestVariable>
	{
	    public RuleCheckRequestReference() : base() { }
	    public RuleCheckRequestReference(RuleCheckRequest value) : base(value) { }
	}
}