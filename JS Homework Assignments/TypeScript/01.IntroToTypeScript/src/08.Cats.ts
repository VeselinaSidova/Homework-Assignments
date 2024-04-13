const catBuilder = (cats: string[]) => {
  for (let i = 0; i < cats.length; i++) {
    let name: string = cats[i].split(" ")[0];
    let age: number = Number(cats[i].split(" ")[1]);
    let cat = new Cat(name, age);
    cat.meow();
  }
};

class Cat {
  name: string;
  age: number;

  constructor(name: string, age: number) {
    this.name = name;
    this.age = age;
  }
  meow() {
    console.log(`${this.name}, age ${this.age} says Meow`);
  }
}

catBuilder(["Mellow 2", "Tom 5"]);
catBuilder(["Candy 1", "Poppy 3", "Nyx 2"]);
