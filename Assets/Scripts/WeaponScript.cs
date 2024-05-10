using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject bulletPrefab; // Prefab of the bullet
    public Transform firePoint; // Point where the bullet will be instantiated
    public float bulletForce = 20f; // Force applied to the bullet when fired

    // Update is called once per frame
    void Update()
    {
        // Check if the player presses the fire button (e.g., left mouse button)
        if (Input.GetButtonDown("Fire1"))
        {
            Fire(); // Call the Fire method
        }
    }

    void Fire()
    {
        // Instantiate a bullet at the fire point position and rotation
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        
        // Get the Rigidbody2D component of the bullet
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        // Apply force to the bullet in the direction of the fire point's forward vector
        rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
    }
}
