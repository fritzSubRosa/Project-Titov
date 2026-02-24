global.card_definitions = {};
//Fixed and Any Definitions


//Action Cards
show_debug_message("CARD LOADER STARTED");


//making the Header
var _action_card_ds = load_csv("TJT Card Importation - Sheet1.csv");
var header_map = {};

for (var _col = 0; _col < ds_grid_width(_action_card_ds); _col++)
{
	
	var header = string_trim(ds_grid_get(_action_card_ds,_col,0));
	variable_struct_set(header_map,header,_col);
	
}

show_debug_message("The headers are : " + (json_stringify(header_map)));



//da loooooop
for (var _row = 1; _row<ds_grid_height(_action_card_ds); _row++)
{
	var fixed = array_create(RESOURCE.COUNT, 0);
	var any_cost = 0;
	if (variable_struct_exists(header_map, "ANY"))

	{
		any_cost = real (
			ds_grid_get(
				_action_card_ds,
				variable_struct_get(header_map,"ANY"),
				_row
				)
		)
	}
	
	// Get fixed costs
	for(var i = 0; i < RESOURCE.COUNT; i++)
		{
		var resource_name = global.RESOURCE_NAMES[i];
	
		if (variable_struct_exists(header_map, resource_name))
			{
			var col = variable_struct_get(header_map, resource_name);
			fixed[i] = real(ds_grid_get(_action_card_ds, col, _row));
			}
	
		}
		
	var cardTest = {};
		cardTest.id = ds_grid_get(_action_card_ds,variable_struct_get(header_map, "ID"),_row);
		cardTest.title = ds_grid_get(_action_card_ds,variable_struct_get(header_map, "TITLE"),_row);
		cardTest.subtype = ds_grid_get(_action_card_ds,variable_struct_get(header_map, "SUBTYPE"),_row);
		cardTest.cost = {
			fixed: fixed,
			any: any_cost
		};
		
	variable_struct_set(global.card_definitions, cardTest.id, cardTest);
}

show_debug_message(json_stringify(global.card_definitions));