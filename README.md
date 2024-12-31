# F# Mutable Variable Unexpected Behavior
This example demonstrates a common misconception when working with mutable variables in F#.  The `addOne` function does not modify the original mutable variable `x`, but instead creates a new value. The expected behavior of changing x is not observed. This is because the F# compiler treats `x` as a value passed to `addOne`. This repo shows the error and the correct solution using the `&` operator or changing the function to return a value. 

## Bug
The code in `bug.fs` shows the incorrect implementation. The `addOne` function doesn't modify the original `x` value, leading to an unexpected output.