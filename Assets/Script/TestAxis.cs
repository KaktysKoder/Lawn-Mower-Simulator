using UnityEngine;

public class TestAxis : MonoBehaviour
{
    [SerializeField] private float speedMovement = 10.0f;
    [SerializeField] private float rotationSpeed = 100.0f;

    private void Update()
    {
        float x = Input.GetAxis("Vertical");
        float y = Input.GetAxis("Horizontal");



        //transform.Translate(0, 0, translation);

        //transform.Rotate(0, rotation, 0);
    }
}
