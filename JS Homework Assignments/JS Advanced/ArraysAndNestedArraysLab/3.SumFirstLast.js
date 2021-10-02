function solve(input) {
    if (input.length > 1) {
        console.log(Number(input.shift()) + Number(input.pop()));  
    } else {
        console.log(Number(input));
    }  
}

solve(['20', '30', '40']);
solve([15]);