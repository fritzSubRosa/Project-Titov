## Todo:
1. Look at Stephen's figma designs and take it from there. 

## Notes:
1. Some cards will need to be changed to become systems instead of cards.
2. Currently the cards are designed individually, but they need a structure. 
3. There is the UI element card and there is the card specific script. This script inherits from the `Card` base class which implements some common functionality 
4. The look of the card solely depends on the UI elements and has very little to do with the script 
5. Unfortunately, each card will have to be different from each other. 
6. The card will then have buttons on it and it is these buttons that are then related to the methods inside the scripts.
7. These methods operate on the game state, so it needs to be able to access game state. 
8. Instead of finding the gameobjects, I am going to keep an insteance reference static. 
9. If not prefabs, then what? Currently all these cards are (from a structural POV) so different that they might as well be different prefabs. But that is over 100 prefabs. This is why we need templates for the cards
10. A card is divided into two parts: its structure and its logic. The template wiill give the structure, and the script will give the logic. 


---
## 2025-07-07
Work session with Stephen 

Agenda:
1. We come to a mutual agreement on what we're building 
	1. Act 1
2. We straighten out the designs for the cards, the systems, and the interface. 
	1. This includes the interactions as well. 
3. We discuss the scope for the next 26 weeks.
4. I start implementing things by the end. 

- Play session on Wednesday 5:30PM to 8:45PM 

Finding the UI affordances to make the game systems legible. 
Exploring Design spaces that we couldn't in the physical 
Dynamic card gen, tracking player behaviour 


### Interactions 
1. Action Cards are dragged into the main area where the buttons show up. 
	1. Confirmation of play 
	2. Confirmation of resource
	3. Alternative and Additional options etc. 
2. Objective and Milestones need to have buttons. 
	1. Timers may or may not be on the card itself, they can be placed around it. 
3. Systems:
	1. Card Creation (creating from the ether)
	2. Card distribution 
	3. Card resolution
	4. Timers (only exist on milestone and objectives)
	5. War system 
	6. Resource tracking 
	7. Monuments, Provinces, Scouting




## 2024-12-12
I want to build a quick prototype that forms the boiler plate of the entire interaction. I think a good point to start for this is the UI design. On top of that I can start building the systems of the game.

Anchors: https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/UIBasicLayout.html 

