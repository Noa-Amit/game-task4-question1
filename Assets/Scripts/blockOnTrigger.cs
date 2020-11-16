using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockOnTrigger : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            Debug.Log("me: "+transform.position+" wall:"+other.transform.position);
            
        }
    }
}
