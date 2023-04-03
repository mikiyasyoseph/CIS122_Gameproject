using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class WeaponShoot : MonoBehaviour
{
   private Camera cam;

   private void Start()
    {
        cam = Camera.main;
    }
   private void Update()
    {
        if(Input.GetKeyDown("f"))
        {
            Shoot();
        }
    }
    private void Shoot()
    {
        Ray ray = cam.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 500))
        {
            Debug.Log(hit.transform.name);
            if(hit.transform.tag == "Enemy")
            {
                var enemyStats = hit.transform.GetComponent<SkeletonStats>();
                var enemyControl = hit.transform.GetComponent<EnemyController>();
                if(enemyStats.Health > 0)
                {
                    enemyControl.playHit();
                }
                enemyStats.TakeDamage(25);
            }
        }
    }
}
