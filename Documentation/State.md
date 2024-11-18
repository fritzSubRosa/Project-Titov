# Game State 

- What is part of the game state? 
	1. Current Game Phase (Action, Crises, Resolve)
	2. State of resources 
	3. State of max resources 
	4. Current hand 
	5. Current agenda 
	6. Current milestone 
	7. State of all timers on each card 
	8. Crises 
	9. Discarded Action Cards  
	10. Discarded Objective Cards 

- Everything in the state of the game needs to be serialized and saved at the end of each resolve cycle automatically. 
- Need a way to reset the state.
	- Define base state - in JSON file? 
	- 