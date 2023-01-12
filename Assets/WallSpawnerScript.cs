using UnityEngine;

public class WallSpawnerScript : MonoBehaviour
{

    public GameObject wall;
    public float spawnRate = 2;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;

        }


    }

    void SpawnPipe()
    {
        Instantiate(wall, transform.position, transform.rotation);
    }

}
