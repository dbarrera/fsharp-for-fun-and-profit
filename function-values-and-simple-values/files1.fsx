let add1 x =  x + 1
let plus1 = add1

add1 5
plus1 5

let c = fun() -> 5
// or
let c'() = 5

let if' b t f = if b then t else f

let ``begin`` = "begin"

let ``is first time customer?`` = true
let ``add gift to order`` = ()
if ``is first time customer?`` then ``add gift to order``

// Unit test
let [<Test>] ``When input is 2 then expect square is 4`` = // code here

// BDD clause
let [<Given>] ``I have (.*) N products in my cart`` (n:int) = // code here
