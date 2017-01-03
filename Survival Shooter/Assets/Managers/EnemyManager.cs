using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject enemy;
    public float spawnTime = 3f;
    public float spawnRepeatTime = 3f;
    public Transform[] spawnPoints;


    void Start ()
    {
        //Invokes the method methodName in spawnTime seconds, then repeatedly every spawnRepeatTime seconds.
        InvokeRepeating("Spawn", spawnTime, spawnRepeatTime);
    }


    void Spawn ()
    {
        if(playerHealth.currentHealth <= 0f)
        {
            return;
        }

        int spawnPointIndex = Random.Range (0, spawnPoints.Length);

        Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
