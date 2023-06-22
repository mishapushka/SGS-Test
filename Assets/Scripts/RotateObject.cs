using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public Vector3 RotationSpeed;

    private void Update() {
        transform.Rotate(RotationSpeed * Time.deltaTime);
    }
}
