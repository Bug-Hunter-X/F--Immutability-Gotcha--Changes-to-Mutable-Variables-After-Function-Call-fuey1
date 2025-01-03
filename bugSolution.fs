let mutable x = 10
let mutable y = 20

let add x y =  
    let mutable sum = x + y
    (fun () -> sum) // Return a function to get updated sum. 

let updateAndGetValue = add x y
let z = updateAndGetValue() // Get the initial sum
printf "%d\n" z

x <- 15
let z2 = updateAndGetValue()// Get the updated sum
printf "%d\n" z2