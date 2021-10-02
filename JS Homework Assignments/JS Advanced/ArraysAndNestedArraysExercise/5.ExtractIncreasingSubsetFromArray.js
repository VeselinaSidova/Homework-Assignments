function solve(input) {
    let result = [];
    let largestNumber = Number.MIN_SAFE_INTEGER;

    // with reduce()

    input.reduce((acc, curr) => {
        if (curr >= largestNumber) {
            largestNumber = curr;
            acc.push(curr);
        }
        return acc;
    }, result);
    
    
    // with filter()

    // let result = input.filter(x => {
    //     if (x >= largestNumber) {
    //         largestNumber = x;
    //         return true;
    //     }
    //     return false;
    // })

    return result;
}

solve([1, 
    3, 
    8, 
    4, 
    10, 
    12, 
    3, 
    2, 
    24]);