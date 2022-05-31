# Apple Picker

**Unity Arcade Game** - Catch falling apples with a moving basket before losing all 3 lives.

## 🎮 Gameplay
<img src="main.png" alt="Main View">

- **Apple Tree** moves left/right, drops apples at increasing speed

- **3 Baskets** (lives) - catch apples to score 100 points each

- **Progressive Difficulty** - faster drops + tree speed after 5 apples

- **Game Over** when all baskets lost or apples hit ground

## 📱 Controls
- **Mouse X-axis** - move basket left/right
- **Physics-based** apple falls & collisions

## 🛠️ Tech Stack
```
• Unity 2D (Rigidbody2D, Colliders)
• C# Scripts (ApplePicker, AppleTree, Basket)
• UI Text (Score/HighScore system)
• PlayerPrefs (persistent high score)
• Scene Management
```

## 🎯 Features Implemented
- Dynamic basket spawning (3 lives system)
- Progressive difficulty (speed ramps every 5 apples)
- High score persistence with `PlayerPrefs`
- Collision-based scoring (+100 per apple)
- Auto tree movement with random direction changes
- End scene with final score display

## 📊 Game Loop
```
AppleTree drops → Basket catches → Score +100 → 
5 apples = speed up → Lose life on miss → 
0 baskets = Game Over → HighScore saved
```

Classic Unity college project demonstrating object pooling, collision detection, and progressive difficulty mechanics.