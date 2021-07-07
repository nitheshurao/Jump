

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerate : MonoBehaviour
{
    // Start is called before the first frame update
    [System.Serializable]
    public class Pool
    {
        public string tag;
        public GameObject prefabs;
        public int size;
    }
    public List<Pool> pools;

    public static RandomGenerate Instance;
    private void Awake()
    {
        Instance = this;
    }

    public Dictionary<string, Queue<GameObject>> poolDictionary;
    void Start()
    {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();
        foreach (Pool pool in pools)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();
            for (int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefabs);
                obj.SetActive(false);

                objectPool.Enqueue(obj);
            }
            poolDictionary.Add(pool.tag, objectPool);
            StartCoroutine(fire(1, pool.size));
        }
    }
    //
    

    IEnumerator fire(int i, int size)
    {
        Debug.Log("hiii");
        yield return new WaitForSeconds(i);

        //float spawnY = Random.Range
        //                ((new Vector2(0, 0)).y, (new Vector2(5, 6)).y);
        //float spawnX = Random.Range(-3,3);

        //Vector2 spawnPosition = new Vector2(spawnX, 5);
        spawnFromPool("wood");
        yield return new WaitForSeconds(2);
        spawnFromPool("wood1");
        //spawnFromPool("wood");

        for (int j = 0; j < size; j++)
        {
            
            StartCoroutine(fire(2, size - 1));
            yield return new WaitForSeconds(2);

        }
        size--;
    }
    //

    public void spawnFromPool(string tag)
    {

        GameObject objectSpawn = poolDictionary[tag].Dequeue();

       

        Debug.Log("true");

        if (!poolDictionary.ContainsKey(tag))
        {
            Debug.Log("Pool " + tag + " not exit");
            return ;
        }
        //active(true, objectSpawn);

        objectSpawn.SetActive(true);
        //objectSpawn.transform.position = postion;
        //objectSpawn.transform.rotation = roation;

        poolDictionary[tag].Enqueue(objectSpawn);



    }

    public GameObject DeactiveFromPool(string tag, Vector3 postion, Quaternion roation)
    {

        GameObject objectSpawn = poolDictionary[tag].Dequeue();

        if (!poolDictionary.ContainsKey(tag))
        {
            Debug.Log("Pool " + tag + " not exit");
            return null;
        }
        //active(true, objectSpawn);

        objectSpawn.SetActive(false);
        objectSpawn.transform.position = postion;
        //objectSpawn.transform.rotation = roation;

        poolDictionary[tag].Enqueue(objectSpawn);
        return objectSpawn;
    }



    //float spawnY = Random.Range
    //                ((new Vector2(0, 0)).y, (new Vector2(4, _Player.position.y + 9f)).y);
    //float spawnX = Random.Range
    //     ((new Vector2(0, 0)).x, (new Vector2(_Player.position.x + 9f, 1)).x);

    //Vector2 spawnPosition = new Vector2(spawnX, spawnY);
    //FreFabs.Instance.spawnFromPool("man", spawnPosition, Quaternion.identity);



}
