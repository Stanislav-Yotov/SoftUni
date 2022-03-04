window.onload = cookbook;

function cookbook() {
    let main = document.querySelector('main');
    let recipesURL = 'http://localhost:3030/jsonstore/cookbook/recipes';

    fetch(recipesURL)
        .then(res => res.json())
        .then(recipes => {
            makeRecipes(Object.values(recipes))
        });

    function makeRecipes(recipes) {
        main.innerHTML = '';
        recipes.forEach(recipe => {
            main.appendChild(createRecipe(recipe));
        });
    }

    function createRecipe(recipe) {
        let recipeElement = document.createElement('article');
        recipeElement.addEventListener('click', () => {
            let singleRecipeURL = `http://localhost:3030/jsonstore/cookbook/details/${recipe._id}`;
            fetch(singleRecipeURL)
                .then(res => res.json())
                .then(details => {
                    main.innerHTML = '';
                    main.appendChild(recipeDetails(details));
                });
        });
        recipeElement.className = 'preview';
        let divTitleElement = document.createElement('div');
        divTitleElement.className = 'title';
        let h2TitleElement = document.createElement('h2');
        h2TitleElement.textContent = `${recipe.name}`;
        divTitleElement.appendChild(h2TitleElement);

        let divElementSmall = document.createElement('div');
        divElementSmall.className = 'small';
        let imgElement = document.createElement('img');
        imgElement.src = `${recipe.img}`;
        divElementSmall.appendChild(imgElement);
        recipeElement.appendChild(divTitleElement);
        recipeElement.appendChild(divElementSmall);

        return recipeElement;
    }

    function recipeDetails(details) {
        let article = document.createElement('article');
        let h2 = document.createElement('h2');
        h2.textContent = `${details.name}`;
        let divBandElement = document.createElement('div');
        divBandElement.className = 'band';
        let divThumbElement = document.createElement('div');
        divThumbElement.className = 'thumb';
        let img = document.createElement('img');
        img.src = `${details.img}`;
        divThumbElement.appendChild(img);
        divBandElement.appendChild(divThumbElement);

        let divIngredients = document.createElement('div');
        divIngredients.className = 'ingredients';
        let h3 = document.createElement('h3');
        h3.textContent = 'Ingredients:';
        let ul = document.createElement('ul');
        details.ingredients.forEach(ingredient => {
            let li = document.createElement('li');
            li.textContent = ingredient;
            ul.appendChild(li);
        });

        divIngredients.appendChild(h3);
        divIngredients.appendChild(ul);
        divBandElement.appendChild(divIngredients);

        let divDescription = document.createElement('div');
        divDescription.className = 'description';
        let h3Description = document.createElement('h3');
        h3Description.textContent = 'Preparation:';
        divDescription.appendChild(h3Description);
        details.steps.forEach(step => {
            let p = document.createElement('p');
            p.textContent = step;
            divDescription.appendChild(p);
        });

        article.appendChild(divBandElement);
        article.appendChild(divDescription);

        return article;
    }

}