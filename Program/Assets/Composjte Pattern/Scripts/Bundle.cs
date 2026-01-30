using System.Collections.Generic;
using UnityEngine;

public class Bundle : MonoBehaviour, IRewardable
{
    [SerializeField] List<IRewardable> list = new List<IRewardable>();

    public void Add(IRewardable reward)
    {
        list.Add(reward);
    }
    public void Recive()
    {
        foreach (IRewardable reward in list)
        {
            reward.Recive();
        }

    }
}
