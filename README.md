# VR Flight

A VR Minigame you fly around a low-res medieval scenery collecting floating boxes for points.

## Contributing
Anyone can contribute, but please try to add things in our <a href="#What's-Next">What's next section</a>

## Inspiration
We also wanted to build something cool with Unity 3D and VR that was simplistic, intuitive to play, but also fun. We decided to create a game that showcases flight - and the feeling of weightlessness.

## What it does
The user flies around the scenery using his head position to navigate (they move towards the place they is staring at). Floating collectible yellow boxes can be seen throughout the scene, as well as a score counter that increments for every box collected. The boxes respawn at random time intervals after their collection for infinite gameplay.

## How we built it
We used Unity 3D version 5.5, with a Google Cardboard Headset and a Samsung Note S4.

We modeled our flight using a logistic growth curve. We based our model on one key idea - the relationship between desired speed and current height are proportional. However, we realized that a direct linear relationship felt too jerky and too fast at times - for that reason, we used a logistic growth curve.

## Challenges we ran into
The "player" would fly through the terrain as if it did not exist during the initial phases of development. We spent a generous amount of time figuring out how to perform this collision detection with the terrain.

## Accomplishments that we're proud of
The game is fairly intuitive to play, and quite captivating due to the immersive VR experience. The speed of the player is also calculated using a function that results as the solution to a logistic growth differential equation.

## What we learned
We earned significant Unity3D development skills, such as keeping track of time to spawn elements, collision detection, and other neat stuff. We also learned that VR is quite attractive in terms of game development, and that even the simplest of games can be quite captivating.

## What's Next
* We'd like to create a more immersive environment - and add caves and different places to explore
* We're hoping to integrate a Leap Motion sensor and other ways to interact with the virtual environment.

## Built With
* Unity
* C#
