using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Manager manager;
    private void OnTriggerEnter(Collider other)
    {
        manager.LevelCompleted();
    }
}
