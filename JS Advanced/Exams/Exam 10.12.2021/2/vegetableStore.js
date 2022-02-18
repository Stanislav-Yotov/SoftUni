class VegetableStore {
    constructor(owner, location) {
        this.owner = owner;
        this.location = location;
        this.availableProducts = [];
    }

    loadingVegetables(vegetables) {
        let types = new Set;
        for (const vegetable of vegetables) {
            let [type, quantity, price] = vegetable.split(' ');
            types.add(type);
            if (this.availableProducts.some(x => x.type === type)) {
                let currentVegetable = this.availableProducts.find(v => v.type === type);
                currentVegetable.quantity += Number(quantity);
                if (Number(price) > currentVegetable.price) {
                    currentVegetable.price = Number(price);
                }
            } else {
                let vegetableObj = {
                    type,
                    quantity: Number(quantity),
                    price: Number(price)
                };
                this.availableProducts.push(vegetableObj);
            }
        }
        return `Successfully added ${Array.from(types).join(', ')}`;
    };

    buyingVegetables(selectedProducts){
        let totalPrice = 0;
        for (const product of selectedProducts) {
            let [type, quantity] = product.split(' ');
            let currentProduct = this.availableProducts.find(x => x.type === type);
            if (!this.availableProducts.some(x => x.type == type)) {
                throw new Error(`${type} is not available in the store, your current bill is $${totalPrice.toFixed(2)}.`)
            }

            if (Number(quantity) > currentProduct.quantity) {
                throw new Error(`The quantity ${quantity} for the vegetable ${type} is not available in the store, your current bill is $${totalPrice.toFixed(2)}.`)
            }

            totalPrice += Number(quantity) * currentProduct.price;
            currentProduct.quantity -= Number(quantity);
        }

        return `Great choice! You must pay the following amount $${totalPrice.toFixed(2)}.`
    };

    rottingVegetable (type, quantity){
        let currentProduct = this.availableProducts.find(x => x.type === type);
        if (!currentProduct) {
            throw new Error(`${type} is not available in the store.`)
        }

        if (Number(quantity) > currentProduct.quantity) {
            currentProduct.quantity = 0;
            return `The entire quantity of the ${type} has been removed.`;
        } else {
            currentProduct.quantity -= Number(quantity);
            return `Some quantity of the ${type} has been removed.`
        }
    };

    revision (){
        let result = [];
        result.push('Available vegetables:');
        this.availableProducts.sort((a,b) => a.price - b.price);
        this.availableProducts.forEach(x => {
            result.push(`${x.type}-${x.quantity}-$${x.price}`);
        });
        result.push(`The owner of the store is ${this.owner}, and the location is ${this.location}.`);

        return result.join('\n');
    };
}

//let vegStore = new VegetableStore("Jerrie Munro", "1463 Pette Kyosheta, Sofia");
//console.log(vegStore.loadingVegetables(["Okra 2.5 3.5", "Beans 10 2.8", "Celery 5.5 2.2", "Celery 0.5 2.5"]));

/*let vegStore = new VegetableStore("Jerrie Munro", "1463 Pette Kyosheta, Sofia");
 console.log(vegStore.loadingVegetables(["Okra 2.5 3.5", "Beans 10 2.8", "Celery 5.5 2.2", "Celery 0.5 2.5"]));
 console.log(vegStore.buyingVegetables(["Okra 1"]));
 console.log(vegStore.buyingVegetables(["Beans 8", "Okra 1.5"]));
 console.log(vegStore.buyingVegetables(["Banana 1", "Beans 2"])); */

 /*let vegStore = new VegetableStore("Jerrie Munro", "1463 Pette Kyosheta, Sofia");
console.log(vegStore.loadingVegetables(["Okra 2.5 3.5", "Beans 10 2.8", "Celery 5.5 2.2", "Celery 0.5 2.5"]));
console.log(vegStore.rottingVegetable("Okra", 1));
console.log(vegStore.rottingVegetable("Okra", 2.5));
console.log(vegStore.buyingVegetables(["Beans 8", "Okra 1.5"]));*/

let vegStore = new VegetableStore("Jerrie Munro", "1463 Pette Kyosheta, Sofia");
console.log(vegStore.loadingVegetables(["Okra 2.5 3.5", "Beans 10 2.8", "Celery 5.5 2.2", "Celery 0.5 2.5"]));
console.log(vegStore.rottingVegetable("Okra", 1));
console.log(vegStore.rottingVegetable("Okra", 2.5));
console.log(vegStore.buyingVegetables(["Beans 8", "Celery 1.5"]));
console.log(vegStore.revision());



