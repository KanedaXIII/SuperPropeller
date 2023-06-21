using Code;
using UnityEngine;

public class RailEndTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "CorePlayer")
        {
           collision.transform.parent.GetComponent<MovementController>().OnSwitchDirection();
        }
    }
}
