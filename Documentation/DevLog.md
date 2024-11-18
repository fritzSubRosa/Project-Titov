# Dev Logs 
(Most other files are GitHub MD native - they are written to work with the GitHub flavor of MD files.  this file is Obsidian native - some things like links and related files (canvases) may/will not work with GitHub.)

## Index
1. [[Questions]]
2. [[State]]
3. [[Systems]]
4. [[README]]
5. [Figma Files](https://www.figma.com/files/team/1361752131146014945/project/291665647?fuid=1112098330417764190)

## 18th November 
Might be forgetting some stuff. That's a wrap for now. (5:25 AM)

#### So Far  
1. I've gone through the system documentation, I understand the mechanics and I'm starting to think through their implementation.
	1. As I went through it I also rewrote it here in here so we have the docs in the repo. This helped me understand the system while also 
2. I've setup a card prefab in the system 
3. I have initialized a game manager that will track game state, a centralized collection for all cards, and the subsequent decks and piles. 
4. I will need a Card type in the system; One C# object that defines a type and then another MonoBehavior script for the prefab. 
5. We have a prelim card structure in JSON format, and a python generator for all the cards.


#### Up next: 
1. I need to speak with Stephen to finalize the JSON structure of the cards
	1. Once finalized, we need to write the card details in each JSON 
	2. Once these are written, I will load them up through a loader script in unity
		1. All cards will be loaded at once in a central card array. I will implement this once the card JSON structure is finalized. 
		2. Then I will write a Card Class which will have all those attributes and a MonoBehaviour script attached to the card prefab to respond to events and stuff.  
		3. The Card code will be the unique identifier and all other decks will reference or instantiate a card through that identifier. But the list of discarded decks and all will only be arrays of strings or even integers (if I drop the C/O/M), where each element will be a card's identifier. 
		4. This makes this easy on the resources and also easy to save state.     
2. I also need art assets for the symbols and imagery on cards.   
3. I need a finalized face of the game screen. I have left [[GameScreen_LoFi.canvas|a basic low-fidelity prototype]] of the game on Stephen's Desk and if he is in today, we will discuss it. a PNG of this is [here](./Assets/GameScreen_LoFi.png) 
4. Once the cards are in, I can write systems that do things with these cards. 
5. I also need to define game state better - need to speak with Stephen more to flesh out the game state. 