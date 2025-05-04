class_name bebemon
extends "res://Scripts/evomon.gd"


func _init() -> void:
	level = 1
	evo_cond = 6
	exp_limit = 5
	hp = 30
	body_parts = "head"
	
	
	print(hp , "\n", body_parts, "\n", evoCondReached())


func _process(delta: float) -> void:
	expLimitReached()
	evolve()

func evolve() -> void:
	if(evoCondReached()):
		print("aaa")

func levelUp() -> void:
	level += 1
	exp_limit *= (stage + 0.5)
	exp = 0

func evoCondReached() -> bool:
	if (evo_cond == level):
		return true
	return false

func expLimitReached() -> void:
	if(exp >= exp_limit):
		levelUp()
