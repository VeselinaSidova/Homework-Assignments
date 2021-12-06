function createSortedList() {
    let numbers = [];
    let size = 0;
    return { 
        numbers,
        size: size,
        add(number) {
            this.numbers.push(number);
            this.size++;
            return this.numbers.sort((a, b) => a - b);
        },
        remove(index) {
            if (index < 0 || index >= this.numbers.length) {
                return;
            }
            this.size--;
            this.numbers.splice(index, 1);
            return numbers.sort((a, b) => a - b);
        },
        get(index) {
            if (index < 0 || index >= this.numbers.length) {
                return;
            }
            return this.numbers[index];
        },
    };
}


let list = createSortedList();
list.add(5);
list.add(6);
list.add(7);
console.log(list.get(1)); 
list.remove(1);
console.log(list.get(1));
console.log(list.size);

