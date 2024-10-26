using UnityEngine;

public class Fox : AnimalBehavior {
    private float runSpeed = 5.0f;

    // Update is called once per frame
    void Update() {
        Move(runSpeed);
    }

    public override void FoodResponse() {
        Debug.Log("Yummy apples!");
    }
}