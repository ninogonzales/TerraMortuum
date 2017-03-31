using UnityEngine;

namespace CompleteProject
{
    public class EnemyManager : MonoBehaviour
    {
        public GameObject enemy;                // The enemy prefab to be spawned.
        public float spawnTime = 8;            // How long between each spawn.
		public Transform[] spawnPoints = new Transform[8];         // An array of the spawn points this enemy can spawn from.


		void Start ()
		{
			// Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
			InvokeRepeating ("Spawn", 8, spawnTime);
			InvokeRepeating("subIncrease_Spawn_Speed", 60, 60);
		}

		void subIncrease_Spawn_Speed() {

			float fSpeed_Increase = 1f;

			//Cancel the current subSpawn_Object Invoke.
			CancelInvoke("Spawn");

			//This will limit the spawn speed to a min of 1.
			if ((spawnTime - fSpeed_Increase) < 1) {
				spawnTime = 1f;
			} else {
				spawnTime = spawnTime - fSpeed_Increase;
			}

			InvokeRepeating("Spawn", 0, spawnTime);
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