## AMazze
# A prototype mobile game
The objective of the game is to move the glowing spheres from their corners of the level to the opposing corner.

Built as a prototype to help me learn about the nuances of game development.
# Interesting bits
* Proceduraly generated levels:
The mazes in the game are fully procedural, i.e. they are generated when the game is started. As a bonus, having procedural levels lets me customize the game to any aspect ratio programatically, including tablets and phones.
The challenging bit was setting the camera at the right distance to capture the entire maze.
* Fully dynamic Lighting:
All the lights used in the game are dynamic and this adds to the complexity of the game as the player has to discover and retain parts of the maze in their head.
* Inputs and Collisions:
The inputs are through the accelerometer present in the device. The spheres are also scripted to be collision sensitive and contact between the two spheres results in a Game Over.
* Modeling:
All the assets used in the game aside from the maze were either modeled in Blender or made in Photoshop by me.

