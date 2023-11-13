function solve(date, year) {
    let result = new Date(year, date, 0).getDate();
    console.log(result);
}

solve(2, 2012);


