using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContainerControl : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float timeCreateEnemy = 2;
    protected float timeCurrentCreateEnemy = 0;
    public float minY;
    public float maxY;
    public float xPosition;
    void CreateEnemy()
    {
        float yPosition = Random.Range(minY, maxY);
        Vector2 positionToCreate = new Vector2(xPosition, yPosition);
        GameObject enemy = Instantiate(enemyPrefab, positionToCreate, transform.rotation);
    }
    void Update()
    {
        timeCurrentCreateEnemy = timeCurrentCreateEnemy + Time.deltaTime;
        if (timeCurrentCreateEnemy >= timeCreateEnemy)
        {
            timeCurrentCreateEnemy = 0;
            CreateEnemy();
        }
    }
}
