using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    private int timeForPlatform = 166;
    [SerializeField] private GameObject[] platformObjects;

    private void FixedUpdate() {
        timeForPlatform--;
        if(timeForPlatform <= 1)
        {
            timeForPlatform = 166;

            Instantiate(platformObjects[Random.Range(0, platformObjects.Length)], transform);
        }
    }
}
