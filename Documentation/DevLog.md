# Dev Logs 
(Most other files are GitHub MD native - they are written to work with the GitHub flavor of MD files.  this file is Obsidian native - some things like links and related files (canvases) may/will not work with GitHub.)

## Index
1. [[Questions]]
2. [[State]]
3. [[Systems]]
4. [[README]]
5. [Figma Files](https://www.figma.com/files/team/1361752131146014945/project/291665647?fuid=1112098330417764190)


## 4th June 
- Playing a milestone, you either pay a cost for it or meet a condition for it. Im making this distinct because costs are directly resources but conditions can be different. 
- I've removed the previous milestones that were implementing a prefab based, complicated inheritance system i think that is premature optimization. 
- I have reimplemented all the milestone cards as independent cards. They have a structure but for now I will probably treat them as independent Prefabs 
- From the fourth milestone I have got a battle meter. I have implemented a battlemeter handler script and made the 6 step battlemeter into a class. 
- This battlemeter is referenced in the card's specific script and then we can move it forward or backward. 
- The script is generic, but the meter prefab is a six step battlemeter.  I see some objective cards have a 4 step battlemeter as well. So I will create an alternate prefab for that later, which will have 4 steps. But the functioning principle will remain the same, 
- Speaking of components, I have made the resources in the resources UI section into prefabs. All of them belong to the same prefab and then I change their name and icon. 
- Next up: I need to implement a system to resolve the effects of all cards, implement physical versions of all the objective cards and action cards. 

## 29th November 
- Every card in the game triggers a change on the game state. 
- The game state consists of: 
	1. Resources 
	2. Current Milestone 
	3. Current Hand 
	4. Current Agenda 
	5. Current Objectives Deck 
	6. Current Action Deck 
	7. State of timers 
- Each action card can then be associated to a function in an action cards manager. Or they can have their own thing
- Where do I start? 


- All card actions operate on the game state. So the game state needs to be accessible to each card entity. 
- All decks will contain cards objects. 
- To model a card, let us ask the question, what is a card? What is the barebones nature of the card? 
	- There is a name, a flavor text, a code, and card type
	- Then the card has actions
	- These actions have costs
	- And then the action has consequences which operate on the state (resources and decks)

- Every card is doing its own thing and Im really struggling to generalize these. The visuals are different for everyone so I cant programmatically generate them yet. 
- The solution I can think of now is to just create a prefab of every individual card, and treat it essentially as a different mechanic. 
- Playing a card impacts the game state, it changes the resources or it changes the state of the deck 
- So if I do make all the cards as prefabs, how do I keep track of them, do I just make a prefab array and link it up in the editor? Not sure how to go about tracking the deck, then. 

- What I can do is create a larger array of all cards, an array that contains links to all prefabs. This becomes my main array  
- Then I create arrays that reference those cards by card code. 

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