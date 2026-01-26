using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] int createCount;
    [SerializeField] static ObjectPool instance;
    public static ObjectPool Instance { get { return instance; } }
    [SerializeField] Queue<GameObject> queue = new Queue<GameObject>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        Create();
    }

    void Create()
    {
        for(int i = 0; i< createCount; i++)
        {
            GameObject clone = Instantiate(Resources.Load<GameObject>("Minotaur"));
            clone.transform.SetParent(transform);
            clone.SetActive(false);
            queue.Enqueue(clone);
        }
    }
    public GameObject GetObject()
    {
        GameObject clone = null;
        if(queue.Count>0)
        {
            clone = queue.Dequeue();
        }
        else
        {
            queue.Enqueue(Instantiate(Resources.Load<GameObject>("Minotaur")));

            clone = queue.Dequeue();

            clone.transform.SetParent(transform);
        }
        clone.SetActive(true);

        return clone;
    }
    public void Return(GameObject clone)
    {
        clone.SetActive(false);
        queue.Enqueue(clone);
    }
}
