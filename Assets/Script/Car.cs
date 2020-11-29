using UnityEngine;

public class Car : MonoBehaviour
{
    [Header("Set in Inspector")]
    [Tooltip("Экземпляр (префаб или ссылка) на Car")]
    [SerializeField] private GameObject carPrefab;
    [SerializeField] private float speedGresCar = 1.0f;

    public CharacterController characterController;
    public float speed = 12.0f;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Vector3 tempGresCarPosition = transform.position;

        tempGresCarPosition.z += speedGresCar * Time.deltaTime;

        transform.position = tempGresCarPosition;

        float x = Input.GetAxis("Vertical");
        float z = Input.GetAxis("Horizontal");

        Vector3 move = transform.right * z + transform.forward * x;

        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    transform.Rotate(0, -45, 0);

        //    speedGresCar = -speedGresCar;

        //}
        //else if(Input.GetKeyDown(KeyCode.D))
        //{
        //    transform.Rotate(0, 45, 0);

        //}


        characterController.Move(move * speed * Time.deltaTime);

    }
}
