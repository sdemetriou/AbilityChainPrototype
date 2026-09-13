using UnityEngine;

public class CameraTracking : MonoBehaviour
{
    [SerializeField] private Transform trackedObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void LateUpdate()
    {
        this.transform.position = new Vector3(trackedObject.position.x, trackedObject.position.y, this.transform.position.z);
    }
}
