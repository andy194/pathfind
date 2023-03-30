# Oxbury Pathfind

Imagine representing a grid-shaped game map as a 2-dimensional array. Each value of this array is
boolean `true` or `false` representing whether that part of the map is passable (a floor) or blocked
(a wall).

Write a function that takes such a 2-dimensional array `A` and 2 vectors `P` and `Q`, with `0,0` being the top left corner of the map and returns the distance of the shortest path between those points, respecting the walls in the map.

eg. Given the map (where `.` is passable - `true`, and `#` is blocked - `false`)

```
. P . . .
. # # # .
. . . . .
. . Q . .
. . . . .
```

then `pathfind(A, P, Q)` should return `6`.

_Please avoid using libraries to implement the algorithmic side of this challenge, other libraries (such as PHPUnit or Jest for testing) are welcome._

## What to do

1. Clone/Fork this repo or create your own
2. Implement the function described above in any mainstream language you wish
3. Provide unit tests for your submission
4. Fill in the section(s) below

## Comments Section

<!---
Please fill in the sections below after you complete the challenge.
--->

### What I'm Pleased With
It was interesting to investigate the gaming aspects of this, looking into pathfinding is a basic requirement also for some robotics,
didn't understand how it relates to banking applications or financial work, unless you're training AI bots to filter and target stats.

### What I Would Have Done With More Time
Well, I'd have finally I think managed to get it working but I'm not going to say I'd have done it easily.  Whoever set it may have
an interest in game development or a maths background but sadly I have neither!  Even asked my son if he'd come across this as he's
doing A-Level maths and physics at the moment but he'd not seen it either.

Sorry guys, if this is a simple one for you!