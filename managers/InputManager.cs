using Microsoft.Xna.Framework.Input;

namespace dodge_em_all;

public class InputManager {
    private KeyboardState currentState;
    private KeyboardState previousState;

    // Singleton class to avoid multiple instantiation
    private static InputManager inputManager;
    public static InputManager Instance {
        get {
            if(inputManager == null) {
                inputManager = new InputManager();
            }
            return inputManager;
        }
    }

    private InputManager() {
        this.previousState = this.currentState;
        this.currentState = Keyboard.GetState();
    }

    public void Update() {
        this.previousState = this.currentState;
        this.currentState = Keyboard.GetState();
    }

    public bool IsKeyHeld(Keys key) {
        return currentState.IsKeyDown(key);
    }
}