using Unity.Android.Gradle;
using UnityEngine;

public class RewardManager : MonoBehaviour
{
    [SerializeField] int createCount;
    [SerializeField] Bundle bundle;

    [SerializeField] Reward reward;
    [SerializeField] GameObject rewardList;

    private void Awake()
    {
        createCount = Random.Range(1, 5);
    }
    void Start()
    {
        Create();
    }

    private void Create()
    { 
        for(int i = 0; i<createCount; i++)
        {
            bundle.Add(Instantiate(reward));
        }
    }
    public void Accept()
    {
        bundle.Recive();

        rewardList.SetActive(false);
    }
}
