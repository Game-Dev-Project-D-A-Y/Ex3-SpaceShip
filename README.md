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



### 2 - A flat world with invisible boundaries
To do this we just had to do one simple change from the previous scene (1-A):
We've maid the mesh Renderer invisbile (by ticking the box right near the component's name)
now you can't see the shape of the border but it functionality works.

### 3 - A round world. When the player reaches one side of the world he appears on the other side.
First thing we've clicked on the border to avoid them on this task.
We added a script named "RoundWorld". In this script we got the position of every border using the orthographicSize combined with the camera.aspect function..By using the Input.GetAxis function we
know in which direction the spaceship is flying from.
With a few simple "if" statements we covered all of the options (4 options one for each direction).


## C - Implement Core Game Loop
