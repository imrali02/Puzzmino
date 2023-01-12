using UnityEngine;

public class WallMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
