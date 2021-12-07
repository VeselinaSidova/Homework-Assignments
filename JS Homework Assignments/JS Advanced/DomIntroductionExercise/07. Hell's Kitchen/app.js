function solve() {
   document.querySelector('#btnSend').addEventListener('click', onClick);

   function onClick () {
      let textAreaElement = document.querySelector('#inputs textarea');
      
      let text = JSON.parse(textAreaElement.value);

      let restaurants = {};

      for (let i = 0; i < text.length; i++) {
         let [restaurantName, workersString] = text[i].split(' - ');
         let inputWorkers = workersString.split(', ').map(w => {
            let [name, salary] = w.split(' ');
            return { name, salary: Number(salary) };
         });

         if (!restaurants[restaurantName]) {
            restaurants[restaurantName] = {
               workers: [],
               restaurantName: restaurantName,
               getAverageSalary() {
                  return this.workers.reduce((acc, el) => acc + el.salary, 0) / this.workers.length
               }
            }
         }

         restaurants[restaurantName].workers = restaurants[restaurantName].workers.concat(inputWorkers);
      }

      let sortedRestaurants = Object.values(restaurants)
         .sort((a, b) => b.getAverageSalary() - a.getAverageSalary());

      let bestRestaurant = sortedRestaurants[0];
      let sortedWorkers = bestRestaurant.workers.sort((a, b) => b.salary - a.salary);
      let averageSalary = bestRestaurant.getAverageSalary().toFixed(2);
      let bestSalary = sortedWorkers[0].salary.toFixed(2);
      let topRestaurantString = `Name: ${bestRestaurant.restaurantName} Average Salary: ${averageSalary} Best Salary: ${bestSalary}`;
      let sortedWorksersString = sortedWorkers.map(x => `Name: ${x.name} With Salary: ${x.salary}`).join(' ');

      let bestRestaurantElement = document.querySelector('#bestRestaurant p');
      let workersElement = document.querySelector('#workers p');

      bestRestaurantElement.textContent = topRestaurantString;
      workersElement.textContent = sortedWorksersString;
   }
}