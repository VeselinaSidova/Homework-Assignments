const companyAdministration = {

    hiringEmployee(name, position, yearsExperience) {
        if (position == "Programmer") {
            if (yearsExperience >= 3) {
                return `${name} was successfully hired for the position ${position}.`;
            } else {
                return `${name} is not approved for this position.`;
            }
        }
        throw new Error(`We are not looking for workers for this position.`);
    },
    calculateSalary(hours) {

        let payPerHour = 15;
        let totalAmount = payPerHour * hours;

        if (typeof hours !== "number" || hours < 0) {
            throw new Error("Invalid hours");
        } else if (hours > 160) {
            totalAmount += 1000;
        }
        return totalAmount;
    },
    firedEmployee(employees, index) {

        let result = [];

        if (!Array.isArray(employees) || !Number.isInteger(index) || index < 0 || index >= employees.length) {
            throw new Error("Invalid input");
        }
        for (let i = 0; i < employees.length; i++) {
            if (i !== index) {
                result.push(employees[i]);
            }
        }
        return result.join(", ");
    }

}

const {expect} = require('chai');

describe("Tests …", function() {

    describe("test hiringEmployee …", function() {
       
        it("Different position", function() {
            expect(() => companyAdministration.hiringEmployee('Ivan Ivanov', 'HR', 2)).to.throw(`We are not looking for workers for this position.`);
        });

        it("Correct experience wrong position", function() {
            expect(() => companyAdministration.hiringEmployee('Ivan Ivanov', 'HR', 4)).to.throw(`We are not looking for workers for this position.`);
        });

        it("Less experience", function() {
            expect(companyAdministration.hiringEmployee('Ivan Ivanov', 'Programmer', 2)).to.equal(`Ivan Ivanov is not approved for this position.`);
        });

        it("Correct experience", function() {
            expect(companyAdministration.hiringEmployee('Ivan Ivanov', 'Programmer', 3)).to.equal(`Ivan Ivanov was successfully hired for the position Programmer.`);
        });

        it("Correct experience 2", function() {
            expect(companyAdministration.hiringEmployee('Ivan Ivanov', 'Programmer', 4)).to.equal(`Ivan Ivanov was successfully hired for the position Programmer.`);
        });

     });
     
     describe("test calculateSalary …", function() {
       
        it("Negative Hours", function() {
            expect(() => companyAdministration.calculateSalary(-2)).to.throw(`Invalid hours`);
        });

        it("Negative Hours", function() {
            expect(() => companyAdministration.calculateSalary('1')).to.throw(`Invalid hours`);
        });

        it("Zero Hours", function() {
            expect(companyAdministration.calculateSalary(0)).to.equal(0);
        });

        it("No Bonus Hours", function() {
            expect(companyAdministration.calculateSalary(40)).to.equal(600);
        });

        it("No Bonus Hours 2", function() {
            expect(companyAdministration.calculateSalary(160)).to.equal(2400);
        });

        it("Earned bonus Hours", function() {
            expect(companyAdministration.calculateSalary(180)).to.equal(3700);
        });

     });

     describe("test firedEmployee …", function() {
       
        it("Invalid array", function() {
            expect(() => companyAdministration.firedEmployee(1, 1)).to.throw(`Invalid input`);
        });

        it("Invalid index 1", function() {
            expect(() => companyAdministration.firedEmployee(["Petar", "Ivan", "George"], 1.2)).to.throw(`Invalid input`);
        });

        it("Invalid index 2", function() {
            expect(() => companyAdministration.firedEmployee(["Petar", "Ivan", "George"], -1)).to.throw(`Invalid input`);
        });

        it("Invalid index 3", function() {
            expect(() => companyAdministration.firedEmployee(["Petar", "Ivan", "George"], 'invalid index')).to.throw(`Invalid input`);
        });

        it("Invalid index 3", function() {
            expect(() => companyAdministration.firedEmployee(["Petar", "Ivan", "George"], 3)).to.throw(`Invalid input`);
        });

        it("Valid input", function() {
            expect(companyAdministration.firedEmployee(["Petar", "Ivan", "George"], 1)).to.equal('Petar, George');
        });

     });

});
