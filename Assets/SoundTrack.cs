using UnityEngine;

public class SoundTrack : MonoBehaviour
{
    private void Start() {
        DontDestroyOnLoad(this.gameObject);
    }
}
