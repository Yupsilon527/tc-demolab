
using UnityEngine;
using UnityEngine.Events;
using static VariableManager;

public class VariableReactionChange : MonoBehaviour
{
    public VariableManager.Condition[] Conditions;
    public UnityEvent Action;
    private void Start()
    {
        if (LevelController.main != null)
            LevelController.main.RegisterReactor(this);
    }
}
