let mutable x = 10
let mutable y = 20

let add x y = x + y

let z = add x y
printf "%d\n" z

x <- 15 // Modify x after calling add

// The value of z does not change even if x is updated after it was calculated. 
//The function add takes immutable copies of x and y, so changes to x do not affect z.
printf "%d\n" z