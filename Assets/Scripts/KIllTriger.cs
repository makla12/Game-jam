using UnityEngine;

public class KillTriger : MonoBehaviour
{
    public PlayerControler playerControler;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player")){
            playerControler.health--;
            Destroy(gameObject);
        }
    }
}
