#pragma strict

private var player : Transform;               // Reference to the player's position.
private var playerHealth : PlayerHealth;      // Reference to the player's health.
private var enemyHealth : Zombie;        // Reference to this enemy's health.
private var nav : UnityEngine.AI.NavMeshAgent;               // Reference to the nav mesh agent.

function Awake ()
{
    // Set up the references.
    player = GameObject.FindGameObjectWithTag ("Player").transform;
    playerHealth = player.GetComponent (PlayerHealth);
    enemyHealth = GetComponent (Zombie);
    nav = GetComponent (UnityEngine.AI.NavMeshAgent);
}

function Update ()
{
    // If the enemy and the player have health left...
    if(enemyHealth.health > 0 && playerHealth.health > 0)
    {
        // ... set the destination of the nav mesh agent to the player.
        nav.SetDestination (player.position);
    }
        // Otherwise...
    else
    {
        // ... disable the nav mesh agent.
        nav.enabled = false;
    }
}