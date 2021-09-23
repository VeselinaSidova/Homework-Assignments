function solve(fruitName, weight, pricePerKg) {
    let weightInKG = weight / 1000; 
    let price = weightInKG * pricePerKg;
    console.log(`I need $${price.toFixed(2)} to buy ${weightInKG.toFixed(2)} kilograms ${fruitName}.`)
}

solve('orange', 2500, 1.80);
solve('apple', 1563, 2.35);