import json
import os 

DIR_PATH = os.path.dirname(os.path.realpath(__file__))
CARD_STRUCTURE = {
    "code": "",
    "revision" : "", # these are stephen's internal version numbers as he appends to the end of the code. 
    "name": "",
    "subtypes": [],
    "flavortext": "",
    "war" : False, # specify if this is a war card - needs to be displayed differently 
    "warconditions" : {
        "forward" : { "resource"  : "might", "amount" : 1}, 
        "win" : { 
            "description" : "", 
            "gain" : [] #list of cards. if more than 1, equal probaility of either. Can introduce weighted probability in the future  
        },
        "lose" : {
            "description" : "",
            "gain" : [] #list of cards 
        } 
    },
    "fusion": "", # the codename of the card to replace this 
    "cost": [
        {
            "resource": "food",
            "amount": 0
        },
        {
            "resource": "stability",
            "amount": 0
        },
        {
            "resource": "might",
            "amount": 0
        },
        {
            "resource": "influence",
            "amount": 0
        }, 
        {
            "resource": "tradegoods",
            "amount": 0
        }
    ],
    "actions": [
        { 
            "name" : "", 
            "description": ["", "", ""]
        }
    ],
    "effects": {
        "timer": 0, 
        "endgame" : False, # implies game lost if effects come in place. 
        "return": False, # objective card to be discarded
        "description": "", # to be displayed on the card 
        "gain" : ["C1", "C1"],  # list card codes to be displayed 
        "lose": [] # resources; same format as cost above
    }
}




'''
1. Read file with name of cards 
2. use code to determine type (C for Action, O for Objective, and M for milestone)
3. Create a JSON file for each - File name should be CARDCODE__CARD_NAME
'''

def WriteJSON(filename):

    cards_directory = DIR_PATH + "/cards"
    action_directory = cards_directory + "/Actions"
    milestone_directory = cards_directory + "/Milestones"
    objectives_directory = cards_directory + "/Objectives"

    if not os.path.exists(cards_directory):
        os.makedirs(cards_directory)

    if filename[0] == "C":
        if not os.path.exists(action_directory):
            os.makedirs(action_directory)
        json_file = open(action_directory + "/" + filename, "w")
    elif filename[0] == "M": 
        if not os.path.exists(milestone_directory):
            os.makedirs(milestone_directory)
        json_file = open(milestone_directory + "/" + filename, "w")
    elif filename[0] == "O": 
        if not os.path.exists(objectives_directory):
            os.makedirs(objectives_directory)
        json_file = open(objectives_directory + "/" + filename, "w")
    else:
        json_file = open(cards_directory + "/" + filename, "w")

    json.dump(CARD_STRUCTURE, json_file, indent=4)
    json_file.close()

def Main():
    global CARD_STRUCTURE

    cards_list = open("cards.txt")

    for line in cards_list: 
        line_split = line.strip().split(" - ")
        CARD_STRUCTURE["code"] = line_split[0].strip()
        CARD_STRUCTURE["name"] = line_split[1].strip()

        filename = line_split[0].strip() + "__" + line_split[1].strip().replace("'", "").replace(" ", "_") + ".json"
        WriteJSON(filename)

    cards_list.close()



Main()
    

