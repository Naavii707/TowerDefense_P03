using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Scriptable Objects/EnemyData")]
public class EnemyData : ScriptableObject
{
public float attackRange = 1f;
    public float AttackDamage = 10f;
    public float runSpeed = 2f;
    public float attackDuration = 1f;
    public float attackCooldown = 1f;
    public string dieSoundName;
    public string attackSoundName = "ZAttack";
    public string PrimaryTargetTag = "Tower";
    public string runAnimationName = "zombieRunning";
    public string attackAnimationName = "ZombieAttack";
    public string dieAnimationName = "Zombie Death";
    public string winAnimationName = "ZWIn";
}
