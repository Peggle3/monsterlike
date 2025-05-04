class_name monsterClass 
extends Sprite2D


var hp : int
var body_parts : String
var max_moves : int
var speed : int
var strength : int
var intelligence : int
var sp : int
var defence : int




func get_health():
	return hp

func set_healt(new_hp):
	hp = new_hp
