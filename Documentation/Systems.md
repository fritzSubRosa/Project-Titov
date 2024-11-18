# Systems 

This is about how to implement the various systems in the game - as found in the [Readme](./README.MD)

- The **phases** of the games should be implemented as a statemachine 
- The **resources** should go in a game manager 
- The milestones are the main story line -- a list perhaps? 
- The objectives - are the sequential or random? 
- The **Hand** and the **Agenda** are going to be containers like lists, and they will be anchored to the screen in their respective places. 
- 
- We will need **a save and load mechanism** 


- I have added an `enum` for Game Phase where
	- 0 is Tutorial (this will be unimplemented for now) 
	- 1 is Action
	- 2 is Crisis
	- 3 is Resolve 
- As I visualize this, this will form the basis of a state machine 

--- 
