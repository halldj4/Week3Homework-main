using UnityEngine;

public class GameManager : MonoBehaviour
{
    public const float ROW_HEIGHT = 0.48f;
    public const int PIECE_COUNT_PER_ROW = 13;
    public const float PIECE_LENGTH = 0.96f;
    public const int TOTAL_ROWS = 10;


    [SerializeField]
    private Transform pieces = null;

    [SerializeField]
    private GameObject piecePrefab = null;

    [SerializeField]
    private EdgeCollider2D border;

    [SerializeField]
    private GameObject ballPrefab = null;
    [SerializeField] private GameObject paddleBall = null;

    bool hasBall = true;

    void Update()
    {
        // If the user presses space add a new ball to the scene
        if (Input.GetKeyDown(KeyCode.Space) && hasBall == true)
        {

            Instantiate(ballPrefab, paddleBall.transform.position + new Vector3(0, 0, 0), Quaternion.identity);
            paddleBall.SetActive(false);
            hasBall = false;
        }
    }
    void Start()
    {

        //TODO
        //Using const data defined above "Instantiate" new pieces to fill the view with


        int row = 0;
        int column = 0;
        while (row < 13)
        {
            /*
            while (column < 13)
            {
               
                column = column + 1;
            }
        */ 
            Instantiate(piecePrefab, new Vector3(-5.5f + PIECE_LENGTH * row, -1.0f, 0), Quaternion.identity);
            Instantiate(piecePrefab, new Vector3(-5.5f + PIECE_LENGTH * row, -1.0f + ROW_HEIGHT * 1, 0), Quaternion.identity);
            Instantiate(piecePrefab, new Vector3(-5.5f + PIECE_LENGTH * row, -1.0f + ROW_HEIGHT * 2, 0), Quaternion.identity);
            Instantiate(piecePrefab, new Vector3(-5.5f + PIECE_LENGTH * row, -1.0f + ROW_HEIGHT * 3, 0), Quaternion.identity);
            Instantiate(piecePrefab, new Vector3(-5.5f + PIECE_LENGTH * row, -1.0f + ROW_HEIGHT * 4, 0), Quaternion.identity);
            Instantiate(piecePrefab, new Vector3(-5.5f + PIECE_LENGTH * row, -1.0f + ROW_HEIGHT * 5, 0), Quaternion.identity);
            Instantiate(piecePrefab, new Vector3(-5.5f + PIECE_LENGTH * row, -1.0f + ROW_HEIGHT * 6, 0), Quaternion.identity);
            Instantiate(piecePrefab, new Vector3(-5.5f + PIECE_LENGTH * row, -1.0f + ROW_HEIGHT * 7, 0), Quaternion.identity);
            Instantiate(piecePrefab, new Vector3(-5.5f + PIECE_LENGTH * row, -1.0f + ROW_HEIGHT * 8, 0), Quaternion.identity);
            Instantiate(piecePrefab, new Vector3(-5.5f + PIECE_LENGTH * row, -1.0f + ROW_HEIGHT * 9, 0), Quaternion.identity);
            Instantiate(piecePrefab, new Vector3(-5.5f + PIECE_LENGTH * row, -1.0f + ROW_HEIGHT * 10, 0), Quaternion.identity);
            row = row + 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Destroy(collision.gameObject);
            paddleBall.SetActive(true);
            hasBall = true;
        }
        //TODO: Implement functionality to reset the game somehow.
        // Resetting the game includes destroying the out of bounds ball and creating a new one ready to be launched from the paddle
    }
}


