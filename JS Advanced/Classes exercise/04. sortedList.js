class List{
    constructor(){
        this.elements = [];
        this.size = this.elements.length;
    }

    add(element){
        this.elements.push(Number(element));
        this.elements.sort((a,b) => a - b);
        this.size++;
    }

    remove(index){
        if (index < 0 || index >= this.elements.length) {
            throw new Error('Index out of range');
        }
        this.elements.splice(index, 1);
        this.size--;
    }

    get(index){
        if (index < 0 || index >= this.elements.length) {
            throw new Error('Index out of range');
        }

        return this.elements[index];
    }
}

let list = new List();
list.add(5);
list.add(6);
list.add(7);
console.log(list.get(1)); 
list.remove(1);
console.log(list.get(1));
