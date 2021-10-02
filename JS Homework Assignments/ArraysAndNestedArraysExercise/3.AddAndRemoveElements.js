function solve(commands) {
    let number = 1;
    let result = [];
    for (let i = 0; i < commands.length; i++) {
        if (commands[i] === 'add') {
            result.push(number);
            number++;
        } else if (commands[i] === 'remove') {
            result.pop(number);
            number++;
        }
    }
    result.length == 0 ? console.log('Empty') : result.forEach(x => console.log(x));
}

solve(['add', 
    'add', 
    'add', 
    'add']);

solve(['add', 
'add', 
'remove', 
'add', 
'add']);

solve(['remove', 
'remove', 
'remove']);