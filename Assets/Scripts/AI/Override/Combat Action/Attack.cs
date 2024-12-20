using FarmSystem;
using UnityEngine;

[CreateAssetMenu(fileName = "Behavior Data", menuName = "Farm System/Behavior/Attack Action")]
public class Attack : CombatAction
{
    public override void Execute(CharacterAI agent)
    {
        base.Execute(agent);
    }
    public override bool IsFinish(CharacterAI agent)
    {
        return base.IsFinish(agent);
    }
}