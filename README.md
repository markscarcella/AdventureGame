# AdventureGame

This repository has 2 branches - master and tempalte. The tempalte branch has code missing, and is to be used for the workshops.

## RPG style adventure game

Firstly play the ExampleGame scene to get an idea of the kind of game I was going for. It is more complex that need be, but also has room to be extended easily.

After playing duplicate the template scene and open

### 0. What's in the scene?
- MainCamera - Don't change this, it's set up for isomorphic game
- GameManager - Controls the game. We won't be changing much in here
- UI - The game ui such as health, power, inventory. We won't change much of the GameUI script (UIs are boring)
- Player - the player! Lots of code here to play with
- Canvases - This object holds the menu, win, and lose canvases. Play with these towards the end
- OverworldObjects - An object to hold all the trees etc of the world (for a neater heirarchy)
- EventSystem + Directional List - The usual stuff

### 1. Follow player with camera
- Add the followPlayer script to the camera
- Add the code to follow the player
- A good distance is 10 and a good size is 1.5
- Push play and you should see the player

### 2. Gettin the player moving
- Add Rigidbody and box collider
- Add playerMove to the player and open the script.
- Fill in the code in the MovePlayer() function
- Add MovePlayer() to the update loop
- Add the player to the GameManager in the editor

### 3. Add objects into world
- Can't tell you're moving! Open MagicaVoxel and make trees, houses, rocks, etc
- While you're here, make your own player too and add it to the game (and add playerMove script)
- Make some characters to give you quests

### 4. Add a Quest
- Add a quest character into the scene
- Give the character a box collider and edit the collider to have a large area in front and set to trigger - when player moves into the trigger it will activate
- Add the alertCanvas prefab as a child to the character and position above head (or wherever you want!). You can change colour/font/symbol etc
- Add Quest script to the character
- Drag alert canvas to field in editor
- Open script and add code to trigger enter/exit functions
- Check alert shows up when you get close
- Add code to trigger stay function 
- The Dialogues (instructions and complete) are the pages of text that will pop up.
- Add at least 1 page for each with some text (can be test text for now)
- Check it works
- Now we can think about our story more. Maybe storyboard?

### 5. Add a Quest Item
- Add a collectible model to the scene (eg a gem, key, power orb, etc)
- Add box collider and edit to cover model
- Add QuestItem.cs script and fill in code in OnTriggerEnter()
- Open photoshop or PikoPixel and draw an image for the inventory
- Once complete, add the associated quest to the item. This means now that if you collect the item and go back and speak to the quest giver, the quest will become complete.
- Test picking up objects and make sure they appear in the inventory

### 6. Add magic meter/score/respect/etc
- This isn't necessary, but adds to the gameplay
- In the Quest.cs script, you can add to a score or a slider on the UI for your quest prize, eg: 
* Add money variable to the GameManager and link it to a text object on the UI. Finishing a quest adds money
* Add power to the magic meter and increase slider on screen

### 7. Make game polished
- At this point I think there is enough complexity that a good story can be told by accepting quests, collecting items, and then bringing them back.
- Open GameManager.cs and add the RestartGame() and EndGame() scripts
- Edit the Menu/Win/Lose canvases to be your game name, instructions, author, etc
- Add background music to the AudioSource on the GameManager
