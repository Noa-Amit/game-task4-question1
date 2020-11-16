using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    static int life_points = 3;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            life_points--;
            Debug.Log("life: "+life_points);
            if (life_points == 0 ){
                Destroy(this.gameObject);
            }
            Destroy(other.gameObject);
        }
    }

    public void addLife() {
        life_points++;
        Debug.Log("life: "+life_points);
    }
}
