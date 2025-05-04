using Godot;
using System;

public partial class Bebemon: Evomon
{
	public override void _Ready(){
		level = 1;
		evo_cond = 6;
		exp_limit = 5;
		hp = 30;
		body_parts = "head";
		GD.Print(level, hp, body_parts, evoCondReached());
	}
	public override void _Process(double delta){
		evolve();
		levelUp();
	}
	public bool evoCondReached(){
		return exp >= exp_limit;
	}
	public void evolve(){
		if(evoCondReached())
			GD.Print("AAAAAAAAAA\n");
	}
	public void levelUp(){
		if(exp >= exp_limit){
			level += 1;
			exp_limit *= 2;
			exp = 0;
		}
	}

}
