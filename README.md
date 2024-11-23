# Video Game Programming Assignment - week 3 part A by Elyasaf


## Features Implemented

### **Part A: Core Features**
1. **Score Display**
   - The player's score is displayed at a fixed position on the screen.

2. **Health Points (HP) System**
   - The player starts the game with three health points.
   - Each collision with an enemy reduces the player’s HP by one.
   - When the player's HP reaches zero, the spaceship is destroyed.
   - Health pickups occasionally spawn on the screen. When collected, they restore one HP.
   - A visual UI element shows the player’s remaining HP in a clear and intuitive way.

3. **Enemy Types and Scoring**
   - Two types of enemies:
     - **Slow Enemy:** Awards 1 point when destroyed.
     - **Fast Enemy:** Awards 2 points when destroyed.
   - The implementation uses generalizable and extensible code, making it easy to add more enemy types with different behaviors and point values.

---

### **Part B: Original Features**
1. **Point-Based Level Progression**
   - Instead of moving to the next level upon reaching a specific location, the player progresses to the next level by earning a required number of points.

2. **Screen Boundaries**
   - The player’s spaceship cannot leave the screen boundaries, ensuring the gameplay stays within visible and interactive areas.

---

## How to Play

1. **Basic Controls**
   - Use keyboard or WASD inputs to control the spaceship.
   - Collect health pickups to restore lost health.

2. **Scoring**
   - Destroy slow and fast enemies to earn points.
   - Reach the target score to advance to the next level.

3. **Survival**
   - Avoid enemy collisions to conserve health points.
   - Collect health pickups to increase survival time.

---


## [Link to itch.io](https://elyasafko.itch.io/week3-part-a-elyasaf)
