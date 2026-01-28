using UnityEngine;

[System.Serializable]
public class Data
{
    [SerializeField] string name;
    [SerializeField] Sprite sprite;

    public string Name { get { return name; } }

    public Sprite GetSprite { get { return sprite; } }
}
