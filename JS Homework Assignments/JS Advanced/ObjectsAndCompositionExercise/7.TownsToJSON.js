function solve(input) {
    let towns = [];

    input = input.splice(1, 2);

    for (const index in input) {
        let row = input[index].slice(2, input[index].length - 2);
        let [town, latitude, longitude] = row.split(' | ');
        towns.push({
            Town: town,
            Latitude: Number(Number(latitude).toFixed(2)),
            Longitude: Number(Number(longitude).toFixed(2)),
        });
    }

    console.log(JSON.stringify(towns));
}

solve(['| Town | Latitude | Longitude |',
'| Sofia | 42.696552 | 23.32601 |',
'| Beijing | 39.913818 | 116.363625 |'])