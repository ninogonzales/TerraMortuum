using UnityEngine;

namespace CompleteProject
{
    public class EnemyManager : MonoBehaviour
    {
        public GameObject enemy;                // The enemy prefab to be spawned.
        public float spawnTime = 5f;            // How long between each spawn.
		public Transform[] spawnPoints = new Transform[5];         // An array of the spawn points this enemy can spawn from.


        void Start ()
        {
            // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
            InvokeRepeating ("Spawn", 0f, spawnTime);
        }


        void Spawn ()
        {
			try{
            // Find a random index between zero and one less than the number of spawn points.
			int spawnPointIndex = Random.Range (0, spawnPoints.Length);

            // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
            Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
			}
			catch (System.IndexOutOfRangeException ex){
				Debug.Log ("Exception happened");
			}
        }
    }
}