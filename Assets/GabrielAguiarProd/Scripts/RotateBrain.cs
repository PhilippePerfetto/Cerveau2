using UnityEngine;

public class RotateBrain : MonoBehaviour
{
    public float rotationSpeed;
    public int nbSecondToRotate = 6;

    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = 360f / (float)nbSecondToRotate;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
