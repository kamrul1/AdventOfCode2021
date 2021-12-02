--- Day 2: Dive! ---

Calculate horizontal position and depth, multiple them together for the puzzle answer.

Sample, code

forward 5
down 5
forward 8
up 3
down 8
forward 2

After following these instructions, you would have a horizontal position of 15 and a depth of 10. 
(Multiplying these together produces 150.)

see SubmarineMovementFile.txt for puzzle input.


--- Part Two ---

All change:

In addition to horizontal position and depth, you'll also need to track a third value, aim, which also starts at 0.

down X increases your aim by X units.
up X decreases your aim by X units.
forward X does two things:
It increases your horizontal position by X units.
It increases your depth by your aim multiplied by X.

After following these new instructions, you would have a horizontal position of 15 and a depth of 60. 
(Multiplying these produces 900.)

