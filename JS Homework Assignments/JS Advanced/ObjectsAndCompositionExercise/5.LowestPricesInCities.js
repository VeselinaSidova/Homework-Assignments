function solve(input) {
    let cities = {};

    for (const city of input) {
        let [name, product, price] = city.split(' | ');
        price = Number(price);

        if (!cities[product]) {
            cities[product] = {};
        }
        cities[product][name] = price;
    }

    for (const prod in cities) {
        let sorted = Object.entries(cities[prod]).sort((a, b) => a[1] - b[1]);
        console.log(`${prod} -> ${sorted[0][1]} (${sorted[0][0]})`);
    } 
}

solve(['Sample Town | Sample Product | 1000',
'Sample Town | Orange | 2',
'Sample Town | Peach | 1',
'Sofia | Orange | 3',
'Sofia | Peach | 2',
'New York | Sample Product | 1000.1',
'New York | Burger | 10'])