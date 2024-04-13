const catBuilder = (cats) => {
    for (let i = 0; i < cats.length; i++) {
        let name = cats[i].split(" ")[0];
        let age = Number(cats[i].split(" ")[1]);
        let cat = new Cat(name, age);
        cat.meow();
    }
};
class Cat {
    constructor(name, age) {
        this.name = name;
        this.age = age;
    }
    meow() {
        console.log(`${this.name}, age ${this.age} says Meow`);
    }
}
catBuilder(["Mellow 2", "Tom 5"]);
catBuilder(["Candy 1", "Poppy 3", "Nyx 2"]);
