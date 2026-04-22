using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class GameManager : MonoBehaviour
{
    [Header("Enemies")]
    [SerializeField] private List<Enemy> allSpawnedEnemies = new List<Enemy>();
    [SerializeField] private Enemy[] possibleEnemyPrefabs;
    [SerializeField] private Transform[] possibleSpawnPoints;

    [Header("Pick ups")]
    [SerializeField] private Pickup[] pickupsPrefabs;
    [SerializeField] private float chanceToSpawnPickup;

    private int currentScore;


    private void SpawnRandomPickup(Vector2 position)
    {
        int randomIndex = Random.Range(0, pickupsPrefabs.Length);
        Pickup randomPickup = pickupsPrefabs[ randomIndex ];
        Instantiate(randomPickup, position, Quaternion.identity);
    }

    public void RemoveEnemyFromList(Enemy toRemove)
    {
        allSpawnedEnemies.Remove(toRemove);
        currentScore += 10;

        //Spawn a pick up
        if(Random.Range(0, 100) < chanceToSpawnPickup)
        {
            SpawnRandomPickup(toRemove.transform.position);
        }
        

    }


    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        while( true )
        {

            yield return new WaitForSeconds(1.2f);

            int randomEnemyIndex = Random.Range(0, possibleEnemyPrefabs.Length);

            Enemy newClonedEnemy = Instantiate(possibleEnemyPrefabs[randomEnemyIndex]);

            allSpawnedEnemies.Add(newClonedEnemy);

            

            int randomSpawnIndex = Random.Range(0, possibleSpawnPoints.Length);
            Transform randomTransform = possibleSpawnPoints[randomSpawnIndex];

            newClonedEnemy.transform.position = randomTransform.position;

           
        }

    }



    public int GetCurrentScore()
    {
        return currentScore;
    }

    public void RegisterHighscore()
    {      
        if(currentScore > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", currentScore);
            Debug.Log("You have a new HighScore of " + currentScore.ToString());
        }

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