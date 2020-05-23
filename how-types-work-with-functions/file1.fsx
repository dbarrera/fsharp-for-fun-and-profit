let intToString x = sprintf "x is %i" x // format int to string
let stringToInt x = System.Int32.Parse(x)

let intToFloat x = float x // "float" fn. converts ints to floats
let intToBool x = (x = 2)  // true if x equals 2
let stringToString x = x + " world"

let stringLength x = x.Length
