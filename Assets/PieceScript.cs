using UnityEngine;

public class PieceScript : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public float jumpStrength;
    public LogicScript logic;
    public bool pieceActive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && pieceActive)
        {
            rigidBody.velocity = Vector2.up * jumpStrength;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        pieceActive = false;
    }
}
