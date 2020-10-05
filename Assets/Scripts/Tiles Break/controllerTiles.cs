using UnityEngine;

public class controllerTiles : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

            if(hit.collider != null)
            {
                if (hit.collider.CompareTag("Tiles"))
                {
                    HighScore_TilesBreak.score += 10;
                    Destroy(hit.collider.gameObject);
                }
            }

        }
    }

    
}
