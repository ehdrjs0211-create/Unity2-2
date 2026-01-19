using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] bool state;
    public bool State { get { return state; } }
    [SerializeField] static GameManager instance;
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
    {
        state = true;
    }

    // Update is called once per frame
    public void Pause()
    {
        state = false;
    }
}
