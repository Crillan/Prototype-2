using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour {
    private float topBound = 30;
    private float lowerBound = -10;
    [SerializeField]
    private GameManager gameManager;

    // Update is called once per frame
    void Update() {
        if (transform.position.z > topBound) {
            gameObject.SetActive(false);
        } else if (transform.position.z < lowerBound) {
            if (!GameManager.Instance.GameOver) {
                GameManager.Instance.GameOver = true;
            }
            Destroy(gameObject);
        }
    }
}