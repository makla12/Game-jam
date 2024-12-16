using UnityEngine;

public class PlatformCleanUp : MonoBehaviour
{
    private void Update() {
        if(transform.position.x <= -20){
            Destroy(gameObject);
        }
    }
}