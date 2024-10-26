using UnityEngine;

public class DetectCollisions : MonoBehaviour {
    void OnTriggerEnter(Collider other) {
        other.gameObject.SetActive(false);
        AnimalBehavior animalScript = gameObject.GetComponent<AnimalBehavior>();
        animalScript?.FoodResponse();
        Destroy(gameObject);
    }
}