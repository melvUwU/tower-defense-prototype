using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard : MonoBehaviour
{
    public float blockRange = 4f;

    public string enemyTag = "Enemy";

    public int maxBlockedEnemies = 3;

    // Update is called once per frame
    void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        int numBlockedEnemies = 0;
        foreach (GameObject enemy in enemies)
        {
            Vector3 direction = enemy.transform.position - transform.position;
            Debug.Log(blockRange);
            if (direction.magnitude <= blockRange)
            {
                Debug.Log("block");
                numBlockedEnemies++;
                if (numBlockedEnemies <= maxBlockedEnemies)
                {
                    enemy.GetComponent<Enemy>().SetBlocked(true);
                }
            }
        }
    }
}
