using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<Enemy> allSpawnedEnemies = new List<Enemy>();

    [SerializeField] private Enemy[] possibleEnemyPrefabs;
    [SerializeField] private Transform[] possibleSpawnPoints;


    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }


    private IEnumerator SpawnEnemy()
    {
        while( true )
        {

            yield return new WaitForSeconds(3);

            int randomEnemyIndex = Random.Range(0, possibleEnemyPrefabs.Length);

            Enemy newClonedEnemy = Instantiate(possibleEnemyPrefabs[randomEnemyIndex]);

            allSpawnedEnemies.Add(newClonedEnemy);

            

            int randomSpawnIndex = Random.Range(0, possibleSpawnPoints.Length);
            Transform randomTransform = possibleSpawnPoints[randomSpawnIndex];

            newClonedEnemy.transform.position = randomTransform.position;

           
        }

    }

    public void RemoveEnemyFromList(Enemy toRemove)
    {
        allSpawnedEnemies.Remove(toRemove);
    }

}















/*
private Player playerCharacter;

private Weapon sword;
private Weapon rifle;
*/

/*
playerCharacter = FindAnyObjectByType<Player>();

sword = new MeleeWeapon();
rifle = new RangedWeapon();

playerCharacter.ChangeWeapon(sword);
*/


/*

if(Input.GetKeyDown(KeyCode.Alpha1))
{
    playerCharacter.ChangeWeapon(sword);
}
else if(Input.GetKeyDown(KeyCode.Alpha2))
{
    playerCharacter.ChangeWeapon(rifle);
}

*/