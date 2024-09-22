using UnityEngine;

public class Enemyspawner2 : MonoBehaviour
{
    [SerializeField]
    private GameObject _Golum;

    [SerializeField]
    private float _minimumSpawnTime;

    [SerializeField]
    private float _maximumSpawnTime;

    private float _TimeUntilSpawn;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        SetTimeUntilSpawn();  
    }

    // Update is called once per frame
    void Update()
    {
        _TimeUntilSpawn -= Time.deltaTime;
        if (_TimeUntilSpawn <= 0)
        {
            Instantiate(_Golum, transform.position, Quaternion.identity);
            SetTimeUntilSpawn();

        }
       
    }
    private void SetTimeUntilSpawn()
    { _TimeUntilSpawn = Random.Range(_minimumSpawnTime, _maximumSpawnTime);
    
    }
}
