using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    [SerializeField] private GameObject column;
    private List<GameObject> columns = new List<GameObject>();
    private int spawnX, spawnY;

    private void Start()
    {
        StartCoroutine(SpawnColumnTimer());
    }

    private void SpawnColumn()
    {  
        for (int i = 0; i < 7; i++)
        {
            spawnY = Random.Range(5, 11);

            Vector3 spawnVector = new Vector3(spawnX, spawnY,0);
            GameObject newColumns = Instantiate(column, spawnVector, Quaternion.identity);
            spawnX += 7;
            columns.Add(newColumns);
            if (columns.Count > 100)
            {
                Destroy(columns[0]);
                columns.RemoveAt(0);
            }
        }
        
    }

    IEnumerator SpawnColumnTimer()
    {
        for (int i = 0; i < i+1; i++)
        {
            float timer = 10f;
            SpawnColumn();
            yield return new WaitForSeconds(timer);
            timer -= 0.2f;
        }
        
    }
}
