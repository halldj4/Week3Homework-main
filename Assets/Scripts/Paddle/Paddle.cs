using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 3.0f;
    [SerializeField] private GameObject ballPrefab = null;

    //TODO
    // Move paddle left and right using keyboard keys, mapping is up to you
    // Paddle should be able to launch the ball upon space bar being pressed
    // A launched ball will then bounce around, changing its direction upon any collision
    void Start()
    {
        Instantiate(ballPrefab);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);

        }
        var yPosition = Mathf.Clamp(transform.position.y, -3.4f, 3.4f);
        transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);
        if (transform.position.x > 7) transform.position = new Vector3(7, transform.position.y, 0); //right bound
        else if (transform.position.x < -7) transform.position = new Vector3(-7, transform.position.y, 0); //left bound
    }
}
