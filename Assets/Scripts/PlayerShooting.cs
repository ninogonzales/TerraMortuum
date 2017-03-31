using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public int damagePerShot = 20;
    public float timeBetweenBullets = 0.15f;
    public float range = 300f;
    public int magazineSize = 12;

    public int bulletInMagazine;

    float timer;
    Ray shootRay = new Ray();
    RaycastHit shootHit;
    int shootableMask;
    ParticleSystem gunParticles;
    LineRenderer gunLine;
    AudioSource gunAudio;
    Light gunLight;
    float effectsDisplayTime = 0.2f;
    Animation anim;
    Animation reload;
  
    void Awake ()
    {
        shootableMask = LayerMask.GetMask ("Shootable");
        gunParticles = GetComponent<ParticleSystem> ();
        gunLine = GetComponent <LineRenderer> ();
        gunAudio = GetComponent<AudioSource> ();
        gunLight = GetComponent<Light> ();
        anim = GetComponentInParent<Animation>();
        reload = GetComponent<Animation>();
        bulletInMagazine = magazineSize;
    }


    void Update ()
    {
        timer += Time.deltaTime;

		if(Input.GetButton ("Fire1") && timer >= timeBetweenBullets && Time.timeScale != 0)
        {
            Shoot ();
        }

        if(timer >= timeBetweenBullets * effectsDisplayTime)
        {
            DisableEffects ();
        }

        if (bulletInMagazine == 0)
        {
            reload.Play("reload");
            bulletInMagazine = magazineSize;     
        }
    }


    public void DisableEffects ()
    {
        gunLine.enabled = false;
        gunLight.enabled = false;
    }


    void Shoot()
    {
        if (!reload.IsPlaying("reload"))
        {
            timer = 0f;

            anim.Play("fire");

            gunAudio.Play();

            gunLight.enabled = true;

            gunParticles.Stop();
            gunParticles.Play();

            gunLine.enabled = true;
            gunLine.SetPosition(0, transform.position);

            shootRay.origin = transform.position;
            shootRay.direction = transform.right;

            bulletInMagazine -= 1;

            if (Physics.Raycast(shootRay, out shootHit, range, shootableMask))
            {
                EnemyHealth enemyHealth = shootHit.collider.GetComponent<EnemyHealth>();
                if (enemyHealth != null)
                {
                    enemyHealth.TakeDamage(damagePerShot, shootHit.point);
                }
                gunLine.SetPosition(0, shootHit.point * range);
            }
            else
            {
                gunLine.SetPosition(0, shootRay.origin + shootRay.direction * range);
            }
        }
    }
}
