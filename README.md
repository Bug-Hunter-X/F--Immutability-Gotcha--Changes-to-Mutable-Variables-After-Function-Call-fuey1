# F# Immutability Demonstration

This example highlights a common misconception when working with mutable variables in F#.  While F# supports mutable variables, their behavior within functions can be unexpected for programmers coming from imperative backgrounds.  The core issue demonstrated is that functions in F# operate on *copies* of their arguments, not directly on the original variables.  Therefore, changes to mutable variables *after* a function call have no impact on the function's return value.

## How to reproduce the bug

1. Compile and run `bug.fs`.
2. Observe the output:  You will see that `z` remains unchanged after `x` is modified.

## Solution (bugSolution.fs)

The solution demonstrates how to achieve the desired behavior if you need a function to operate on the mutable variables directly and reflect changes after the initial function call.