using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject ProjectilePrefab;
    public Transform ProjectileSpawnPoint;
    public void Launch(Vector2 aimDirection)
    {
        // create ball at the gun
        GameObject projectileObject =Instantiate(ProjectilePrefab, ProjectileSpawnPoint.position, Quaternion.identity);
        // start the ball moving
        LaunchProjectile(projectileObject, aimDirection);
    }

    private void LaunchProjectile(GameObject projectileObject, Vector2 aimDirection)
    {
        //Add force to direction
        Rigidbody2D projectileRigidbody = projectileObject.GetComponent<Rigidbody2D>();
        
        projectileRigidbody.AddForce(aimDirection * 5f, ForceMode2D.Impulse);
    }
}
