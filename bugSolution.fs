let mutable x = 0
let addOne (x:byref<int>) = x <- x + 1
addOne &x
printf "%d" x
//Output: 1

//Alternative solution:

let mutable x = 0
let addOne x = x + 1
let y = addOne x
printf "%d %d" x y
//Output: 0 1