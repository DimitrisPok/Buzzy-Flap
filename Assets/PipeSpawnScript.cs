using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 1;

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
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Vector3 spawnPosition = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0);
        GameObject newPipe = Instantiate(pipe, spawnPosition, transform.rotation);

        // Debug log to check the spawn position
        Debug.Log($"Spawned pipe at: {spawnPosition} (Spawner X: {transform.position.x}, Y: {spawnPosition.y})");
    }
}
