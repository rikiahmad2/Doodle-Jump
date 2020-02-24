using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    //deklarasi variabel
    public GameObject platformPrefab;
    public GameObject monsterHijau;
    public GameObject merah;
    public int numberOfPlatforms;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 2f;
    public float monsterWidth = 15f, monsterminY = 10f, monstermaxY = 20f;
    public float merahwidth = 3f, merahminY = 15f, merahmaxY = 25f;

    private int myRandom;

    // Use this for initialization
    void Start()
    {
        //memberi vektor 3 pada posisi spawnplatform, spawn pmonster
        Vector3 spawnPosition = new Vector3();
        Vector3 monsterPosition = new Vector3();
        Vector3 merahposition = new Vector3();


        ///membuat platform sebanyak yang diinginkan ( input user )
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            myRandom = Random.Range(0, 101);
            
            if(myRandom <= 15)
            {
                monsterPosition.x = Random.Range(-monsterWidth, monsterWidth);
                monsterPosition.y += Random.Range(monsterminY, monstermaxY);
                Instantiate(monsterHijau, monsterPosition, Quaternion.identity);
            }
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            spawnPosition.y += Random.Range(minY, maxY);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);

            if(myRandom <= 25)
            {
                merahposition.x = Random.Range(-merahwidth, merahwidth);
                merahposition.y += Random.Range(merahminY, merahmaxY);
                Instantiate(merah, merahposition, Quaternion.identity);
            }
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
