function solve(input) {
    const towns = {};

    for (let data of input) {
        let[town, population] = data.split(' <-> ');
        population = Number(population);

        if (towns[town]) {
            population += towns[town];
        }
        towns[town] = population;
    }
    for (const [town, population] of Object.entries(towns)) {
        console.log(`${town} : ${population}`);
    }
}

solve(['Sofia <-> 1200000',
'Montana <-> 20000',
'New York <-> 10000000',
'Washington <-> 2345000',
'Las Vegas <-> 1000000']);

solve(['Istanbul <-> 100000',
'Honk Kong <-> 2100004',
'Jerusalem <-> 2352344',
'Mexico City <-> 23401925',
'Istanbul <-> 1000']);