using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public GameObject nose;
    public List<GameObject> fishPrefabs = new List<GameObject>(); // 2
    public List<Transform> SpawnPositions = new List<Transform>(); // 3
    public float timeBetweenSpawns; 
    public float spwanPos;
    private float nosePos;


    private GameObject BigFish;
    private bool spawnedBigFish = false;
    private float counter = 0;

    private List<GameObject> fishList = new List<GameObject>(); // 5

    // Start is called before the first frame update
    void Start()
    {   
        BigFish = fishPrefabs[0];
        InvokeRepeating("SpawnRoutine", 1f, timeBetweenSpawns);
    }

    private void SpawnFish()
    {
        if(spawnedBigFish == true && counter < 2){
            Debug.Log("SpawnedLittleFish");
            Vector3 randomPosition = SpawnPositions [Random.Range(0,SpawnPositions.Count)].position;
            GameObject fish = Instantiate(fishPrefabs[1], randomPosition ,fishPrefabs[1].transform.rotation);
            fishList.Add(fish); // 3
            fish.SetActive(true);
            counter += 1;
        }else{
            spawnedBigFish =false;
            counter = 0;
            Vector3 randomPosition = SpawnPositions [Random.Range(0,SpawnPositions.Count)].position; // Chose a random spawn position between the three possible
            GameObject randomFish = fishPrefabs[Random.Range(0,fishPrefabs.Count)];
        

            GameObject fish = Instantiate(randomFish, randomPosition ,randomFish.transform.rotation);
            if(randomFish.CompareTag("Fish1")){
                Debug.Log("SpawnedBigFish");
                spawnedBigFish = true;
            }
            fishList.Add(fish); // 3
            fish.SetActive(true);
        }

    }
    private void SpawnRoutine() // 1
    {
        if(nose.transform.position.y <= spwanPos){
            SpawnFish(); // 3
        }

    }
    public void RemoveFishFromList (GameObject fish)
    {
        fishList.Remove(fish);
    }
    public void DestroyAllFish()
    {   
        foreach (GameObject f in fishList) // 1
        {
            Destroy(f); // 2
        }

        fishList.Clear();
    }

}
