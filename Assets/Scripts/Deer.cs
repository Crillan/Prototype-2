using UnityEngine;

public class Deer : AnimalBehavior {
    private float runSpeed = 15.0f;

    // Update is called once per frame
    void Update() {
        Move(runSpeed);
    }

    public override void FoodResponse() {
        Debug.Log("Mmmm, apples are my favorite!");
    }
}