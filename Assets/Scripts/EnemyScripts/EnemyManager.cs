using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    int numberOfEnemies = 5;
    [SerializeField] ObjectiveUI objectiveUI;

    public void EnemyDied()
    {
        numberOfEnemies--;
        if (numberOfEnemies <= 0)
        {
            objectiveUI.Objective1Completed();
        }
    }
}
