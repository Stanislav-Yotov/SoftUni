class ArtGallery {
    constructor(creator) {
        this.creator = creator;
        this.possibleArticles = { picture: 200, photo: 50, item: 250 };
        this.listOfArticles = [];
        this.guests = [];
    }

    addArticle(articleModel, articleName, quantity) {
        articleModel = articleModel.toLowerCase();
        quantity = Number(quantity);
        let currentArticle = this.listOfArticles.find(x => x.articleName == articleName);

        if (!this.possibleArticles[articleModel]) {
            throw new Error('This article model is not included in this gallery!')
        }

        if (currentArticle && currentArticle.articleModel == articleModel) {
            currentArticle.quantity += quantity;
        } else{
            this.listOfArticles.push({articleModel, articleName, quantity});
            currentArticle = this.listOfArticles.find( x => x.articleName == articleName);
        }
        return `Successfully added article ${articleName} with a new quantity- ${quantity}.`;
    };

    inviteGuest(guestName, personality){
        if (this.guests.find(x => x.guestName == guestName)) {
            throw new Error(`${guestName} has already been invited.`)
        }

        let points = 0;

        if (personality == 'Vip') {
            points = 500;
        } else if (personality == 'Middle') {
            points = 250;
        } else{
            points = 50;
        }

        this.guests.push({guestName, personality, purchaseArticle: 0});
        return `You have successfully invited ${guestName}!`;
    };

    buyArticle(articleModel, articleName, guestName){
        let currentArticles = this.listOfArticles.filter(x => x.articleName == articleName);
        articleModel = articleModel.toLowerCase();
        let currentGuest = this.guests.find(x => x.guestName == guestName);
        let currentArticle = currentArticles.find(x => x.articleModel == articleModel);
        if (!currentArticle) {
            throw new Error('This article is not found.');
        }

        if (currentArticle.quantity == 0) {
            throw new Error(`The ${articleName} is not available.`);
        }

        if (!currentGuest) {
            return 'This guest is not invited.';
        }

        if (currentGuest.points < this.possibleArticles[articleModel]) {
            return 'You need to more points to purchase the article.';
        }

        currentGuest.points -= this.possibleArticles[articleModel];
        currentGuest.purchaseArticle++;
        currentArticle.quantity--;
        return `${guestName} successfully purchased the article worth ${this.possibleArticles[articleModel]} points.`;
    };

    showGalleryInfo(criteria){
        let result = [];
        if (criteria == 'article') {
            result.push('Articles information:');
            for (const article of this.listOfArticles) {
                result.push(`${article.articleModel} - ${article.articleName} - ${article.quantity}`)
            }
        } else if (criteria == 'guest') {
            result.push('Guests information:');
            for (const guest of this.guests) {
                result.push(`${guest.guestName} - ${guest.purchaseArticle}`);
            }
        }

        return result.join('\n');
    };
} 


const artGallery = new ArtGallery('Curtis Mayfield'); 
artGallery.addArticle('picture', 'Mona Liza', 3);
artGallery.addArticle('Item', 'Ancient vase', 2);
artGallery.addArticle('picture', 'Mona Liza', 1);
artGallery.inviteGuest('John', 'Vip');
artGallery.inviteGuest('Peter', 'Middle');
artGallery.buyArticle('picture', 'Mona Liza', 'John');
artGallery.buyArticle('item', 'Ancient vase', 'Peter');
console.log(artGallery.showGalleryInfo('article'));
console.log(artGallery.showGalleryInfo('guest'));

