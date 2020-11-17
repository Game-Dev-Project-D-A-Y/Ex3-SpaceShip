# Ex3 - Game Development PREFABS & TRIGGERS

## A - Changing & Improving the lesson's game

### 1 -

### 2 -

### 3 -

### 4 -

### 5 -


## B - Boundries

### 1 - A flat world with visible boundaries
We've created a prefab "border" and we used 4 border objects - each one represents a border of the game (top, bottom, left and right)
Each border has these components: 
* Rigid Body - Control of an object's position through physics simulation.
* Box Colider -The Box Collider is a basic cube-shaped collision primitive.
* Cube (Mesh Filter) - We created a cube with this component. 
* Mesh Renderer - The Mesh Renderer takes the geometry from the Mesh Filter and renders it at the position defined by the object's Transform component.

Our main player the SpaceShip also has the coliderr component and the Unity engine according to the Dynamic physics will identify the colistion and 
maintains the position of the spaceship inside our boundries..
In the KeyboardMover component of the spaceship we've added a RigidBody object which makes the Object go smoothly and not "jump" againts the wall



### 2 -

### 3 -



## C - Implement Core Game Loop
