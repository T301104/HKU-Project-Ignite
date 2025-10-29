using UnityEngine;

public class MonkeyManager : MonoBehaviour
{
    public static MonkeyManager Instance { get; private set; }
    public int savedMonkeys = 0;
    public int usableMonkeys = 0;
    private void Awake()
    {
        Instance = this;
    }

}
